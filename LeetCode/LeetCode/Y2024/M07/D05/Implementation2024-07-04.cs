namespace LeetCode.Y2024.M07.D05
{
    /// <summary>
    /// Find the Minimum and Maximum Number of Nodes Between Critical Points
    /// </summary>
    public static class Implementation2024_07_05
    {
        public static int[] NodesBetweenCriticalPoints(ListNode head)
        {
            var curent = head.next;
            int prevValue = head.val;

            int i = 1;
            int? firstCriticalPoint = null;
            int? prevCriticalPoint = null;

            int minDistance = int.MaxValue;

            while (curent.next is not null)
            {
                bool isCritical = false;
                // check if min / max local
                if (curent.val > prevValue && curent.val > curent.next.val || curent.val < prevValue && curent.val < curent.next.val)
                {
                    if (firstCriticalPoint is null)
                    {
                        firstCriticalPoint = i;
                    }

                    if (prevCriticalPoint is not null && minDistance > i - prevCriticalPoint)
                    {
                        minDistance = i - (int)prevCriticalPoint;
                    }

                    isCritical = true;
                }

                if (isCritical)
                {
                    prevCriticalPoint = i;
                }

                prevValue = curent.val;
                curent = curent.next;

                i++;
            }

            if (firstCriticalPoint is null || firstCriticalPoint == prevCriticalPoint)
            {
                return [-1, -1];
            }

            return [minDistance, (int)prevCriticalPoint! - (int)firstCriticalPoint];
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
