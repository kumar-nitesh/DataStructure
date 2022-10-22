/********************************************************************************************
 * Maximum of all subarrays of size k.
 * 
 * Source     : Geeks for Geeks(Must Do)
 * Difficulty : Medium
 * Problem    : https://practice.geeksforgeeks.org/problems/maximum-of-all-subarrays-of-size-k3101/1 
 * Solution   : https://www.callicoder.com/sliding-window-maximum/
 *              https://www.youtube.com/watch?v=xFJXtB5vSmM
 * 
 * Time Complexity  : O(n)        
 * Space complexity : O(k) 
 ********************************************************************************************/

namespace Algorithms.SlidingWindow
{
    public class MaximumSubarrays : IExecute
    {
        /// <summary>
        /// 1. Keep only useful elements in the Queue.
        /// 2. Maximum element will always be on Top of the Queue.
        /// </summary>
        int[] MaximumSlidingWindow(int[] arr, int k)
        {
            List<int> queue = new List<int>();
            int n = arr.Length;
            int[] result = new int[n - k + 1];

            for (int i = 0; i < n; i++)
            {
                while (queue.Count > 0 && i - k == queue.First())
                {
                    queue.RemoveAt(0);
                }

                while (queue.Count > 0 && arr[i] > arr[queue.Last()])
                {
                    queue.RemoveAt(queue.Count - 1);
                }

                queue.Add(i);

                if (i >= k - 1)
                {
                    result[i - k + 1] = arr[queue.First()];
                }
            }

            return result;
        }

        public void Execute()
        {
            int[] arr = { 1, 3, -1, -3, 5, 3, 6, 7 };
            int k = 3;
            var result = MaximumSlidingWindow(arr, k);
            Console.WriteLine("[{0}]", string.Join(", ", result));
        }
    }
}
