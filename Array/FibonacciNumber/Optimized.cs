namespace FibonacciNumber
{
    public static class Optimized
    {
        /// <summary>
        /// Iterative Method - Fibonacci way
        /// </summary>
        /// Time Complexity: O(n)
        /// Space complexity: O(1)
        public static int FibonacciNumber(int n)
        {
            int fibN1 = 0;
            int fibN2 = 1;
            int fibN = fibN1 + fibN2;

            if (n == 0) return 0;
            for (int i = 1; i < n; i++)
            {
                fibN = fibN1 + fibN2;
                fibN1 = fibN2;
                fibN2 = fibN;
            }

            return fibN;
        }
    }
}