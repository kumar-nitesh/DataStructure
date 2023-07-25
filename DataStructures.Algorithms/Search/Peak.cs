/********************************************************************************************
 * Peak Index in a Mountain Array
 * 
 * Source     : LeetCode
 * Difficulty : Medium
 * Problem    : https://leetcode.com/problems/peak-index-in-a-mountain-array/description/
 * Solution   : https://www.youtube.com/watch?v=zD2Jg3alZV8&t=2095s
 * 
 * Time Complexity  : O(log n)        
 * Space complexity : O(1) 
 ********************************************************************************************/

namespace DataStructures.Algorithms.Search
{
    public class Peak : IExecute
    {
        public void Execute()
        {
            Console.WriteLine("###LeetCode###");
            Console.WriteLine("852. Peak Index in a Mountain Array");
            Console.WriteLine("Difficulty Level - MEDIUM\n");

            Console.WriteLine("Using Binary Search\n");
            int[] arr = new int[] { 0, 1, 0 };

            Console.WriteLine("The Peak index is : " + PeakIndexInMountainArray(arr));
        }

        public int PeakIndexInMountainArray(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;
            int mid = 0;

            while (start < end)
            {
                mid = start + (end - start) / 2;
                if (arr[mid] < arr[mid + 1])
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid;
                }
            }

            return start;
        }
    }
}
