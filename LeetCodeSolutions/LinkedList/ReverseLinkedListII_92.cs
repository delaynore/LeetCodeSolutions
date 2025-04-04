namespace LeetCodeSolutions.LinkedList;

internal class ReverseLinkedListII_92
{
    public class Solution
    {
        public ListNode ReverseBetween(ListNode head, int left, int right)
        {
            left--;
            right--;

            var current = head;
            var count = 0;
            while (count < left - 1)
            {
                current = current.next;
            }
            var prev = current;
            current = current.next;

            while (count < right)
            {
                var tmp = current.next;
                current.next = prev;
                prev = current;
                current = tmp;
                count++;
            }

            return head;
        }
    }
}
