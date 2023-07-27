/********************************************************************************************
 * Maximum Running Time of N Computers
 * 
 * Source     : LeetCode
 * Difficulty : Hard
 * Problem    : https://leetcode.com/problems/maximum-running-time-of-n-computers/
 * Solution   : https://www.youtube.com/watch?v=TKKkVa5cL2g
 * 
 * Time Complexity  : O(n log n)      
 * Space complexity : O(1) 
 ********************************************************************************************/

namespace DataStructures.Algorithms.BinarySearch
{
    public class MaxRunTime : IExecute
    {
        public void Execute()
        {
            Console.WriteLine("###LeetCode###");
            Console.WriteLine("2141. Maximum Running Time of N Computers\n");
            Console.WriteLine("Difficulty Level - HARD\n");

            Console.WriteLine("Using Binary Search\n");
            int[] batteries = new int[] { 10, 10, 3, 5 };
            int noOfComputers = 3;

            Console.WriteLine("The Peak index is : " + UsingBinarySearch(batteries, noOfComputers));
        }

        public long UsingBinarySearch(int[] batteries, int noOfComputers)
        {
            long left = 1;
            long sumDuration = 0;
            for (int i = 0; i < batteries.Length; i++)
            {
                sumDuration += batteries[i];
            }

            long right = sumDuration / noOfComputers;
            long mid = 0;
            long maxRunTime = 0;
            while (left <= right)
            {
                mid = left + (right - left) / 2;

                // Move to the left half.
                if (IsPossible(batteries, noOfComputers, mid))
                {
                    maxRunTime = mid;
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return maxRunTime;
        }

        private bool IsPossible(int[] batteries, int n, long mid)
        {
            long totalDuration = 0;
            for (int i = 0; i < batteries.Length; i++)
            {
                if (batteries[i] < mid)
                {
                    totalDuration += batteries[i];
                }
                else
                {
                    totalDuration += mid;
                }
            }

            return totalDuration / n >= mid;
        }

    }
}
