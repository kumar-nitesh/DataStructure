namespace DataStructures.Algorithms.Arrays
{
    public class MergeTwoSortedArrays : IExecute
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

        public void Execute()
        {
            int[] array1 = new int[] { 1, 2, 3, };
            int[] array2 = new int[] { 4, 5, 6 };
            Console.WriteLine("[{0}]", string.Join(", ", Merge(array1, array2)));

            int[] array3 = new int[] { 1, 2, 3, };
            int[] array4 = new int[] { 4, 5, 6, 7, 8 };
            Console.WriteLine("[{0}]", string.Join(", ", Merge(array3, array4)));

            int[] array5 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] array6 = new int[] { 10, 11, 12, 13, 14, 15 };
            Console.WriteLine("[{0}]", string.Join(", ", Merge(array5, array6)));

            int[] array7 = new int[] { 1, 2, 3, 4 };
            int[] array8 = new int[] { 3, 4, 5, 6 };
            Console.WriteLine("[{0}]", string.Join(", ", Merge(array7, array8)));
        }
    }
}
