namespace LeetCode.Y2024.M07.D10
{
    /// <summary>
    /// Crawler Log Folder
    /// </summary>
    public static class Implementation2024_07_10
    {
        private const string stepback = "../";

        public static int MinOperations(string[] logs)
        {
            int curentDepth = 0;

            foreach (var log in logs)
            {
                if (log == stepback)
                {
                    curentDepth--;

                    if (curentDepth < 0)
                        curentDepth = 0;
                }
                if (log[0] != '.')
                {
                    curentDepth++;
                }
            }

            return curentDepth;
        }

    }
}
