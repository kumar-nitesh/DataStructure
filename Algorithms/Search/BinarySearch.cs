namespace Algorithms.Search
{
    public class BinarySearch : IExecute
    {
        /// <summary>
        /// Binary Search(Iterative) - Decrease and Conquer Algorithm
        /// T(n) = n..n/2/..n/4...1 = log₂n
        /// </summary>
        /// Time Complexity: O(log₂N)
        /// Auxiliary Space: O(1)

        public static int Search(int[] nums, int target)
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

        public void Execute()
        {
            Console.WriteLine("###LeetCode###");
            Console.WriteLine("704. Binary Search");
            Console.WriteLine("Difficulty Level - EASY");

            int[] sample1 = new int[] { -1, 0, 3, 5, 9, 12 };
            Console.WriteLine(Search(sample1, 9));
        }
    }
}
