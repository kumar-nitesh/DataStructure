namespace RotateArray
{
    public static class Optimized
    {
        /// <summary>
        /// Using a Dictionary: Time Complexity: O(n), Space complexity: O(n)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns>integer array of indices</returns>
        public static int[] Rotate(int[] nums, int k)
        {
            return nums;
        }

        public static int[] RotateWithExtraSpace(int[] nums, int k)
        {
            int arrLength = nums.Length;
            int[] arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                arr[k + i] = nums[i];
            }

            for (int index = 0; index < k; index++)
            {
                for (int counter = 0; counter < arrLength; counter++)
                {
                    int first = nums[counter];
                    nums[counter] = nums[arrLength - 1];
                    nums[arrLength - 1] = first;
                }
            }

            return nums;
        }
    }
}
