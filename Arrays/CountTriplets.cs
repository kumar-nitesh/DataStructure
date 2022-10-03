namespace Arrays
{
    public class CountTriplets : IExecute
    {
        /// <summary>
        /// Brute force: Time Complexity: O(n^2), Space complexity: O(1)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns>integer array of indices</returns
        public static int[] Count(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return Array.Empty<int>();
        }

        public void Execute()
        {
            int[] test = new int[] { 3, 2, 4 };
            Console.WriteLine("[{0}]", string.Join(", ", Count(test, 6)));
        }
    }
}
