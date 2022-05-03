using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVSkurs
{
    class Controller
    {
        TimeCounter timer;
        int msgcnt;

        public Controller()
        {
            timer = new TimeCounter();
            msgcnt = 0;
        }

        public int getTime()
        {
            return timer.getTime();
        }

        public int getMsgcnt()
        {
            return msgcnt;
        }

        public void Failure()
        {
            timer.addTime("command");
            timer.addTime("word");
            timer.addTime("pause_before_answer");
            msgcnt += 13;
        }

        public void Denial(LineStatus ls)
        {
            for (int i = 0; i < 2; i++)
            {
                timer.addTime("command");
                timer.addTime("word");
                timer.addTime("pause_before_answer");
                msgcnt += 13;
            }
            ls.line = "B";
            ls.status = "working";
        }

        public void Busy()
        {
            timer.addTime("command");
            timer.addTime("word");
            timer.addTime("pause_before_answer");
            timer.addTime("answer");
            timer.addTime("pause_if_busy");
            msgcnt += 14;
        }

        public void NormalWork(LineStatus ls)
        {
            timer.addTime("command");
            timer.addTime("word");
            timer.addTime("pause_before_answer");
            timer.addTime("answer");
            ls.line = "A";
            ls.status = "working";
            msgcnt += 14;
        }


        public void findGenerator(SortedDictionary<Int32, OU> clients, LineStatus ls)
        {
            // ====================================
            for (int J = 0; J < 18; J++)
            {
                timer.addTime("command");
                timer.addTime("pause_before_answer");
                msgcnt += 1;
            }
            //================================================

            //=============== Блокировка всех ОУ =============
            ls.line = "B";
            ls.status = "working";
            for (int K = 0; K < 18; K++)
            {
                timer.addTime("block");
                timer.addTime("pause_before_answer");
                timer.addTime("answer");
                clients.ElementAt(K).Value.chState("blocked");
                msgcnt += 2;
            }
            //==================================================
            int i = 0;
            do
            {
                ls.line = "B";
                ls.status = "working";
                //======= Разблокировка одного ОУ ==========
                timer.addTime("unblock");
                timer.addTime("pause_before_answer");
                timer.addTime("answer");
                clients.ElementAt(i).Value.chState("working");
                msgcnt += 2;
                //===========================================
                ls.line = "A";
                ls.status = "working";
                //========================= Опрос текущего ОУ ===============================
                timer.addTime("command");
                timer.addTime("pause_before_answer");
                msgcnt += 1;
                if (!(clients.ElementAt(i).Value.state.Equals("generator"))) { timer.addTime("answer"); msgcnt += 1; }
                //===========================================================================
                else
                {
                    //======== Опрос предыдущего ОУ ==========
                    timer.addTime("command");
                    timer.addTime("pause_before_answer");
                    msgcnt += 1;
                    //========================================
                    ls.line = "B";
                    ls.status = "working";
                    //====== Блокируем генерящий элемент ======
                    timer.addTime("block");
                    timer.addTime("pause_before_answer");
                    timer.addTime("answer");
                    clients.ElementAt(i).Value.chState("blocked");
                    msgcnt += 2;
                    //=========================================
                    break;
                }
                i++;
            } while (true);
            i++;
            //===== Разблокировка ОУ после генерящего =====
            for (; i < 18; i++)
            {
                timer.addTime("unblock");
                timer.addTime("pause_before_answer");
                timer.addTime("answer");
                clients.ElementAt(i).Value.chState("working");
                msgcnt += 2;
                //==============================================
            }
            ls.line = "A";
            ls.status = "working";
        }
    }
}
