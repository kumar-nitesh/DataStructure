namespace LinkedList
{
    public partial class LinkedList
    {
        public Node Reverse(Node head)
        {
            Node current = head;
            Node prev = null;

            while (current != null)
            {
                Node temp = current.Next;
                current.Next = prev;
                prev = current;
                current = temp;
            }

            return prev;
        }
    }
}
