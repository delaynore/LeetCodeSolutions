namespace LeetCodeSolutions.LinkedList;

internal class P0019_RemoveNthNodeFromEndOfList
{
    public class Solution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            head = new ListNode(0, head);
            var p1 = head;
            var p2 = head;

            while (n > 0)
            {
                p1 = p1.next;
                n--;
            }

            while (p1?.next != null)
            {
                p1 = p1.next;
                p2 = p2.next;
            }

            p2.next = p2.next.next;

            return head.next;
        }
    }
}
