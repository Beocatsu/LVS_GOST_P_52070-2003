using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LVSkurs
{
    class Logger
    {
        SortedDictionary<String, String> phrases;
        StreamWriter logsfile;

        Logger(String filename)
        {
            phrases = new SortedDictionary<String, String>();
            phrases.Add("lvs_start", "ЗапускЛВС\r\n");
            phrases.Add("lvs_restart", "ПерезапускЛВС\r\n");
            phrases.Add("status_working", "Статус: ВсеОУработают\r\n");
            phrases.Add("ou_turn_off", "ОУ № искусственно выключен\r\n");
            phrases.Add("ou_turn_on", "ОУ № искусственно включен\r\n");
            phrases.Add("ou_turn_failure", "На ОУ № искусственно включен сбой\r\n");
            phrases.Add("ou_turn_denial", "На ОУ № искусственно включен отказ\r\n");
            phrases.Add("ou_turn_generating", "На ОУ № искусственно включена генерация\r\n");
            phrases.Add("make_round", "Производится обход\r\n");
            phrases.Add("status_ou_off", "Статус: ОУ № выключен\r\n");
            phrases.Add("status_ou_failure", "Статус: НаОУ № произошелсбой\r\n");
            phrases.Add("status_ou_denial", "Статус: НаОУ № произошелотказ\r\n");
            phrases.Add("status_ou_generator", "Статус: ОУ № генератор\r\n");
            phrases.Add("makeround_fail", "Невозможно выполнить обход на линии\r\n");
            phrases.Add("active_line", "Активная линия №\r\n");

            logsfile = new StreamWriter(filename);
            DateTime date = DateTime.Today;
            addToFile(date.ToString());
            addToFile("\r\n------------------------------\r\n");
        }

        public String getLogsLine(String type)
        {
            phrases.TryGetValue(type, out string s);
            String ntype = (!(s.Equals(""))) ? s : type;
            addToFile(ntype);
            return ntype;
        }

        public void addToFile(String logline)
        {
            logsfile.Write(logline);
        }

        public void closeFile()
        {
            logsfile.Close();
        }
    }
}
