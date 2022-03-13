using System;
using System.Text;

namespace HackerRank_Problem_Solving
{
    class SuperReducedString
    {
        public static string superReducedString(string s)
        {
            string OriginalString = s;
            var ReducedString = new StringBuilder();
            ReducedString.Append(OriginalString[0]);

            for (var i = 1; i < OriginalString.Length; i++)
            {
                if (ReducedString.Length > 0 && OriginalString[i] == ReducedString[ReducedString.Length - 1])
                {
                    ReducedString = ReducedString.Remove(ReducedString.Length - 1, 1);
                }
                else
                {
                    ReducedString.Append(OriginalString[i]);
                }

            }
            return ReducedString.ToString();
        }
    }
}
