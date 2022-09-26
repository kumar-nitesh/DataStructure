using System;

namespace HoarePartition
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input the Elements by user.
            Console.WriteLine("Welcome to Lomuto Partition !!!");
            Console.WriteLine("How many elements you want to Partition?");

            int noOfElements = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the elements...");

            int[] inputElements = new int[noOfElements];

            for (int elementIndex = 0; elementIndex < noOfElements; elementIndex++)
            {
                inputElements[elementIndex] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Elements before Partition are as follows : ");

            for (int p = 0; p < noOfElements; p++)
            {
                Console.Write(inputElements[p] + "\t");
            }

            Console.WriteLine();

            // Perform Merge Sort.
            HoarePartition(inputElements, 0, noOfElements - 1);

            // Sorted Elements.
            Console.WriteLine("Elements after Sorting are as follows : ");

            for (int s = 0; s < inputElements.Length; s++)
            {
                Console.Write(inputElements[s] + "\t");
            }

            Console.WriteLine();
            Console.ReadKey(true);
        }

        private static void HoarePartition(int[] inputElements, int low, int high)
        {
            int pivot = inputElements[low];
            int i = low, j = high;
            while (true)
            {
                while (inputElements[i] < pivot)
                {
                    i++;
                }

                while (inputElements[j] >= pivot)
                {
                    j--;
                }

                if (i >= j)
                {
                    //return j;
                }

                Swap(inputElements, i, j);
            }
        }

        private static void Swap(int[] nums, int i, int j)
        {
            int temp = nums[j];
            nums[j] = nums[i];
            nums[i] = temp;
        }
    }
}
