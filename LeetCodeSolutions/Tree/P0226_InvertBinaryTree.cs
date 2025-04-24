namespace LeetCodeSolutions.Tree;

internal class P0226_InvertBinaryTree
{
    public class Solution
    {
        public TreeNode InvertTreeIterative(TreeNode root)
        {
            if (root is null) return root!;

            var stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                var pop = stack.Pop();

                (pop.left, pop.right) = (pop.right, pop.left);

                if (pop.left is { }) stack.Push(pop.left);
                if (pop.right is { }) stack.Push(pop.right);
            }

            return root;
        }

        public TreeNode InvertTreeRecursive(TreeNode root)
        {
            if (root is null) return root!;

            (root.left, root.right) = (root.right, root.left);

            InvertTreeRecursive(root.left);
            InvertTreeRecursive(root.right);

            return root;
        }
    }
}
