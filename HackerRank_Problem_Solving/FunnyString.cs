using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank_Problem_Solving
{
    class FunnyString
    {
        public static string funnyString(string s)
        {
            string OriginalString = s;
            int DiffCount = 0;
            List<int> AsciOriginalString = new List<int>();
            List<int> AsciReversedString = new List<int>();
            List<int> AsciOriginalStringDiff = new List<int>();
            List<int> AsciReversedStringDiff = new List<int>();

            //Getting ASCI Numbers for Chars in Original String.
            foreach (char c in OriginalString)
            {
                AsciOriginalString.Add((int)c);
            }

            AsciReversedString= Enumerable.Reverse(AsciOriginalString).ToList();

            //Calculating Difference in Adj ASCI coded in Original Screen.
            for (int i = 0; i < AsciOriginalString.Count()-1; i++)
            {
                AsciOriginalStringDiff.Add(Math.Abs(AsciOriginalString[i] - AsciOriginalString[i + 1]));
            }

            //Calculating Difference in Adj ASCI coded in Original Screen.
            for (int i = 0; i < AsciReversedString.Count()-1; i++)
            {
                AsciReversedStringDiff.Add(Math.Abs(AsciReversedString[i] - AsciReversedString[i + 1]));
            }


            for (int j = 0; j < AsciOriginalStringDiff.Count(); j++)
            {
                if (AsciOriginalStringDiff[j].Equals(AsciReversedStringDiff[j]))
                {
                    Console.WriteLine("Matching element");
                }
                else
                {
                    DiffCount++;
                }
            }

            if (DiffCount==0)
            {
                return "Funny";
            }
            else
            {
                return "Not Funny";
            }

        }
    }
}
