namespace LinkedList
{
    public class LinkedList
    {
        public Node? Head;
        public int Size;

        public LinkedList()
        {
            this.Size = 0;
            this.Head = null;
        }

        public int Get(int index)
        {
            if (index < 0 || index > Size)
            {
                return -1;
            }

            Node node = Head;

            for (int i = 0; i < index; i++)
            {
                node = node.Next;
            }

            if (node == null)
            {
                return -1;
            }

            return node.Data;
        }

        public void AddAtHead(int val)
        {
            Node newHead = new Node(val);
            newHead.Next = Head;

            Head = newHead;
            Size++;
        }

        public void AddAtTail(int val)
        {
            Node node = new Node(val);

            if (Size == 0)
            {
                AddAtHead(val);
                return;
            }

            Node current = Head;

            while (current?.Next != null)
            {
                current = current.Next;
            }

            current.Next = node;
            Size++;
        }

        public void AddAtIndex(int index, int val)
        {
            Node node = new Node(val);

            if (index == 0)
            {
                AddAtHead(val);
                return;
            }

            if (index == Size)
            {
                AddAtTail(val);
                return;
            }

            if (index > Size)
            {
                return;
            }

            Node prev = Head;

            for (int i = 0; i < index - 1; i++)
            {
                prev = prev.Next;
            }

            node.Next = prev.Next;
            prev.Next = node;
            Size++;
        }

        public void DeleteAtIndex(int index)
        {
            if (index < 0 || index >= Size)
            {
                return;
            }

            Node current = Head;

            if (index == 0)
            {
                Head = current.Next;
                Size--;
            }
            else
            {
                Node prev = null;
                for (int i = 0; i < index; i++)
                {
                    prev = current;
                    current = current.Next;
                }

                prev.Next = current.Next;
                Size--;
            }
        }
    }
}
