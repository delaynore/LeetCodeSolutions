namespace LeetCodeSolutions.LinkedList;

internal class ReverseLinkedListII_92
{
    public class Solution
    {
        public ListNode ReverseBetween(ListNode head, int left, int right)
        {
            if (left == right) return head;

            var current = head;
            var counter = 1;

            ListNode? prev = null;
            ListNode? second = null;
            ListNode? first = null;
            while (counter <= right)
            {
                if (counter == left - 1)
                {
                    first = current;
                }

                if (counter < left)
                {
                    current = current.next;
                    counter++;
                    continue;
                }

                if (counter == left)
                {
                    second = current;
                }

                var tmp = current.next;
                current.next = prev!;
                prev = current;
                current = tmp;
                counter++;
            }

            if (first != null)
            {
                first.next = prev!;
            }
            second!.next = current;

            return first == null ? prev! : head!;
        }
    }
}
