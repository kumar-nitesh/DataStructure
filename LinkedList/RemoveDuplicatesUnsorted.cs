namespace LinkedList
{
    public partial class LinkedList
    {
        /// <summary>
        /// Using the difference in node counts
        /// </summary>
        /// Time Complexity: O(n * n) 
        /// Auxiliary Space: O(1)
        public Node RemoveDuplicatesUnsorted(LinkedList list)
        {
            Node current = list.Head;

            while (current != null)
            {
                Node next = current;

                while (next.Next != null)
                {
                    if (current.Data == next.Next.Data)
                    {
                        next.Next = next.Next.Next;
                    }
                    else
                    {
                        next = next.Next;
                    }
                }

                current = current.Next;
            }

            return list.Head;
        }
    }
}
