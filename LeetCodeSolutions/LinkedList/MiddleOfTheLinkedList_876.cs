namespace LeetCodeSolutions.LinkedList;

internal class MiddleOfTheLinkedList_876
{
    public class Solution
    {
        public ListNode MiddleNode(ListNode head)
        {
            var middle = head;
            var end = head;
            var count = 0;
            while (end != null)
            {
                end = end.next;
                count++;
                if (count % 2 == 0)
                    middle = middle.next;
            }

            return middle;
        }
    }

    public class Solution2
    {
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
