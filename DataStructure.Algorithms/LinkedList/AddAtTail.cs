namespace DataStructures.Algorithms.LinkedList
{
    public partial class LinkedList
    {
        /// <summary>
        /// Add at Tail of the List. 
        /// </summary>
        /// Time Complexity: O(N) 
        public void AddAtTail(int val)
        {
            Node node = new Node(val);

            if (Size == 0)
            {
                AddAtHead(val);
            }

            Node current = Head;

            while (current?.Next != null)
            {
                current = current.Next;
            }

            current.Next = node;
            Size++;
        }
    }
}
