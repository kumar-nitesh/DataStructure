namespace BinarySearch
{
    public static class BruteForce
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
    }
}
