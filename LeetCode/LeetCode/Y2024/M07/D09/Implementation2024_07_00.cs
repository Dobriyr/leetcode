using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Y2024.M07.D09
{
    /// <summary>
    /// Average Waiting Time
    /// </summary>
    public static class Implementation2024_07_00
    {
        public static double AverageWaitingTime(int[][] customers)
        {
            int start = 1;
            double sum = 0;

            foreach (var customer in customers)
            {
                if (start < customer[0])
                {
                    start = customer[0];
                }

                sum += start + customer[1] - customer[0];
                
                start = start + customer[1];
            }
            Console.WriteLine(sum);
            return sum / customers.Count();
        }
        private static int WaitTime(int arive, int timeToCook, int readyToStartCook)
        {
            return 0;
        }
    }
}
