namespace DataStructures.Algorithms.Arrays
{
    public class RemoveDuplicates : IExecute
    {
        /// <summary>
        /// Brute force: Time Complexity: O(n), Space complexity: O(1)
        /// </summary>
        public static int Remove(int[] nums)
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

        public void Execute()
        {
            int[] sample1Remove = new int[] { 1, 1, 2 };
            Console.WriteLine(Remove(sample1Remove));

            int[] sample2Remove = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            Console.WriteLine(Remove(sample2Remove));
        }
    }
}
