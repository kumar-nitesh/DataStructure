namespace Arrays
{
    public static class FibonacciNumber
    {
        /// <summary>
        /// Recursion
        /// </summary>
        /// Time Complexity: O(2ⁿ)
        /// Space complexity: O(1)
        public static int Recursion(int n)
        {
            if (n <= 1)
                return n;

            //Console.WriteLine("Hello : " + n);

            int fibN1 = Recursion(n - 1);
            int fibN2 = Recursion(n - 2);
            int fibN = fibN1 + fibN2;

            return fibN;
        }

        /// <summary>
        /// Memoization(Top Down) Approach
        /// T(n) = T(n-1) + T(n-2).
        /// The function of F(n-2) is 1 because F(n-2) is in the cache when we calculate F(n - 1).
        /// T(n) = T(n-1) + 1 = T(n-2) + 2 = ... = T(n-n) + n
        /// T(n) = O(n + 1) = O(n)
        /// </summary>
        /// Time Complexity: O(n)
        /// Space complexity: O(n)
        public static int Memoized(int n, int[] questionbank)
        {
            if (n <= 1)
                return n;

            if (questionbank[n] != 0)
                return questionbank[n];

            //Console.WriteLine("Hello : " + n);

            int fibN1 = Memoized(n - 1, questionbank);
            int fibN2 = Memoized(n - 2, questionbank);
            int fibN = fibN1 + fibN2;

            questionbank[n] = fibN;

            return fibN;
        }

        /// <summary>
        /// Iterative Method - Fibonacci way
        /// </summary>
        /// Time Complexity: O(n)
        /// Space complexity: O(1)
        public static int Optimized(int n)
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
