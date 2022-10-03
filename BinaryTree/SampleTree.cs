namespace BinaryTree
{
    public static class SampleTree
    {
        public static void Traversal()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(5);

            Console.WriteLine("Preorder traversal ");
            tree.PreOrder(tree.Root);

            Console.WriteLine("\nInorder traversal ");
            tree.InOrder(tree.Root);

            Console.WriteLine("\nPostorder traversal ");
            tree.PostOrder(tree.Root);
        }

        public static int Height()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(5);

            return tree.Height(tree.Root);
        }

        public static int Size()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(5);

            return tree.Size(tree.Root);
        }

        public static int Minimum()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(5);

            return tree.Min(tree.Root);
        }

        public static int Maximum()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(5);

            return tree.Max(tree.Root);
        }

        public static void LevelOrder()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(5);

            tree.LevelOrder(tree.Root);
            Console.WriteLine("Optimized Level Order of the Binary Tree : ");
            tree.LevelOrderOptimized(tree.Root);
        }

        public static void LeftView()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(5);
            tree.LeftView(tree.Root);
            Console.WriteLine("Left View Using Queue of a Binary Tree");
            tree.LeftViewUsingQueue(tree.Root);
        }

        public static void RightView()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(5);
            tree.RightView(tree.Root);
            Console.WriteLine("Right View Using Queue of a Binary Tree");
            tree.RightViewUsingQueue(tree.Root);
        }

        public static void TopView()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(4);
            tree.Root.Right.Left = new Node(5);
            tree.Root.Right.Right = new Node(6);
            tree.Root.Left.Left.Right = new Node(7);
            tree.Root.Right.Left.Right = new Node(8);
            tree.Root.Right.Right.Right = new Node(9);
            tree.Root.Right.Left.Right.Left = new Node(10);

            tree.TopView(tree.Root);

            Console.WriteLine("Optimized Level Order of the Binary Tree : ");
        }

        public static void BottomView()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(4);
            tree.Root.Right.Left = new Node(5);
            tree.Root.Right.Right = new Node(6);
            tree.Root.Left.Left.Right = new Node(7);
            tree.Root.Right.Left.Right = new Node(8);
            tree.Root.Right.Right.Right = new Node(9);
            tree.Root.Right.Left.Right.Left = new Node(10);

            tree.BottomView(tree.Root);

            Console.WriteLine("Optimized Level Order of the Binary Tree : ");
        }
    }
}
