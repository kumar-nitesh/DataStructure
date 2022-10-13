namespace LinkedList
{
    public partial class LinkedList
    {
        /// <summary>
        /// Delete At Index of the List. 
        /// </summary>
        /// Time Complexity: O(1) 
        public void DeleteNode(Node del)
        {
            Node temp = del.Next;
            del.Data = temp.Data;
            del.Next = temp.Next;
        }
    }
}