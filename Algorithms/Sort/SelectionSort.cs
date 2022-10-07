using Algorithms;

namespace Sort
{
    public class SelectionSort : IExecute
    {
        static int[] Sort(int[] array, int size)
        {
            int index, temp;

            for (int i = 0; i < size - 1; i++)
            {
                index = i;

                for (int j = i + 1; j < size; j++)
                {
                    if (array[index] > array[j])
                    {
                        index = j;
                    }
                }

                if (index != i)
                {
                    temp = array[i];
                    array[i] = array[index];
                    array[index] = temp;
                }
            }

            return array;
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

            // Perform Selection Sort.
            var sortedElements = Sort(inputElements, noOfElements);

            // Sorted Elements.
            Console.WriteLine("Elements after Sorting are as follows : ");

            for (int s = 0; s < sortedElements.Length; s++)
            {
                Console.Write(sortedElements[s] + "\t");
            }

            Console.WriteLine();
            Console.ReadKey(true);
        }
    }
}
