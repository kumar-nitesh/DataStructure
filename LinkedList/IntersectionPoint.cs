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
                for (int i = 0; i < diff; i++)
                {
                    nodeB = nodeB.Next;
                }
            }

            while (nodeA != nodeB)
            {
                if (nodeA.Data == nodeB.Data)
                {
                    return nodeA.Data;
                }
                nodeA = nodeA.Next;
                nodeB = nodeB.Next;
            }

            return -1;
        }
    }
}
