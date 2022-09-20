namespace BinaryTree
{
    public partial class BinaryTree
    {
        /// <summary>
        /// Depth of the deepest node.
        /// </summary>
        public int Height(Node root)
        {
            if (root == null)
                return 0;

            int leftHeight = Height(root.Left);
            int rightHeight = Height(root.Right);
            int height = Math.Max(leftHeight, rightHeight) + 1;
            return height;
        }
    }
}