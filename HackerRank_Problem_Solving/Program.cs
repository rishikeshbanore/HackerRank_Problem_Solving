using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank_Problem_Solving
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Problem 1: - Kangaroo

            /*You are choreographing a circus show with various animals. 
               For one act, you are given two kangaroos on a number line ready to jump 
               in the positive direction (i.e, toward positive infinity).
               The first kangaroo starts at location  and moves at a rate of  meters per jump.
               The second kangaroo starts at location  and moves at a rate of  meters per jump.
               You have to figure out a way to get both kangaroos at the same location at the same time as part of the show.
               If it is possible, return YES, otherwise return NO.*/


            //string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            //int x1 = Convert.ToInt32(firstMultipleInput[0]);

            //int v1 = Convert.ToInt32(firstMultipleInput[1]);

            //int x2 = Convert.ToInt32(firstMultipleInput[2]);

            //int v2 = Convert.ToInt32(firstMultipleInput[3]);

            //string result = Number_Line_Jumps.kangaroo(x1, v1, x2, v2);

            //Console.WriteLine(result);




            ////Problem 2: Find the Digit

            /*An integer  is a divisor of an integer  if the remainder of .
              Given an integer, for each digit that makes up the integer determine whether it is a divisor.
              Count the number of divisors occurring within the integer.*/

            ////TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int t = Convert.ToInt32(Console.ReadLine().Trim());

            //for (int tItr = 0; tItr < t; tItr++)
            //{
            //    int n = Convert.ToInt32(Console.ReadLine().Trim());

            //    int result = FindDigits.findDigits(n);

            //    Console.WriteLine(result);
            //}



            ////Problem 3: Cut the Sticks

            /*You are given a number of sticks of varying lengths. You will iteratively cut the sticks into smaller sticks, 
             * discarding the shortest pieces until there are none left. 
             * At each iteration you will determine the length of the shortest stick remaining, 
             * cut that length from each of the longer sticks and then discard all the pieces of that shortest length. 
             * When all the remaining sticks are the same length, they cannot be shortened so discard them.
             * Given the lengths of  sticks, print the number of sticks that are left before each iteration until there are none left.*/



            //int n = Convert.ToInt32(Console.ReadLine().Trim());

            //List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            //List<int> result = Cut_The_Sticks.cutTheSticks(arr);

            //Console.WriteLine(String.Join("\n", result));



            ////Problem 4: FlipDigits
            /*You will be given a list of 32 bit unsigned integers. 
             * Flip all the bits ( and ) and return the result as an unsigned integer.*/


            //int q = Convert.ToInt32(Console.ReadLine().Trim());

            //for (int qItr = 0; qItr < q; qItr++)
            //{
            //    long n = Convert.ToInt64(Console.ReadLine().Trim());

            //    long result = FlippingBits.flippingBits(n);

            //    Console.WriteLine(result);
            //}


            ////Problem 5: Utopian Tree
            
            //int t = Convert.ToInt32(Console.ReadLine().Trim());

            //for (int tItr = 0; tItr < t; tItr++)
            //{
            //    int n = Convert.ToInt32(Console.ReadLine().Trim());

            //    int result = UtopianTree.utopianTree(n);

            //    Console.WriteLine(result);
            //}

    }
    }
}
