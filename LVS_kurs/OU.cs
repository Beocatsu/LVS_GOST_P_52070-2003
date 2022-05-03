using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVSkurs
{
    class OU
    {
        SortedDictionary<String, String> states;
        public String state;
        String my_buf;

        public OU()
        {
            states = new SortedDictionary<String, String>();
            states.Add("working", "working");
            states.Add("not_working", "not_working");
            states.Add("blocked", "blocked");
            states.Add("busy", "busy");
            states.Add("failure", "failure");
            states.Add("denial", "denial");
            states.Add("generator", "generator");
            states.TryGetValue("working", out state);
            my_buf = "";
        }

        public String lookStatus()
        {
            return state;
        }

        public void chState(String st)
        {
            if (st.Equals("working"))
            {
                state = my_buf;
            }
            else
            {
                my_buf = state;
                states.TryGetValue(st, out state);
            }
        }

        public void Fault(Random rand)
        {
            if (!((state.Equals("blocked")) || (state.Equals("denial"))))
            {

                int gen = rand.Next() % 20000;
                if (gen == 1)
                {
                    state = "generator";
                    return;
                }
                int den = rand.Next() % 4300;
                if (den == 1)
                {
                    state = "denial";
                    return;
                }
                int fail = rand.Next() % 2000;
                if (fail == 1)
                {
                    state = "failure";
                    return;
                }
                int busy = rand.Next() % 2000;
                if (busy == 1)
                {
                    state = "busy";
                    return;
                }
            }
        }
    }
}
