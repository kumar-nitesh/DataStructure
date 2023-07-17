namespace DataStructures.Algorithms.LinkedList
{
    public partial class LinkedList
    {
        /// <summary>
        /// Delete At Index of the List. 
        /// </summary>
        /// Time Complexity: O(1) 
        public void DeleteAtIndex(int index)
        {
            if (index < 0 || index >= Size)
            {
                return;
            }

            Node current = Head;
            Node prev = null;

            if (index == 0)
            {
                Head = current.Next;
                Size--;
            }
            else
            {

                for (int i = 0; i < index; i++)
                {
                    prev = current;
                    current = current.Next;
                }

                prev.Next = current?.Next;
                Size--;
            }
        }
    }
}