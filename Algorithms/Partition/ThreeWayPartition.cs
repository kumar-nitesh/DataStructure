namespace Algorithms.Partition
{
    public class ThreeWayPartition : IExecute
    {
        /// Time Complexity: O(n)
        /// Space complexity: O(1)
        public static int[] Partition(int[] array, int low, int high)
        {
            int start = 0;
            int end = array.Length - 1;

            for (int i = 0; i <= end; i++)
            {
                if (array[i] < low)
                {
                    Swap(array, start, i);
                    start++;
                }
                else if (array[i] > high)
                {
                    Swap(array, end, i);
                    end--;
                    --i;
                }
            }

            return array;
        }

        private static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        public void Execute()
        {
            int[] arr = { 2, 5, 87, 56, 12, 4, 9, 23, 76, 1, 45 };

            var result1 = Partition(arr, 15, 30);
            Console.WriteLine("[{0}]", string.Join(", ", result1));

            int[] array = { 2, 2, 2, 0, 0, 0, 1, 1 };
            var result2 = Partition(array, 1, 1);
            Console.WriteLine("[{0}]", string.Join(", ", result2));
        }
    }
}
