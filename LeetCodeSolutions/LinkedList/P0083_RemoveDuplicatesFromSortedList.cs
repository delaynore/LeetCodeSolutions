namespace LeetCodeSolutions.LinkedList;

internal class P0083_RemoveDuplicatesFromSortedList
{
    public class Solution
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            var current = head;
            while (current?.next != null)
            {
                if (current.next.val == current.val)
                {
                    current.next = current.next.next;
                }
                else
                {
                    current = current.next;
                }
            }
            return head;
        }
    }
}
