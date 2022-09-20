namespace BinaryTree
{
    public partial class BinaryTree
    {
        /// <summary>
        /// Level Order in a Binary Tree.
        /// </summary>
        /// Time Complexity: O(n * n)
        /// Space Complexity: O(h)
        public void LevelOrder(Node root)
        {
            int height = Height(root);
            for (int i = 1; i <= height; i++)
            {
                PrintLevel(root, i);
            }
        }

        private void PrintLevel(Node root, int level)
        {
            if (root == null)
                return;

            if (level == 1)
            {
                Console.WriteLine(root.Data + " ");
            }
            else if (level > 1)
            {
                PrintLevel(root.Left, level - 1);
                PrintLevel(root.Right, level - 1);
            }
        }

        /// <summary>
        /// Level Order in a Binary Tree - Using Queue.
        /// </summary>
        /// Time Complexity: O(n) where n is no. of nodes.
        /// Space Complexity: O(n) where n is no. of nodes.
        public void LevelOrderOptimized(Node root)
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                Node temp = queue.Dequeue();
                Console.WriteLine(temp.Data);

                if (temp.Left != null)
                {
                    queue.Enqueue(temp.Left);
                }

                if (temp.Right != null)
                {
                    queue.Enqueue(temp.Right);
                }
            }
        }

    }
}