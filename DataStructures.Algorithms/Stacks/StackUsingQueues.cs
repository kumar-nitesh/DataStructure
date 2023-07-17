/********************************************************************************************
 * Queue using two Stacks.
 * 
 * Source     : Geeks for Geeks(Must Do)
 * Difficulty : Medium
 * Problem    : https://practice.geeksforgeeks.org/problems/stack-using-two-queues/1
 * Solution   : https://www.youtube.com/watch?v=mDcP7tLuBhc
 * 
 * Time Complexity  : O(n)        
 * Space complexity : O(n) 
 ********************************************************************************************/

namespace DataStructures.Algorithms.Stacks
{
    public class StackUsingQueues
    {
        Stack<int> s1 = new Stack<int>();
        Stack<int> s2 = new Stack<int>();

        /// <summary>
        /// O(1)
        /// </summary>
        /// <param name="x"></param>
        void Push(int x)
        {
            s1.Push(x);
        }

        /// <summary>
        /// O(N)
        /// </summary>
        /// <param name="x"></param>
        int Pop()
        {
            while (s1.Count > 0)
            {
                s2.Push(s1.Pop());
            }

            int ans = s2.Pop();

            while (s2.Count > 0)
            {
                s1.Push(s2.Pop());
            }

            return ans;
        }
    }
}
