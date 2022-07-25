namespace LinkedList
{
    public partial class LinkedList
    {
        public Node Reverse(Node head)
        {
            Node nextElement = null;
            Node prev = null;
            Node current = head;

            while (current != null)
            {
                nextElement = current.Next;
                current.Next = prev;
                prev = current;
                current = nextElement;
            }

            head = prev;

            return head;
        }
    }
}
