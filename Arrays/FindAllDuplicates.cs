namespace Arrays
{
    public static class FindAllDuplicates
    {
        /// <summary>
        /// Greedy Approach - Set the nums[n] to its negative value.  
        /// Modifies the Input Array (Mutable Array).
        /// </summary>
        /// Time Complexity: O(n)
        /// Space complexity: O(1)
        public static IList<int> Find(int[] nums)
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

        /// <summary>
        /// The input array can be used as a HashMap. While Traversing the array, 
        /// if an element ‘a’ is encountered then increase the value of a%n‘th element by n. 
        /// The frequency can be retrieved by dividing the a % n’th element by n.
        /// </summary>
        /// Time Complexity: O(n)
        /// Space complexity: O(1)
        public static IList<int> Optimized(int[] nums)
        {
            List<int> result = new List<int>();
            int n = nums.Length;

            for (int i = 0; i < n; i++)
            {
                int number = Math.Abs(nums[i]) - 1;

                if (nums[number] < 0)
                {
                    result.Add(number + 1);
                }

                nums[number] = nums[number] * -1;
            }

            return result;
        }
    }
}
