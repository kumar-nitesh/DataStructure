namespace DataStructures.Algorithms.BinaryTree
{
    public partial class BinaryTree
    {
        public int MaxLevel = 0;

        /// <summary>
        /// Right View of a Binary Tree.
        /// </summary>
        /// Time Complexity: O(n)
        /// Space Complexity: O(h)
        public void RightView(Node root)
        {
            RightViewHelper(root, 1);
        }

        private void RightViewHelper(Node root, int level)
        {
            if (root == null)
                return;

            if (maxLevel < level)
            {
                Console.WriteLine(root.Data + "\t");
                maxLevel = level;
            }

            RightViewHelper(root.Right, level + 1);
            RightViewHelper(root.Left, level + 1);
        }

        /// <summary>
        /// Right View Using Queue.
        /// </summary>
        /// Time Complexity: O(n)
        /// Space Complexity: O(n)
        public void RightViewUsingQueue(Node root)
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
}