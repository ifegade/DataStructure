using System;
namespace soti
{
    public class MaxDepthOfBinaryTree
    {
        int answer;
        public MaxDepthOfBinaryTree()
        {
        }

        public int MaxDepth(TreeNode root)
        {
            int depth = 1;
            Depth(root, depth);
            return answer;
        }

        void Depth(TreeNode root, int depth)
        {
            if (root == null)
                return;
            if (root.left == null && root.right == null)
            {
                answer = Math.Max(depth, answer);
            }
            Depth(root.left, depth + 1);
            Depth(root.right, depth + 1);
        }
    }
}
