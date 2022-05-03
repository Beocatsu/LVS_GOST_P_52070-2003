using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVSkurs
{
    class LVS
    {
        public SortedDictionary<Int32, OU> clients;
        public Controller ctrl;
        LineStatus ls;
        public StringBuilder sb;
        int[] fullfails;

        public LVS(int p, int count = 18)
        {
            sb = new StringBuilder();
            fullfails = new int[4];
            ctrl = new Controller();
            clients = new SortedDictionary<Int32, OU>();
            for (int i = 0; i < count; i++) clients.Add(i, new OU());
            ls = new LineStatus(p);
        }

        public void working_20000(bool ran, Random rand1)
        {
            for (int i = 0; i < 20; i++)
            {
                working_1000(ran, rand1);
            }
            sb.Append("\nСтатистика сеанса\n" + "Генераций: " + fullfails[0] + "\r\nОтказов: " + fullfails[1] + "\r\nСбойев: " + fullfails[2] + "\r\nАбонент занят: " + fullfails[3] + "\n");
            sb.Append("total time: " + "\n");
            sb.Append(ctrl.getTime() + "\n");
        }

        public void working_1000(bool rand, Random rand1)
        {
            int time = ctrl.getTime();
            int[] Flt = new int[4];
            for (int i = 0; i < 55; i++)
            {
                working_18(Flt, rand, rand1);
            }
            sb.Append("Количество ошибок: " + "\n");
            sb.Append("Генерация: " + Flt[0] + "\r\nОтказ: " + Flt[1] + "\r\nСбой: " + Flt[2] + "\r\nАбонент занят: " + Flt[3] + "\n");
            for (int i = 0; i < 4; i++) { fullfails[i] += Flt[i]; }
            time = ctrl.getTime() - time;
            sb.Append("Time for 1000: " + time + "\n");
        }

        public void working_18(int[] Flt, bool random, Random rand)
        {
            //================= Случайное возникновение неполадок =====================
            for (int i = 0; i < 18; i++)
            {
                if (clients.ElementAt(i).Value.state.Equals("denial")) Flt[1]--;
                if (random) { clients.ElementAt(i).Value.Fault(rand); }
                if (clients.ElementAt(i).Value.state.Equals("generator"))
                {
                    ls.status = "generation";
                    Flt[0]++;
                }
                if (clients.ElementAt(i).Value.state.Equals("denial"))
                {
                    Flt[1]++;
                }
                if (clients.ElementAt(i).Value.state.Equals("blocked"))
                {
                    Flt[1]++;
                }
                if (clients.ElementAt(i).Value.state.Equals("failure"))
                {
                    Flt[2]++;
                }
                if (clients.ElementAt(i).Value.state.Equals("busy"))
                {
                    Flt[3]++;
                }
            }

            //===== Действия при генерации ======
            if (ls.status.Equals("generation"))
            {
                ctrl.findGenerator(clients, ls);
            }
            for (int i = 0; i < 18; i++)
            {
                if (clients.ElementAt(i).Value.state.Equals("failure"))
                {
                    ctrl.Failure();
                    clients.ElementAt(i).Value.chState("working");
                }
                if (clients.ElementAt(i).Value.state.Equals("busy"))
                {
                    ctrl.Busy();
                    clients.ElementAt(i).Value.chState("working");
                }
                if ((clients.ElementAt(i).Value.state.Equals("denial")) || (clients.ElementAt(i).Value.state.Equals("blocked")))
                {
                    ctrl.Denial(ls);
                }

                ctrl.NormalWork(ls);
            }
        }

    }
}
