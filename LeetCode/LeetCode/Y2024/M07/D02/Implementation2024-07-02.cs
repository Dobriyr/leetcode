namespace LeetCode.Y2024.M07.D02
{
    /// <summary>
    /// ntersection of Two Arrays II
    /// </summary>
    public static class Implementation2024_07_02
    {
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
                var dictionary = new Dictionary<int,int>();

                foreach (int number in nums1)
                {
                    if (dictionary.ContainsKey(number))
                    {
                        dictionary[number]++;
                    }
                    else
                    {
                        dictionary.Add(number, 1);
                    }
                }

                var result = new List<int>();

                foreach (int number in nums2)
                {
                    if (dictionary.ContainsKey(number) && dictionary[number] > 0)
                    {
                        result.Add(number);
                        dictionary[number]--;
                    }
                }

            return result.ToArray();
        }
    }
}
