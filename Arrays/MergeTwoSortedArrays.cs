namespace Arrays
{
    public static class MergeTwoSortedArrays
    {
        /// Time Complexity  : O(n1 + n2)
        /// Space Complexity : O(n1 + n2)
        public static int[] Merge(int[] array1, int[] array2)
        {
            int[] result = new int[array1.Length + array2.Length];

            int array1Counter = 0;
            int array2Counter = 0;
            int resultCounter = 0;

            while (array1Counter < array1.Length && array2Counter <= array2.Length)
            {
                if (array1[array1Counter] < array2[array2Counter])
                {
                    result[resultCounter] = array1[array1Counter];
                    array1Counter++;
                    resultCounter++;
                }
                else
                {
                    result[resultCounter] = array2[array2Counter];
                    array2Counter++;
                    resultCounter++;
                }
            }

            while (array1Counter < array1.Length)
            {
                result[resultCounter] = array1[array1Counter];
                array1Counter++;
                resultCounter++;
            }

            while (array2Counter < array2.Length)
            {
                result[resultCounter] = array2[array2Counter];
                array2Counter++;
                resultCounter++;
            }

            return result;
        }
    }
}
