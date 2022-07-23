namespace SubArraySum
{
    public static class Optimized
    {
        /// <summary>
        /// Time Complexity: O(n). 
        /// Space Complexity: O(1). 
        /// </summary>
        public static void SubArraySum(int[] arr, int s)
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
    }
}
