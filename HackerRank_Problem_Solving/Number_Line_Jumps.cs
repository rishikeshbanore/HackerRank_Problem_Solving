using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Problem_Solving
{
    class Number_Line_Jumps
    {
        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            if (v1 > v2)
            {
                if ((x2 - x1) % (v1 - v2) == 0)
                {
                    return "YES";
                }
                else
                {
                    return "NO";
                }
            }
            else
            {
                return "NO";
            }
        }

    }
}
