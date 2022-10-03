namespace LinkedList
{
    public partial class LinkedList
    {
        /// <summary>
        /// Floyd’s Cycle-Finding Algorithm 
        /// Here we will use two pointers slow and fast 
        /// where slow will travel one step and fast two step
        /// if they become same at some time there is cycle
        /// if fast is null then there is no cycle
        /// </summary>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        public bool RemoveLoop(Node head)
        {
            if (head == null)
            {
                return false;
            }

            var slow = head;
            var fast = head;

            while (slow != null && fast != null && fast?.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;

                if (slow == fast)
                {
                    return true;
                }
            }

            return false;
        }
    }
}