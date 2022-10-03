namespace Arrays
{
    public class ContainsDuplicate : IExecute
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

        public void Execute()
        {
            int[] sample1Duplicate = new int[] { 1, 2, 3, 1 };
            Console.WriteLine(Duplicate(sample1Duplicate));

            int[] sample2Duplicate = new int[] { 1, 2, 3, 4 };
            Console.WriteLine(Duplicate(sample2Duplicate));

            int[] sample3Duplicate = new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            Console.WriteLine(Duplicate(sample3Duplicate));

            int[] sample4Duplicate = new int[] { 3, 3 };
            Console.WriteLine(Duplicate(sample4Duplicate));
        }
    }
}
