namespace LeetCodeSolutions.LinkedList;

internal class P0206_ReverseLinkedList
{
    public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            var current = head;
            ListNode? prev = null;
            while (current != null)
            {
                var tmp = current.next;
                current.next = prev!;
                prev = current;
                current = tmp;
            }

            return prev!;
        }
    }
}
