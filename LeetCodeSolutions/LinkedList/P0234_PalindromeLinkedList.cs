namespace LeetCodeSolutions.LinkedList;

internal class P0234_PalindromeLinkedList
{
    public class Solution
    {
        public bool IsPalindrome(ListNode head)
        {
            var middle = MiddleNode(head);
            var second = ReverseList(middle);
            var first = head;

            while (first != null && second != null)
            {
                if (first.val != second.val) return false;
                first = first.next;
                second = second.next;
            }
            return true;
        }

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

        public ListNode MiddleNode(ListNode head)
        {
            var middle = head;
            var end = head;
            while (end?.next != null)
            {
                end = end.next?.next;
                middle = middle.next;
            }

            return middle;
        }
    }
}
