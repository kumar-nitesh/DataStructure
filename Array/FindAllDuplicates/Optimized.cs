namespace FindAllDuplicates
{
    public static class Optimized
    {
        /// <summary>
        /// The input array can be used as a HashMap. While Traversing the array, 
        /// if an element ‘a’ is encountered then increase the value of a%n‘th element by n. 
        /// The frequency can be retrieved by dividing the a % n’th element by n.
        /// </summary>
        /// Time Complexity: O(n)
        /// Space complexity: O(1)
        public static IList<int> FindDuplicates(int[] nums)
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