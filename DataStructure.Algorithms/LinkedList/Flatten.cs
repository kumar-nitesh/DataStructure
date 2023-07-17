/********************************************************************************************
 * Flattening a Linked List.
 * 
 * Source     : Geeks for Geeks(Must Do)
 * Difficulty : Medium
 * Problem    : https://practice.geeksforgeeks.org/problems/flattening-a-linked-list/1
 *              https://www.geeksforgeeks.org/flatten-a-linked-list-with-next-and-child-pointers/
 * Solution   : https://iq.opengenus.org/flattening-a-linked-list/
 *              https://www.youtube.com/watch?v=kvCYxPKpPGg (Multi-Level)
 *              https://www.prepbytes.com/blog/linked-list/flatten-a-multi-level-linked-list-depth-wise/
 *            
 * Time Complexity  : O(n)        
 * Space complexity : O(1) 
 ********************************************************************************************/


namespace DataStructures.Algorithms.LinkedList
{
    public partial class LinkedList
    {
        /// <summary>
        /// Time Complexity  : O(n * m)     
        /// Space complexity : O(1)
        /// </summary>
        /* 5 -> 10 -> 19 -> 28
        *  |    |     |     |
        *  7    20    22    35
        *  |          |     |
        *  8          50    40
        *  |                |
        *  30               45
        */
        /// <param name="head"></param>
        /// <returns></returns>
        public Node Flatten(Node head)
        {
            if (head == null || head.Next == null)
            {
                return head;
            }

            head.Next = Flatten(head.Next);
            head = Merge(head, head.Next);

            return head;
        }

        /// <summary>
        /// Time Complexity  : O(n)      
        /// Space complexity : O(1)
        /// </summary>
        /// <param name="head"></param>
        public void MultilevelFlatten(Node head)
        {
            if (head == null)
            {
                return;
            }

            Node tail = head;

            while (tail.Next != null)
            {
                tail = tail.Next;
            }

            Node curr = head;
            Node temp = null;

            while (curr != tail)
            {
                if (curr.down != null)
                {
                    tail.Next = curr.down;

                    temp = curr.down;

                    while (temp.Next != null)
                    {
                        temp = temp.Next;
                    }

                    tail = temp;
                }

                curr = curr.Next;
            }
        }

        private Node Merge(Node head, Node next)
        {
            if (head == null)
                return next;

            if (next == null)
                return head;

            Node result;

            if (head.Data < next.Data)
            {
                result = head;
                result.down = Merge(head.down, next);
            }
            else
            {
                result = next;
                result.down = Merge(head, next.down);
            }

            return result;
        }
    }
}