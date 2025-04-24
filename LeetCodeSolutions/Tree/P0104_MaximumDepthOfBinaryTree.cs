namespace LeetCodeSolutions.Tree;

internal class P0104_MaximumDepthOfBinaryTree
{
    public class Solution
    {
        public int MaxDepthIterative(TreeNode root)
        {
            if (root == null) return 0;
            var max = 0;

            var stack = new Stack<(TreeNode Node, int Depth)>();
            stack.Push((root, 1));

            while (stack.Count > 0)
            {
                var (node, depth) = stack.Pop();

                max = Math.Max(depth, max);

                if (node.left != null) stack.Push((node.left, depth + 1));
                if (node.right != null) stack.Push((node.right, depth + 1));
            }

            return max;
        }

        public int MaxDepthRecursive(TreeNode root)
        {
            if (root is null) return 0;

            return Math.Max(MaxDepthRecursive(root.left), MaxDepthRecursive(root.right)) + 1;
        }
    }
}
