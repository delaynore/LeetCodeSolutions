namespace LeetCodeSolutions.LinkedList;

internal class P2095_DeleteTheMiddleNodeOfALinkedList
{
    //Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null!)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        public ListNode DeleteMiddle(ListNode head)
        {
            if (head.next == null) return null!;

            var middle = head;
            var end = head.next?.next;
            while (end?.next != null)
            {
                end = end.next?.next;
                middle = middle.next;
            }

            middle.next = middle.next.next;

            return head;
        }
    }
}
