namespace DataStructures.Algorithms.LinkedList
{
    public partial class LinkedList
    {
        /// <summary>
        /// Stack : Push() - Add At Head of LinkedList.
        /// </summary>
        /// Time Complexity: O(1) 
        /// Auxiliary Space: O(1)
        public void Push(int data)
        {
            Node newHead = new Node(data);

            if (Size == 0)
            {
                Head = newHead;
            }
            else
            {
                newHead.Next = Head;
                Head = newHead;
                Size++;
            }
        }

        public void Pop()
        {
            if (Size == 0)
                return;
            else
            {
                Head = Head.Next;
                Size--;
            }
        }

        public int Top()
        {
            return Head.Data;
        }
    }
}
