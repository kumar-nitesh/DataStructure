namespace ThreeWayPartition
{
    public static class BruteForce
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
    }
}
