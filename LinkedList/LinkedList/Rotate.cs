namespace LinkedList
{
    public partial class LinkedList
    {
        /// <summary>
        /// 1. Make a Circle - Connect tail to head
        /// 2. Iterate till kth element
        /// 3. NewHead = Kth Element Next
        /// 4. Assign Kth Element Next = Null
        /// </summary>
        /// <param name="head"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public Node LeftShift(Node head, int k)
        {
            Node curr = head;
            int i = 0;

            while (curr.Next != null)
            {
                curr = curr.Next;
                i++;
            }

            curr.Next = head;

            for (int j = 0; j < k; j++)
            {
                curr = curr.Next;
            }
            Node newHead = curr.Next;
            curr.Next = null;

            return newHead;
        }

        public Node RightShift(Node head, int k)
        {
            Node curr = head;
            int size = 1;

            while (curr.Next != null)
            {
                curr = curr.Next;
                size++;
            }

            curr.Next = head;

            int counter = 0;
            k = k % size;
            counter = size - k;

            for (int j = 0; j < counter; j++)
            {
                curr = curr.Next;
            }

            Node newHead = curr.Next;
            curr.Next = null;

            return newHead;
        }

    }
}