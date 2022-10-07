using Algorithms;

namespace Sort
{
    public class MergeSort : IExecute
    {
        static void MergeSortDivide(int[] array, int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;

                //sort the left and right array.
                MergeSortDivide(array, left, mid);
                MergeSortDivide(array, (mid + 1), right);

                //merge the result.
                MergeSortConquer(array, left, (mid + 1), right);
            }
        }

        static void MergeSortConquer(int[] array, int leftArrayBegin, int rightArrayBegin, int rightArrayEnd)
        {
            int resultArrayBegin = 0;
            int leftArrayEnd = (rightArrayBegin - 1);
            int numOfElements = (rightArrayEnd - leftArrayBegin + 1);

            int[] resultArray = new int[numOfElements];

            // Find the smallest element in both these array and add it to the result
            // array i.e you may have a array of the form [1,5] [2,4]
            // We need to sort the above as [1,2,4,5]
            while ((leftArrayBegin <= leftArrayEnd) && (rightArrayBegin <= rightArrayEnd))
            {
                if (array[leftArrayBegin] <= array[rightArrayBegin])
                    resultArray[resultArrayBegin++] = array[leftArrayBegin++];
                else
                    resultArray[resultArrayBegin++] = array[rightArrayBegin++];
            }

            // After the main loop completed we may have few more elements in
            // left array copy them.
            while (leftArrayBegin <= leftArrayEnd)
                resultArray[resultArrayBegin++] = array[leftArrayBegin++];

            // After the main loop completed we may have few more elements in
            // right array copy.
            while (rightArrayBegin <= rightArrayEnd)
                resultArray[resultArrayBegin++] = array[rightArrayBegin++];

            // Copy resultArray back to the main array.
            for (int i = numOfElements - 1; i >= 0; i--, rightArrayEnd--)
            {
                array[rightArrayEnd] = resultArray[i];
            }
        }

        public void Execute()
        {
            // Input the Elements by user.
            Console.WriteLine("Welcome to Bubble Sort !!!");
            Console.WriteLine("How many elements you want to sort?");

            int noOfElements = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the elements...");

            int[] inputElements = new int[noOfElements];

            for (int elementIndex = 0; elementIndex < noOfElements; elementIndex++)
            {
                inputElements[elementIndex] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Elements before Sorting are as follows : ");

            for (int p = 0; p < noOfElements; p++)
            {
                Console.Write(inputElements[p] + "\t");
            }

            Console.WriteLine();

            // Perform Merge Sort.
            MergeSortDivide(inputElements, 0, noOfElements - 1);

            // Sorted Elements.
            Console.WriteLine("Elements after Sorting are as follows : ");

            for (int s = 0; s < inputElements.Length; s++)
            {
                Console.Write(inputElements[s] + "\t");
            }

            Console.WriteLine();
            Console.ReadKey(true);
        }
    }
}
