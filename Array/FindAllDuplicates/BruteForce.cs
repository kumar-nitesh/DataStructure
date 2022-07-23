namespace FindAllDuplicates
{
    public static class BruteForce
    {
        /// <summary>
        /// Greedy Approach - Set the nums[n] to its negative value.  
        /// Modifies the Input Array (Mutable Array).
        /// </summary>
        /// Time Complexity: O(n)
        /// Space complexity: O(1)
        public static IList<int> FindDuplicates(int[] nums)
        {
            List<int> result = new List<int>();
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                nums[nums[i] % n] = nums[nums[i] % n] + n;
            }

            for (int i = 0; i < n; i++)
            {
                if (nums[i] > n * 2)
                {
                    result.Add(i);
                }
            }

            return result;
        }
    }
}
