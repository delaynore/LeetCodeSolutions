namespace LeetCodeSolutions.LinkedList;

internal class P0024_SwapNodesInPairs
{
    public class Solution
    {
        public ListNode SwapPairs(ListNode head)
        {
            var dummy = new ListNode(0, head);

            var current = dummy;
            while (current?.next?.next != null)
            {
                var first = current.next;
                var second = current.next.next;

                first.next = second.next;
                second.next = first;
                current.next = second;

                current = first;
            }

            return dummy.next;
        }
    }
}
