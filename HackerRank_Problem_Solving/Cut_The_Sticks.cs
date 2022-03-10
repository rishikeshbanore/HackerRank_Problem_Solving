using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank_Problem_Solving
{
    class Cut_The_Sticks
    {
        public static List<int> cutTheSticks(List<int> arr)
        {
            List<int>Count = new List<int>();
            List<int> OriginalList = arr;
            List<int> modified = arr;
            List<int> modified_Temp = new List<int>();

            while (modified.Count()!= 1)
            {
                Count.Add(modified.Count());
                int least = modified.AsQueryable().Min();
                modified_Temp.Clear();
                foreach (int Num in modified)
                {
                    if ((Num - least)!=0)
                    {
                        modified_Temp.Add(Num - least);
                    }
                    else
                    {
                        Console.WriteLine("0 will not be added to List");
                    }
                }

               modified = modified_Temp.ToList();

            }
            Count.Add(1);
            return Count;
        }
    }
}
