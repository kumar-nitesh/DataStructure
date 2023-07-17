namespace DataStructures.Algorithms.LinkedList
{
    public partial class LinkedList
    {
        public Node Reverse(Node Head)
        {
            Node current = Head;
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

        /// <summary>
        /// Dont Reverse remaining elements.
        /// </summary>
        /// <param name="head"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public Node KReverse(Node head, int k)
        {
            Node begin;
            if (head == null || head.Next == null || k == 1)
                return head;

            Node dummyhead = new Node(-1);
            dummyhead.Next = head;

            begin = dummyhead;

            int i = 0;
            while (head != null)
            {
                i++;
                if (i % k == 0)
                {
                    begin = Reverse(begin, head.Next);
                    head = begin.Next;
                }
                else
                {
                    head = head.Next;
                }
            }

            return dummyhead.Next;
        }

        public Node Reverse(Node begin, Node end)
        {
            Node curr = begin.Next;
            Node temp, first;
            Node prev = begin;
            first = curr;

            while (curr != end)
            {
                temp = curr.Next;
                curr.Next = prev;
                prev = curr;
                curr = temp;
            }

            begin.Next = prev;
            first.Next = curr;
            return first;
        }

        /// <summary>
        /// Reverse all remaining elements.
        /// </summary>
        /// <param name="head"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public Node KReverseV2(Node head, int k)
        {
            Node begin;
            if (head == null || head.Next == null || k == 1)
                return head;

            Node dummyhead = new Node(-1);
            dummyhead.Next = head;

            begin = dummyhead;

            Node counterNode = dummyhead;

            // Calculating the length of linked list
            int count = 0;
            while (counterNode != null)
            {
                count++;
                counterNode = counterNode.Next;
            }

            int i = 0;
            while (head != null)
            {
                i++;
                if (i % k == 0 || head.Next == null)
                {
                    begin = Reverse(begin, head.Next);
                    head = begin.Next;
                }
                else
                {
                    head = head.Next;
                }
            }

            return dummyhead.Next;
        }
    }
}
