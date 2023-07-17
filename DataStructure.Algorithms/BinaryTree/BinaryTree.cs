namespace DataStructures.Algorithms.BinaryTree
{
    public partial class BinaryTree
    {
        public Node Root;

        public BinaryTree()
        {
            Root = null;
        }

        public BinaryTree(int data)
        {
            this.Root = new Node(data);
        }
    }
}
