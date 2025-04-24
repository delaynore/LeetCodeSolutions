namespace LeetCodeSolutions.Tree;

internal class P0111_MinimumDepthOfBinaryTree
{
    public class Solution
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null) return 0;

            var q = new Queue<(TreeNode Node, int Depth)>();
            q.Enqueue((root, 1));

            while (q.Count > 0)
            {
                var (Node, Depth) = q.Dequeue();

                if (Node.left == null && Node.right == null)
                    return Depth;

                if (Node.left != null)
                    q.Enqueue((Node.left, Depth + 1));
                if (Node.right != null)
                    q.Enqueue((Node.right, Depth + 1));
            }

            return 0;
        }
    }
}
