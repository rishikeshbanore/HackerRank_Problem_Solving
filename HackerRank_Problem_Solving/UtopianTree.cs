using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Problem_Solving
{
    class UtopianTree
    {
        public static int utopianTree(int n)
        {
            int Height = 1;

            for (int i = 1; i <= n; i++)
            {
                if (i% 2 == 0)
                {
                    Height = Height + 1;
                }
                else
                {
                    Height = Height + Height;
                }
            }
            return Height;
        }
    }
}
