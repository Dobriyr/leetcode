namespace LeetCode.Y2024.M07.D04
{
    /// <summary>
    /// Merge Nodes in Between Zeros
    /// </summary>
    public static class Implementation2024_07_04
    {
        public static ListNode MergeNodes(ListNode head)
        {
            var listNode = new ListNode();
            var newHead = listNode;

            head = head.next;

            while (head is not null)
            {
                if (head.val == 0 && head.next is not null)
                {
                    listNode.next = new ListNode();
                    listNode = listNode.next;
                }

                listNode.val += head.val;
                head = head.next;
            }
            
            return newHead;
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
