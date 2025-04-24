namespace LeetCodeSolutions.Tree;

internal class P0112_PathSum
{
    public class Solution
    {
        public bool HasPathSumRecursive(TreeNode root, int targetSum)
        {
            if (root == null) return false;
            if (root.left == null && root.right == null && targetSum == root.val)
                return true;

            return HasPathSumRecursive(root.left!, targetSum - root.val)
                || HasPathSumRecursive(root.right!, targetSum - root.val);
        }

        public bool HasPathSumIterative(TreeNode root, int targetSum)
        {
            if (root == null) return false;

            var stack = new Stack<(TreeNode Node, int TargetSum)>();
            stack.Push((root, targetSum));

            while (stack.Count > 0)
            {
                var (node, targetSumCurrent) = stack.Pop();

                if (node.left == null
                    && node.right == null
                    && targetSumCurrent == node.val)
                {
                    return true;
                }

                if (node.left != null) stack.Push((node.left, targetSumCurrent - node.val));
                if (node.right != null) stack.Push((node.right, targetSumCurrent - node.val));
            }

            return false;
        }
    }
}
