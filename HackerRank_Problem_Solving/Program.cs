using System;


namespace HackerRank_Problem_Solving
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Problem 1:
            /*You are choreographing a circus show with various animals. 
               For one act, you are given two kangaroos on a number line ready to jump 
               in the positive direction (i.e, toward positive infinity).
               The first kangaroo starts at location  and moves at a rate of  meters per jump.
               The second kangaroo starts at location  and moves at a rate of  meters per jump.
               You have to figure out a way to get both kangaroos at the same location at the same time as part of the show.
               If it is possible, return YES, otherwise return NO.*/

            ////TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            //int x1 = Convert.ToInt32(firstMultipleInput[0]);

            //int v1 = Convert.ToInt32(firstMultipleInput[1]);

            //int x2 = Convert.ToInt32(firstMultipleInput[2]);

            //int v2 = Convert.ToInt32(firstMultipleInput[3]);

            //string result = Number_Line_Jumps.kangaroo(x1, v1, x2, v2);

            //Console.WriteLine(result);

            ////textWriter.Flush();
            ////textWriter.Close();

            ////Problem 2:
            /*An integer  is a divisor of an integer  if the remainder of .
              Given an integer, for each digit that makes up the integer determine whether it is a divisor.
              Count the number of divisors occurring within the integer.*/

            ////TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                int result = FindDigits.findDigits(n);

                Console.WriteLine(result);
            }

            //textWriter.Flush();
            //textWriter.Close();

        }
    }
}
