namespace Arrays
{
    public static class MissingNumbers
    {
        /// <summary>
        /// Using the Formula n(n+1)/2.....[1...n].        
        /// </summary>
        /// Time Complexity: O(n)
        /// Space complexity: O(1)
        public static int MissingNumber(int[] nums)
        {
            int n = nums.Length;
            int total = n * (n + 1) / 2;

            for (int i = 0; i < n; i++)
            {
                total -= nums[i];
            }

            return total;
        }
    }
}
