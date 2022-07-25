namespace LinkedList
{
    public partial class LinkedList
    {
        /// <summary>
        /// Using the difference in node counts
        /// </summary>
        /// Time Complexity: O(m+n) 
        /// Auxiliary Space: O(1)
        public int GetIntersectionNode(LinkedList listA, LinkedList listB)
        {
            Node nodeA = listA.Head;
            Node nodeB = listB.Head;

            int diff = Math.Abs(listA.Size - listB.Size);

            if (listA.Size > listB.Size)
            {
                for (int i = 0; i < diff; i++)
                {
                    nodeA = nodeA.Next;
                }
            }
            else
            {
                nodeB = nodeB.Next;
            }

            while (nodeA != nodeB)
            {
                nodeA = nodeA.Next;
                nodeB = nodeB.Next;
            }

            return nodeA.Data;
        }
    }
}
