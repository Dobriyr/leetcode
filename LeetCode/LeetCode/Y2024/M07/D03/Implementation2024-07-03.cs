using System.Runtime.Intrinsics.X86;

namespace LeetCode.Y2024.M07.D03
{
    /// <summary>
    /// Minimum Difference Between Largest and Smallest Value in Three Moves
    /// </summary>
    public static class Implementation2024_07_03
    {
        public static int MinDifference(int[] nums)
        {
            if (nums.Length < 5)
            {
                return 0;
            }

            Array.Sort(nums);
            int minDifference = int.MaxValue;

            for (int i = 0; i <= 3; i++)
            {
                var curentDiference = nums[nums.Length - 1 - i] - nums[3 - i];
                if (curentDiference < minDifference)
                {
                    minDifference = curentDiference;
                }
            }
            return minDifference;
        }

        private static void Print(int[] array)
        {
            for (int i=0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}. {array[i]}");
            }
        }
    }
}
