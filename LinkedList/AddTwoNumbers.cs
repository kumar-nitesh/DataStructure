/********************************************************************************************
 * Add two numbers represented by linked lists.
 * 
 * Source     : Geeks for Geeks(Must Do)
 * Difficulty : Easy
 * Problem    : https://practice.geeksforgeeks.org/problems/add-two-numbers-represented-by-linked-lists/1
 * Solution   : https://www.youtube.com/watch?v=HiRlTPf9aCg
 *            
 * Time Complexity  : O(max(m,n))        
 * Space complexity : O(1) 
 ********************************************************************************************/


namespace LinkedList
{
    public partial class LinkedList
    {
        /// <summary>
        /// Find Digit : digit = Sum % 10
        /// Find Carry : carry = Sum / 10
        /// 1. Reverse
        /// 2. Find Sum, Digit and Carry
        /// 3. Add at Head to avoid Reverse
        /// Time Complexity  : O(max(m,n))     
        /// Space complexity : O(1)
        /// </summary>
        public Node AddTwoNumbers(Node first, Node second)
        {
            first = Reverse(first);
            second = Reverse(second);

            int carry = 0;
            Node head = null;

            while (first != null || second != null || carry == 1)
            {
                int value = 0;
                int digit = 0;

                if (first != null)
                {
                    value += first.Data;
                    first = first.Next;
                }

                if (second != null)
                {
                    value += second.Data;
                    second = second.Next;
                }

                value += carry;

                digit = value % 10;
                carry = value / 10;

                // Add at Head to avoid Reverse
                Node newNode = new Node(digit);
                newNode.Next = head;

                head = newNode;
            }

            return head;
        }
    }
}
