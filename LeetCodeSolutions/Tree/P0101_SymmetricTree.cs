namespace LeetCodeSolutions.Tree;

internal class P0101_SymmetricTree
{
    public class Solution
    {
        public bool IsSymmetricRecursive(TreeNode root)
        {
            return Inner(root.left, root.right);

            bool Inner(TreeNode? first, TreeNode? second)
            {
                if (first == null && second == null) return true;
                if (first == null || second == null) return false;

                if (first.val != second.val) return false;

                return Inner(first.right, second.left) && Inner(first.left, second.right);
            }
        }

        public bool IsSymmetricIterative(TreeNode root)
        {
            var stack = new Stack<(TreeNode? l, TreeNode? r)>();
            stack.Push((root.left, root.right));

            while (stack.Count > 0)
            {
                var (l, r) = stack.Pop();

                if (l == null && r == null) continue;

                if (l == null || r == null) return false;
                if (l.val != r.val) return false;

                if (l.right != null || r.left != null) stack.Push((l.right, r.left));
                if (l.left != null || r.right != null) stack.Push((l.left, r.right));
            }

            return true;
        }
    }
}
