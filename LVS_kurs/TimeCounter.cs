using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVSkurs
{
    class TimeCounter
    {
        int total_time;
        SortedDictionary<String, Int32> time_types;

        public TimeCounter()
        {
            time_types = new SortedDictionary<String, Int32>();
            total_time = 0;
            time_types.Add("pause_if_busy", 5000);
            time_types.Add("command", 20);
            time_types.Add("pause_before_answer", 12);
            time_types.Add("word", 12 * 20);
            time_types.Add("block", 20);
            time_types.Add("unblock", 20);
            time_types.Add("pause_between_messages", 1000);
            time_types.Add("answer", 20);
        }

        public void addTime(String type)
        {
            time_types.TryGetValue(type, out int c);
            total_time += c;
        }

        public int getTime()
        {
            return total_time;
        }
    }
}
