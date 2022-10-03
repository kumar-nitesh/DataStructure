namespace Arrays
{
    public class RotateArray : IExecute
    {
        /// <summary>
        /// Brute force: Time Complexity: O(n * k), Space complexity: O(1)
        /// </summary>
        /// First Iteration - Swap First & Last Index
        ///-----------------------------------------------
        ///1.7234561 => i = 0
        ///2.7134562 => i = 1
        ///3.7124563 => i = 2
        ///4.7123564 => i = 3
        ///5.7123465 => i = 4
        ///6.7123456 => i = 5
        ///-----------------------------------------------
        public static int[] Rotate(int[] nums, int k)
        {
            int arrLength = nums.Length;

            for (int index = 0; index < k; index++)
            {
                for (int counter = 0; counter < arrLength; counter++)
                {
                    int first = nums[counter];
                    nums[counter] = nums[arrLength - 1];
                    nums[arrLength - 1] = first;
                }
            }

            return nums;
        }

        public static int[] RotateWithExtraSpace(int[] nums, int k)
        {
            int arrLength = nums.Length;
            int[] arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                arr[k + i] = nums[i];
            }

            for (int index = 0; index < k; index++)
            {
                for (int counter = 0; counter < arrLength; counter++)
                {
                    int first = nums[counter];
                    nums[counter] = nums[arrLength - 1];
                    nums[arrLength - 1] = first;
                }
            }

            return nums;
        }

        public void Execute()
        {
            int[] s1 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("[{0}]", string.Join(", ", Rotate(s1, 3)));

            int[] s2 = new int[] { -1, -100, 3, 99 };
            Console.WriteLine("[{0}]", string.Join(", ", Rotate(s2, 2)));

            int[] s3 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("[{0}]", string.Join(", ", RotateWithExtraSpace(s3, 3)));

            int[] s4 = new int[] { -1, -100, 3, 99 };
            Console.WriteLine("[{0}]", string.Join(", ", RotateWithExtraSpace(s4, 2)));
        }
    }
}
