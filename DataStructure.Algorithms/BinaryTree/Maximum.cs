namespace DataStructures.Algorithms.BinaryTree
{
    public partial class BinaryTree
    {
        /// <summary>
        /// Maximum in a Binary Tree.
        /// </summary>
        /// Time Complexity: O(n)
        /// Space Complexity: O(h)
        public int Max(Node root)
        {
            if (root == null)
                return int.MinValue;

            int leftMax = Max(root.Left);
            int rightMax = Max(root.Right);

            int max = Math.Max(Math.Max(leftMax, rightMax), root.Data);
            return max;
        }
    }
}