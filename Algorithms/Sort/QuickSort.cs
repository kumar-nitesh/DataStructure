﻿using Algorithms;

namespace Sort
{
    public class QuickSort : IExecute
    {
        static void Sort(int[] array, int start, int end)
        {
            // Base Condition
            if (start >= end)
                return;

            // rearrange the elements across pivot.
            //int pivot = Partition(array, start, end);
            int pivot = LomutoPartition(array, start, end);

            // recurse on sub array containing elements that are less than pivot.
            Sort(array, start, (pivot - 1));

            // recurse on sub array containing elements that are more than pivot.
            Sort(array, (pivot + 1), end);
        }

        /// <summary>
        /// Hoare Partition
        /// Pivot Element - First 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        static int Partition(int[] array, int start, int end)
        {
            int pivot = array[start];
            int i = start, j = end;
            while (true)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] >= pivot)
                {
                    j--;
                }

                if (i >= j)
                {
                    return j;
                }

                Swap(array, i, j);

                return i;
            }
        }

        /// <summary>
        /// Lomuto Partition
        /// Pivot Element - Last 
        /// </summary>
        /// <param name="inputElements"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        private static int LomutoPartition(int[] inputElements, int low, int high)
        {
            int pivot = inputElements[high];
            int i = low;
            for (int j = low; j < high; j++)
            {
                if (inputElements[j] <= pivot)
                {
                    Swap(inputElements, i, j);
                    i++;
                }
            }

            Swap(inputElements, i, high);

            return i;
        }

        private static void Swap(int[] nums, int i, int j)
        {
            int temp = nums[j];
            nums[j] = nums[i];
            nums[i] = temp;
        }

        public void Execute()
        {
            // Input the Elements by user.
            Console.WriteLine("Welcome to Quick Sort !!!");
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

            // Perform Quick Sort.
            Sort(inputElements, 0, noOfElements - 1);

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


