namespace DutchNationFlag
{
    public static class BruteForce
    {
        /// Time Complexity: O(n)
        /// Space complexity: O(1)
        public static int[] Sort(int[] array)
        {
            int low = 0;
            int high = array.Length - 1;

            for (int mid = 0; mid <= high; mid++)
            {
                if (array[mid] == 0)
                {
                    Swap(array, low, mid);
                    low++;
                }

                if (array[mid] == 2)
                {
                    Swap(array, mid, high);
                    --high;
                    --mid;
                }
            }

            return array;
        }
        private static void Swap(int[] array, int x, int y)
        {
            int temp = array[x];
            array[x] = array[y];
            array[y] = temp;
        }
    }
}
