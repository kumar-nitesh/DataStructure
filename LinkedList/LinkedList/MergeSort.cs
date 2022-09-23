namespace LinkedList
{
    public partial class LinkedList
    {
        public Node MergeSort(Node head)
        {
            if (head == null || head.Next == null)
            {
                return head;
            }

            Node middle = FindMiddle(head);
            Node nextOfMiddle = middle.Next;

            middle.Next = null;

            Node left = MergeSort(head);
            Node right = MergeSort(nextOfMiddle);

            Node sortedList = MergeTwoSortedListRecursion(left, right);

            return sortedList;
        }

        public Node FindMiddle(Node head)
        {
            Node slow = head;
            Node fast = head.Next;

            while (fast != null && fast.Next != null)
            {
                fast = fast.Next.Next;
                slow = slow.Next;
            }
            return slow;
        }

        public Node FindMiddleV2(Node head)
        {
            Node slow = head;
            Node fast = head.Next;

            int i = 0;

            while (fast != null && fast.Next != null)
            {
                i++;
                fast = fast.Next.Next;
                slow = slow.Next;
            }

            if (fast != null)
            {
                return slow.Next;
            }

            return slow;
        }

        /// <summary>
        /// Tortoise And Hare Approach
        /// </summary>
        public Node FindMiddleAlgorithm(Node head)
        {
            Node slow = head;
            Node fast = head;

            while (fast != null && fast.Next != null)
            {
                fast = fast.Next.Next;
                slow = slow.Next;
            }

            return slow;
        }
    }
}