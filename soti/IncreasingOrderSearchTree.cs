using System;
namespace data
{
    public class IncreasingOrderSearchTree
    {
        public IncreasingOrderSearchTree()
        {
            TreeNode node =
                new TreeNode(5, new TreeNode(3, new TreeNode(2, new TreeNode(1)), new TreeNode(4)), new TreeNode(6, null, new TreeNode(8, new TreeNode(7), new TreeNode(8))));

            GetNodes(node);
        }

        private void GetNodes(TreeNode node)
        {

        }
    }
}
