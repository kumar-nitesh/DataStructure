namespace CountTriplets
{
    public static class BruteForce
    {
        /// <summary>
        /// Brute force: Time Complexity: O(n^2), Space complexity: O(1)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns>integer array of indices</returns
        public static int[] CountTriplets(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return Array.Empty<int>();
        }
    }
}
