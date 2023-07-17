namespace DataStructures.Algorithms.LinkedList
{
    public partial class LinkedList
    {
        /// <summary>
        /// https://www.prepbytes.com/blog/linked-list/check-if-linked-list-is-palindrome/
        /// </summary>
        /// Time Complexity: O(n) 
        /// Auxiliary Space: O(1)
        public bool IsPalindrome(Node head)
        {
            Node slow = head;
            Node fast = head;

            while (fast.Next != null && fast.Next.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            slow.Next = Reverse(slow.Next);
            slow = slow.Next;

            while (slow != null)
            {
                if (head.Data != slow.Data)
                {
                    return false;
                }

                head = head.Next;
                slow = slow.Next;
            }

            return true;
        }
    }
}
