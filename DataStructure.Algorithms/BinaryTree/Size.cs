namespace DataStructures.Algorithms.BinaryTree
{
    public partial class BinaryTree
    {
        /// <summary>
        /// No. of Nodes in a Binary Tree.
        /// </summary>
        public int Size(Node root)
        {
            if (root == null)
                return 0;

            int leftNodes = Size(root.Left);
            int rightNodes = Size(root.Right);
            int size = leftNodes + rightNodes + 1;
            return size;
        }
    }
}