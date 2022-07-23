using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
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

            // Perform Bubble Sort.
            var sortedElements = BubbleSort(inputElements, noOfElements);

            // Sorted Elements.
            Console.WriteLine("Elements after Sorting are as follows : ");

            for (int s = 0; s < sortedElements.Length; s++)
            {
                Console.Write(sortedElements[s] + "\t");
            }

            Console.WriteLine();
            Console.ReadKey(true);
        }

        static int[] BubbleSort(int[] array, int size)
        {
            int temp;
            bool isSwapped = true;

            for (int i = 0; i < size - 1 && isSwapped; i++)
            {
                isSwapped = false;
                //Console.WriteLine("Value of I : " + i);

                for (int j = 0; j < size - i - 1; j++) // size-i-1 => as the largest number bubble up to the right handside, 
                {                                      // hence reducing the iteration by 1 every time.
                    if (array[j] > array[j + 1])
                    {
                        //Console.WriteLine("Value of J : " + i);
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                        isSwapped = true;
                    }
                }
            }

            return array;
        }
    }
}
