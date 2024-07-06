namespace LeetCode.Y2024.M06.D06
{
    /// <summary>
    /// Pass the Pillow
    /// </summary>
    public static class Implementation2024_07_06
    {
        public static int PassThePillow(int n, int time)
        {
            int passCount = time / (n - 1);
            return passCount % 2 == 0 ? (time % (n - 1) + 1) : (n - time % (n - 1));
        }
    }
}