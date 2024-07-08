using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Y2024.M07.D08
{
    public static class Implementation2024_07_08
    {
        public static int FindTheWinner(int n, int k)
        {
            var list = new List<int>();

            for (int i = 0; i < n; i++)
            {
                list.Add(i+1);
            }

            int listPosition = 0;

            while (list.Count > 1)
            {
                int counter = 1;
                while (counter != k)
                {
                    if (listPosition == list.Count)
                    {
                        listPosition = 0;
                    }
                    listPosition++;
                    counter++;
                }
                if (listPosition == list.Count)
                {
                    listPosition = 0;
                }
                Console.WriteLine(list[listPosition] + "elemenated");
                list.RemoveAt(listPosition);
            }

            return list.First();
        }
    }
}
