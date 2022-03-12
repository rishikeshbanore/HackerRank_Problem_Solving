using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Problem_Solving
{
    class FlippingBits
    {
        public static long flippingBits(long n)
        {
            long[] a = new long[32];
            long number =0;

            //Converting Number to Binary.
            int i = 0;

            while (n > 0)
            {
                a[i] = n % 2;
                n = n / 2;
                i++;
            }

            //Flipping Bits
            for (int j = 0; j <32; j++)
            {
                if (a[j] == 0)
                {
                    a[j] = 1;
                }
                else
                {
                    a[j] = 0;
                }
            }

            
            //converting Binary to Decimal

            for (int k = 0; k < 32; k++)
            {
                if (a[k] == 1)
                {
                    if (k == 0)
                    {
                        number += 1;
                    }
                    else
                    {
                        number += (long)Math.Pow(2, k);
                    }
                }
            }

            return number;
        }

    }
}
