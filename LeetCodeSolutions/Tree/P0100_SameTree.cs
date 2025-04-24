namespace LeetCodeSolutions.Tree;

internal class P0100_SameTree
{
    public class Solution
    {
        public bool IsSameTreeRecursive(TreeNode p, TreeNode q)
        {
            if (p == null && q == null) return true;
            if (p == null || q == null) return false;

            if (p.val != q.val) return false;

            return IsSameTreeRecursive(p.right, q.right) && IsSameTreeRecursive(p.left, q.left);
        }

        public bool IsSymmetricIterative(TreeNode p, TreeNode q)
        {
            var stack = new Stack<(TreeNode? l, TreeNode? r)>();
            stack.Push((p, q));

            while (stack.Count > 0)
            {
                var (l, r) = stack.Pop();

                if (l == null && r == null) continue;

                if (l == null || r == null) return false;
                if (l.val != r.val) return false;

                if (l.left != null || r.left != null) stack.Push((l.left, r.left));
                if (l.right != null || r.right != null) stack.Push((l.right, r.right));
            }

            return true;
        }
    }
}
