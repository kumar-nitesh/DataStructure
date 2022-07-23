namespace CountTriplets
{
    public static class Optimized
    {
        /// <summary>
        /// Using a Dictionary: Time Complexity: O(n), Space complexity: O(n)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns>integer array of indices</returns>
        public static int[] CountTriplets(int[] nums, int target)
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
