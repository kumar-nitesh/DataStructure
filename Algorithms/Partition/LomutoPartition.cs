using Algorithms;

namespace LomutoPartition
{
    class LomutoPartition : IExecute
    {
        private static void Partition(int[] inputElements, int low, int high)
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
            Partition(inputElements, 0, noOfElements - 1);

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
