namespace Arrays
{
    public static class RemoveDuplicates
    {
        /// <summary>
        /// Brute force: Time Complexity: O(n), Space complexity: O(1)
        /// </summary>
        public static int Remove(int[] nums)
        {
            int counter = 0;
            for (int index = 0; index < nums.Length; index++)
            {
                if (nums[index] != nums[counter])
                {
                    counter++;
                    nums[counter] = nums[index];
                }
            }

            return counter + 1;
        }
    }
}
