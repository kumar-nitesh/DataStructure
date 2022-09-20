namespace BinaryTree
{
    public partial class BinaryTree
    {
        /// <summary>
        /// Preorder (Root Left Right)
        /// </summary>
        /// T(n) = T(k) + T(n – k – 1) + c
        /// Where k is the number of nodes on one side of the root 
        /// and n-k-1 on the other side
        /// Time Complexity: O(n) 
        public void PreOrder(Node root)
        {
            if (root == null)
                return;

            Console.WriteLine(root.Data);
            PreOrder(root.Left);
            PreOrder(root.Right);
        }

        /// <summary>
        /// Inorder (Left Root Right)
        /// </summary>
        /// T(n) = T(k) + T(n – k – 1) + c
        /// Where k is the number of nodes on one side of the root 
        /// and n-k-1 on the other side
        /// Time Complexity: O(n) 
        public void InOrder(Node root)
        {
            if (root == null)
                return;

            InOrder(root.Left);
            Console.WriteLine(root.Data);
            InOrder(root.Right);
        }

        /// <summary>
        /// Postorder (Left Right Root) 
        /// </summary>
        /// T(n) = T(k) + T(n – k – 1) + c
        /// Where k is the number of nodes on one side of the root 
        /// and n-k-1 on the other side
        /// Time Complexity: O(n) 
        public void PostOrder(Node root)
        {
            if (root == null)
                return;

            PostOrder(root.Left);
            PostOrder(root.Right);
            Console.WriteLine(root.Data);
        }
    }
}
