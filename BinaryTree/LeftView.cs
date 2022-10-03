namespace BinaryTree
{
    public partial class BinaryTree
    {
        public int maxLevel = 0;

        /// <summary>
        /// Left View of a Binary Tree.
        /// Do level order traversal and print the first node in every level.
        /// </summary>
        /// Time Complexity: O(n)
        /// Space Complexity: O(n)
        public void LeftView(Node root)
        {
            LeftViewHelper(root, 1);
        }

        private void LeftViewHelper(Node root, int level)
        {
            if (root == null)
                return;

            if (maxLevel < level)
            {
                Console.WriteLine(root.Data + "\t");
                maxLevel = level;
            }

            LeftViewHelper(root.Left, level + 1);
            LeftViewHelper(root.Right, level + 1);
        }

        /// <summary>
        /// Left View Using Queue.
        /// </summary>
        /// Time Complexity: O(n)
        /// Space Complexity: O(n)
        public void LeftViewUsingQueue(Node root)
        {
            if (root == null)
                return;

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int n = queue.Count;

                for (int i = 1; i <= n; i++)
                {
                    Node temp = queue.Dequeue();

                    if (i == n)
                    {
                        Console.WriteLine(temp.Data + "\t");
                    }

                    if (temp.Right != null)
                    {
                        queue.Enqueue(temp.Right);
                    }

                    if (temp.Left != null)
                    {
                        queue.Enqueue(temp.Left);
                    }
                }
            }
        }
    }
}