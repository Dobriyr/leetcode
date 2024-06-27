namespace LeetCode.Y2024.M06.D27
{
    /// <summary>
    /// Find Center of Star Graph
    /// </summary>
    public static class Implementation2024_06_27
    {
        public static int FindCenter(int[][] edges)
        {
            var firstEdge = edges[0];
            var secondEdge = edges[1];

            return firstEdge[0] == secondEdge[0] ? firstEdge[0] : firstEdge[1];
        }
    }
}
