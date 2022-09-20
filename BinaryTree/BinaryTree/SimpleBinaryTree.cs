namespace BinaryTree
{
    public static class SimpleBinaryTree
    {
        public static void Create(BinaryTree binaryTree)
        {
            // Create Root
            //    1
            //   / \
            //null null
            binaryTree.Root = new Node(1);

            // Create Left
            //     1
            //    / \
            //   2   null
            //  / \
            // n   n
            // n--> null
            binaryTree.Root.Left = new Node(2);


            // Create Right
            //     1
            //    / \
            //   2   3
            //  / \  / \
            // n   n n   n
            binaryTree.Root.Right = new Node(3);

            // Create Right
            //      1
            //     / \
            //    2   3
            //   / \  / \
            //  4   n n   n
            // / \
            // n  n
            binaryTree.Root.Left.Left = new Node(4);
        }
    }
}
