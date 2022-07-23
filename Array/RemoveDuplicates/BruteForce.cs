using System;
using System.Collections.Generic;
namespace RemoveDuplicates
{
    public static class BruteForce
    {
        /// <summary>
        /// Brute force: Time Complexity: O(n), Space complexity: O(1)
        /// </summary>
        public static int RemoveDuplicates(int[] nums)
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
