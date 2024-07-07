using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Y2024.M07.D07
{
    /// <summary>
    /// Water Bottles
    /// </summary>
    public static class Implementation2024_07_07
    {
        public static class Solution
        {
            public static int NumWaterBottles(int numBottles, int numExchange)
            {
                var sum = 0;
                var empty = 0;

                while (numBottles > 0)
                {
                    sum += numBottles;
                    empty += numBottles;
                    numBottles = empty / numExchange;
                    empty = empty - numBottles * numExchange;
                }

                return sum;
            }
        }
    }
}
