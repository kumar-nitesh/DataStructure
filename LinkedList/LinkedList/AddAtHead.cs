namespace LinkedList
{
    public partial class LinkedList
    {
        /// <summary>
        /// Add at Head of the List. 
        /// </summary>
        /// Time Complexity: O(1) 
        public void AddAtHead(int val)
        {
            Node newHead = new Node(val);
            newHead.Next = Head;

            Head = newHead;
            Size++;
        }
    }
}
