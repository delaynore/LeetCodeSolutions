namespace LeetCodeSolutions.LinkedList;

internal class MiddleOfTheLinkedList_876
{

    //Definition for singly-linked list.
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
