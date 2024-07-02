namespace LeetCode.Y2024.M07.D01
{
    /// <summary>
    /// Three Consecutive Odds
    /// </summary>
    public static class Implementation2024_07_01
    {
        public static bool ThreeConsecutiveOdds(int[] arr)
        {
            var counter = 0;
            foreach(int a in arr)
            {
                if (a % 2 != 0)
                {
                    if (counter == 2)
                    {
                        return true;
                    }
                    counter++;
                }
                else if(counter != 0)
                {
                    counter = 0;
                }
                
            }
            return false;
        }
    }
}
