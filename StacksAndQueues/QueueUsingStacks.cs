/********************************************************************************************
 * Queue using two Stacks.
 * 
 * Source     : Geeks for Geeks(Must Do)
 * Difficulty : Medium
 * Problem    : https://practice.geeksforgeeks.org/problems/queue-using-two-stacks/1 
 * Solution   : https://www.youtube.com/watch?v=mDcP7tLuBhc
 * 
 * Time Complexity  : O(n)        
 * Space complexity : O(n) 
 ********************************************************************************************/

namespace StacksAndQueues
{
    public class QueueUsingStacks
    {
        Queue<int> q1 = new Queue<int>();
        Queue<int> q2 = new Queue<int>();

        /// <summary>
        /// O(1)
        /// </summary>
        /// <param name="x"></param>
        void Push(int x)
        {
            q1.Enqueue(x);
        }

        /// <summary>
        /// O(N)
        /// </summary>
        /// <param name="x"></param>
        int Pop()
        {
            while (q1.Count > 0)
            {
                q2.Enqueue(q1.Dequeue());
            }

            int ans = q1.Dequeue();

            while (q2.Count > 0)
            {
                q1.Enqueue(q2.Dequeue());
            }

            return ans;
        }
    }
}
