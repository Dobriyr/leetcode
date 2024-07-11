using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LeetCode.Y2024.M07.D11
{
    /// <summary>
    /// Reverse Substrings Between Each Pair of Parentheses
    /// </summary>
    public static class Implementation2024_07_11
    {
        public static string ReverseParentheses(string s)
        {
            var arr = s.ToCharArray();

            Stack<int> positions = new Stack<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == '(')
                {
                    positions.Push(i);
                }
                else if (arr[i] == ')')
                {
                    int j = positions.Pop();
                    Reverce(arr, j, i);

                }
            }

            StringBuilder result = new StringBuilder();
            foreach (var a in arr)
            {
                if (a != '(' && a != ')')
                {
                    result.Append(a);
                }
            }

            return result.ToString();
        }

        private static void Reverce(char[] array, int start, int end)
        {

            char cup;

            while (start < end)
            {
                cup = array[start];
                array[start] = array[end];
                array[end] = cup;
                start++;
                end--;
            }
       }
    }
}
