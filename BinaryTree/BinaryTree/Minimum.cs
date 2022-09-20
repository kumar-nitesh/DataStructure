namespace BinaryTree
{
    public partial class BinaryTree
    {
        /// <summary>
        /// Minimum in a Binary Tree.
        /// </summary>
        public int Min(Node root)
        {
            if (root == null)
                return int.MaxValue;

            int leftMax = Min(root.Left);
            int rightMax = Min(root.Right);

            int max = Math.Min(Math.Min(leftMax, rightMax), root.Data);
            return max;
        }
    }
}