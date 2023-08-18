namespace DataStructures.Algorithms.Sort
{
    internal class InsertionSort : IExecute
    {
        public void Execute()
        {
            // Input the Elements by user.
            Console.WriteLine("Welcome to Insertion Sort !!!");
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

            // Perform Bubble Sort.
            var sortedElements = Sort(inputElements, noOfElements);


            // Sorted Elements.
            Console.WriteLine("Elements after Sorting are as follows : ");

            for (int s = 0; s < sortedElements.Length; s++)
            {
                Console.Write(sortedElements[s] + "\t");
            }

            var sortedElements1 = MyInsertionSort(inputElements, noOfElements);

            // Sorted Elements.
            Console.WriteLine("Elements after Sorting are as follows : ");

            for (int s = 0; s < sortedElements1.Length; s++)
            {
                Console.Write(sortedElements1[s] + "\t");
            }

            Console.WriteLine();
            Console.ReadKey(true);
        }

        int[] Sort(int[] array, int size)
        {
            int temp, j;

            for (int i = 1; i < size; i++)
            {
                temp = array[i];
                j = i - 1;

                while (temp < array[j] && j >= 0)
                {
                    array[j + 1] = array[j];
                    --j;
                }

                array[j + 1] = temp;
            }

            return array;
        }

        int[] MyInsertionSort(int[] array, int size)
        {
            int temp;

            for (int i = 0; i < size - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    Console.WriteLine("Value of I : " + i);
                    temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;

                    for (int j = i; j > 0; j--)
                    {
                        if (array[j - 1] > array[j])
                        {
                            Console.WriteLine("Value of J : " + j);
                            temp = array[j - 1];
                            array[j - 1] = array[j];
                            array[j] = temp;
                        }
                    }
                }
            }

            return array;
        }
    }
}
