﻿namespace Arrays
{
    public static class ContainsDuplicate
    {
        /// <summary>
        /// Brute force: Time Complexity: O(n), Space complexity: Extra Space Required.
        /// </summary>
        public static bool Duplicate(int[] nums)
        {
            bool isDuplicate = false;
            HashSet<int> hash = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (hash.Contains(nums[i]))
                {
                    isDuplicate = true;
                    break;
                }

                hash.Add(nums[i]);
            }

            return isDuplicate;
        }
    }
}