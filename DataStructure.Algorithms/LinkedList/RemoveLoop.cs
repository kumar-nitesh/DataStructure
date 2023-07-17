namespace DataStructures.Algorithms.LinkedList
{
    public partial class LinkedList
    {
        /// <summary>
        /// Take two pointers – the first pointer pointing to the head of the linked list 
        /// and the second pointer pointing to the k'th node from the head. If we move both 
        /// pointers simultaneously, they will eventually meet at the loop starting node. 
        /// </summary>
        /// <param name="head"></param>
        /// Solution : https://www.prepbytes.com/blog/linked-list/detect-and-remove-the-loop-in-a-linked-list/
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        public void RemoveLoop(Node head)
        {
            if (head == null || head.Next == null) { return; }

            var slow = head;
            var fast = head;

            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;

                if (slow == fast)
                {
                    break;
                }
            }

            if (slow == fast)
            {
                slow = head;

                if (slow == fast)
                {
                    while (slow != fast.Next)
                    {
                        fast = fast.Next;
                    }

                    fast.Next = null;
                }
                else
                {
                    while (slow.Next != fast.Next)
                    {
                        slow = slow.Next;
                        fast = fast.Next;
                    }
                    fast.Next = null;
                }

            }
        }
    }
}