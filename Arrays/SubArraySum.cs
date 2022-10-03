namespace Arrays
{
    public class SubArraySum : IExecute
    {
        /// <summary>
        /// Time Complexity: O(n^2) in worst case. 
        /// Space Complexity: O(1). 
        /// </summary>
        public static void Sum(int[] arr, int s)
        {
            int sum = 0;
            int arrayLength = arr.Length;
            int initialPosition = 0;
            int finalPosition = 0;

            for (int i = 0; i < arrayLength; i++)
            {
                sum = arr[i];
                initialPosition = i;

                for (int j = i + 1; j <= arrayLength; j++)
                {
                    if (sum == s)
                    {
                        finalPosition = j - 1;
                        Console.WriteLine("Initial Position : " + initialPosition + " & Final Position : " + finalPosition);
                        return;
                    }

                    if (sum > s || j == arrayLength)
                        break;

                    sum = sum + arr[j];
                }
            }
        }

        /// <summary>
        /// Time Complexity: O(n). 
        /// Space Complexity: O(1). 
        /// </summary>
        public static void SumOptimized(int[] arr, int s)
        {
            int sum = 0;
            int arrayLength = arr.Length;
            int initialPosition = 0;
            int finalPosition = 0;

            for (int i = 0; i < arrayLength; i++)
            {
                while (sum > s && initialPosition < i - 1)
                {
                    sum = sum - arr[initialPosition];
                    initialPosition++;
                }

                if (sum == s)
                {
                    finalPosition = i - 1;
                    Console.WriteLine("Initial Position : " + initialPosition + " & Final Position : " + finalPosition);
                }

                if (i < arrayLength)
                {
                    sum += arr[i];
                }

            }
        }

        public void Execute()
        {
            Console.WriteLine("***************************Brute Force***************************");

            int[] sample1Sum = new int[] { 1, 2, 3, 7, 5 };
            Sum(sample1Sum, 12);

            int[] sample2Sum = new int[] { 15, 2, 4, 8, 9, 5, 10, 23 };
            Sum(sample2Sum, 23);

            Console.WriteLine("***************************Optimized Solution***************************");

            SumOptimized(sample1Sum, 12);
            SumOptimized(sample2Sum, 23);
        }
    }
}
