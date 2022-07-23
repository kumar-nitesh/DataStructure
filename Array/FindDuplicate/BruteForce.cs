namespace FindDuplicate
{
    public static class BruteForce
    {
        /// <summary>
        /// Greedy Approach - Set the nums[n] to its negative value.  
        /// Modifies the Input Array (Mutable Array).
        /// </summary>
        /// Time Complexity: O(n)
        /// Space complexity: O(1)
        public static int FindDuplicate(int[] nums)
        {
            int n = nums.Length;
            int result = 0;
            for (int i = 0; i < n; i++)
            {
                int number = Math.Abs(nums[i]);

                if (nums[number] < 0)
                {
                    result = number;
                    break;
                }

                nums[number] = nums[number] * -1;
            }

            return result;
        }
    }
}
