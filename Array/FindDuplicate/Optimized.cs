namespace FindDuplicate
{
    public static class Optimized
    {
        /// <summary>
        /// Tortoise & Hare (Floyd's Cycle Detection) Algorithm.  
        /// Doesn't modify the Input Array (Immutable Array).
        /// </summary>
        /// Time Complexity: O(n)
        /// Space complexity: O(1)
        public static int FindDuplicate(int[] nums)
        {
            int slow = nums[0];
            int fast = nums[0];

            do
            {
                slow = nums[slow];
                fast = nums[nums[fast]];

            } while (slow != fast);

            fast = nums[0];

            while (slow != fast)
            {
                slow = nums[slow];
                fast = nums[fast];
            }

            return fast;
        }
    }
}
