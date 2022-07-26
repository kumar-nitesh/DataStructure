namespace LinkedList
{
    public partial class LinkedList
    {
        /// <summary>
        /// Add at Index of the List. 
        /// </summary>
        /// Time Complexity: O(1) 
        public void AddAtIndex(int index, int val)
        {
            Node newNode = new Node(val);

            if (Size == 0)
            {
                AddAtHead(val);
                return;
            }

            if (Size == index)
            {
                AddAtTail(val);
                return;
            }

            if (index > Size)
            {
                return;
            }

            Node current = Head;

            for (int i = 0; i < index - 1; i++)
            {
                current = current.Next;
            }

            newNode.Next = current?.Next;
            current.Next = newNode;
            Size++;
        }
    }
}