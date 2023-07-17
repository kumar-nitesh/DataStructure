namespace DataStructures.Algorithms.Arrays
{
    public class MissingNumbers : IExecute
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

        public void Execute()
        {
            int[] test1 = new int[] { 3, 0, 1 };
            int[] test2 = new int[] { 0, 1 };
            int[] test3 = new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 };

            Console.WriteLine("[{0}]", string.Join(", ", MissingNumber(test1)));
            Console.WriteLine("[{0}]", string.Join(", ", MissingNumber(test2)));
            Console.WriteLine("[{0}]", string.Join(", ", MissingNumber(test3)));
        }
    }
}
