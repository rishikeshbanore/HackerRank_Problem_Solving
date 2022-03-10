using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Problem_Solving
{
    class FindDigits
    {
        public static int findDigits(int n)
        {
            int No_Of_Divisors = 0;
            int original_Number =n;
            int NummberDivide = n;

            if (n < 10)
            {
                No_Of_Divisors = 1;

                return No_Of_Divisors;
            }
            else
            {
                while (NummberDivide % 10 != 0 || NummberDivide / 10 > 0)
                {
                    int Divisor = NummberDivide % 10;

                    if (Divisor!=0)
                    {
                        if (original_Number % Divisor == 0)
                        {
                            No_Of_Divisors++;
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        Console.WriteLine("skipping to next number");
                    }

                    NummberDivide = NummberDivide / 10;
                }
            }

            return No_Of_Divisors;
        }
    }
}
