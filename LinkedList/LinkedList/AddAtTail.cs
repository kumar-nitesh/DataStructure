namespace LinkedList
{
    public partial class LinkedList
    {
        public void AddAtTail(int val)
        {
            Node node = new Node(val);

            if (Size == 0)
            {
                AddAtHead(val);
            }

            Node current = Head;

            while (current?.Next != null)
            {
                current = current.Next;
            }

            current.Next = node;
            Size++;
        }
    }
}
