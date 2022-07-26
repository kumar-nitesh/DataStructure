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

        /// <summary>
        /// Tortoise And Hare Approach
        /// </summary>
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
    }
}