namespace LeetCode.TopInterview._1MergeSortedArray
{
    /// <summary>
    /// Easy - Merge Sorted Array
    /// </summary>
    public static class Solution
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m + n - 1;
            int pointer1 = m - 1;
            int pointer2 = n - 1;

            while (pointer2 >= 0)
            {
                if (pointer1 >= 0 && nums1[pointer1] > nums2[pointer2])
                {
                    nums1[i] = nums1[pointer1--];
                }
                else
                {
                    nums1[i] = nums2[pointer2--];
                }
                i--;
            }
        }
    }
}
