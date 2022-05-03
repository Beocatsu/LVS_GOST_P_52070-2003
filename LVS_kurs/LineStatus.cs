using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LVSkurs
{
    class LineStatus
    {
        public String line;
        public String status;

        public LineStatus(int i)
        {
            if (i == 1)
            {
                line = "A";
                status = "working";
            }
            else
            {
                line = "B";
                status = "working";
            }
        }

    }
}
