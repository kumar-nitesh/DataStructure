/********************************************************************************************
 * Binary Search
 * 
 * Source     : LeetCode
 * Difficulty : Easy
 * 
 * Time Complexity  : O(log₂N) // T(n) = n..n/2/..n/4...1 = log₂n     
 * Space complexity : O(1) 
 ********************************************************************************************/

namespace DataStructures.Algorithms.BinarySearch
{
    public class Search : IExecute
    {
        public void Execute()
        {
            Console.WriteLine("###LeetCode###");
            Console.WriteLine("704. Binary Search");
            Console.WriteLine("Difficulty Level - EASY");

            int[] nums = new int[] { -1, 0, 3, 5, 9, 12 };

            Console.WriteLine("The Binary Search index is : " + Algorithm(nums, 5));
        }

        /// <summary>
        /// Binary Search(Iterative) - Decrease and Conquer Algorithm
        /// </summary>
        public int Algorithm(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2; // To avoid overflow exception

                if (nums[mid] == target)
                {
                    return mid;
                }

                if (nums[mid] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return -1;
        }

    }
}
