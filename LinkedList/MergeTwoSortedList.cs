/********************************************************************************************
 * Merge two sorted linked lists.
 * 
 * Source     : Geeks for Geeks(Must Do)
 * Difficulty : Medium
 * Problem    : https://practice.geeksforgeeks.org/problems/merge-two-sorted-linked-lists/1
 * Solution   : https://www.youtube.com/watch?v=6vFEuO1pfJA
 * Time Complexity  : O(n + m)        
 * Space complexity : O(1) 
 ********************************************************************************************/

namespace LinkedList
{
    public partial class LinkedList
    {
        /// <summary>
        /// Using Dummy Nodes
        /// Time and space complexities: O(n+m), 
        /// where n and m are the sizes of the two input linked lists.
        /// </summary>
        public Node MergeTwoSortedList(Node list1, Node list2)
        {
            // Validations
            if (list1 == null)
                return list2;

            if (list2 == null)
                return list1;

            LinkedList linkedList = new LinkedList();
            Node currentNode = linkedList.Head;

            while (list1 != null && list2 != null)
            {
                if (list1.Data >= list2.Data)
                {
                    currentNode.Next = list2;
                    list2 = list2.Next;
                }
                else
                {
                    currentNode.Next = list1;
                    list1 = list1.Next;
                }

                currentNode = currentNode.Next;
            }

            // Simply add the 'leftover' from the while loop at the end 
            if (list1 != null)
                currentNode.Next = list1;

            if (list2 != null)
                currentNode.Next = list2;

            return linkedList.Head.Next;
        }

        /// <summary>
        /// Using Recursion
        /// Time and space complexities: O(n+m), 
        /// where n and m are the sizes of the two input linked lists.
        /// </summary>
        public Node MergeTwoSortedListRecursion(Node list1, Node list2)
        {
            if (list1 == null && list2 == null)
            {
                return null;
            }

            if (list1 != null && list2 == null)
            {
                return list1;
            }

            if (list1 == null && list2 != null)
            {
                return list2;
            }

            if (list1.Data > list2.Data)
            {
                list2.Next = MergeTwoSortedListRecursion(list1, list2.Next);
                return list2;
            }
            else
            {
                list1.Next = MergeTwoSortedListRecursion(list1.Next, list2);
                return list1;
            }
        }
    }
}

