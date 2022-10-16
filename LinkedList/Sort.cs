/********************************************************************************************
 * Given a linked list of 0s, 1s and 2s, sort it.
 * 
 * Source     : Geeks for Geeks(Must Do)
 * Difficulty : Easy
 * Problem    : https://practice.geeksforgeeks.org/problems/given-a-linked-list-of-0s-1s-and-2s-sort-it/1
 * Solution   : https://www.youtube.com/watch?v=ogmBt6f9hw8 
 *              https://www.prepbytes.com/blog/linked-list/sort-a-linked-list-of-0s-1s-and-2s-by-changing-links/
 * Time Complexity  : O(n)        
 * Space complexity : O(1)
 ********************************************************************************************/

namespace LinkedList
{
    public partial class LinkedList
    {
        /// <summary>
        /// Approach 1 : Replaces data
        /// Time Complexity  : O(n) 
        /// Space complexity : O(1)
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public Node Sort(Node head)
        {
            int zeroCount = 0;
            int oneCount = 0;
            int twoCount = 0;
            Node curr = head;

            while (curr != null)
            {
                if (curr.Data == 0)
                {
                    zeroCount++;
                }
                else if (curr.Data == 1)
                {
                    oneCount++;
                }
                else
                {
                    twoCount++;
                }

                curr = curr.Next;
            }

            curr = head;

            while (curr != null)
            {
                if (zeroCount > 0)
                {
                    curr.Data = 0;
                    zeroCount--;
                }
                else if (oneCount > 0)
                {
                    curr.Data = 1;
                    oneCount--;
                }
                else
                {
                    curr.Data = 2;
                    twoCount--;
                }

                curr = curr.Next;
            }

            return head;
        }

        /// <summary>
        /// Approach 2 : Change links
        /// 1. Create 3 dummy nodes.
        /// 2. Insert at Tail
        /// 3. Merge all 3 nodes.
        /// 4. Set Head.
        /// 5. Delete dummy nodes.
        /// Time Complexity  : O(n) 
        /// Space complexity : O(1)
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public Node SortInPlace(Node head)
        {
            Node zeroHead = new Node(-1);
            Node oneHead = new Node(-1);
            Node twoHead = new Node(-1);

            Node zero = zeroHead;
            Node one = oneHead;
            Node two = twoHead;

            Node curr = head;

            while (curr != null)
            {
                if (curr.Data == 0)
                {
                    zero.Next = curr;
                    zero = zero.Next;
                }
                else if (curr.Data == 1)
                {
                    one.Next = curr;
                    one = one.Next;
                }
                else
                {
                    two.Next = curr;
                    two = two.Next;
                }

                curr = curr.Next;
            }

            // Merge the Nodes
            if (oneHead.Next != null)
            {
                zero.Next = oneHead.Next;
            }
            else
            {
                zero.Next = twoHead.Next;
            }

            one.Next = twoHead.Next;
            two.Next = null;

            // Set the Head
            head = zeroHead.Next;

            return head;
        }
    }
}