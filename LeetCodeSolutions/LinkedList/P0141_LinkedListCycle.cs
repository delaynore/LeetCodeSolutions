namespace LeetCodeSolutions.LinkedList;

internal class P0141_LinkedListCycle
{
    public class Solution
    {
        public bool HasCycle(ListNode head)
        {
            var slow = head;
            var fast = head;

            while (fast?.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;

                if (slow == fast)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
