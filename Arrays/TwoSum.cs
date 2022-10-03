namespace Arrays
{
    public static class TwoSum
    {
        /// <summary>
        /// Brute force: Time Complexity: O(n^2), Space complexity: O(1)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns>integer array of indices</returns
        public static int[] Sum(int[] nums, int target)
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

        /// <summary>
        /// Using a Dictionary: Time Complexity: O(n), Space complexity: O(n)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns>integer array of indices</returns>
        public static int[] Optimized(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int firstNumber = nums[i];
                int secondNumber = target - firstNumber;
                if (map.TryGetValue(secondNumber, out int index))
                {
                    return new int[] { index, i };
                }

                map[firstNumber] = i;
            }

            return Array.Empty<int>();
        }
    }
}
