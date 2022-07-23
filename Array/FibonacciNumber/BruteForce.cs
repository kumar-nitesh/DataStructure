namespace FibonacciNumber
{
    public static class BruteForce
    {
        /// <summary>
        /// Recursion
        /// </summary>
        /// Time Complexity: O(2ⁿ)
        /// Space complexity: O(1)
        public static int FibonacciNumber(int n)
        {
            if (n <= 1)
                return n;

            //Console.WriteLine("Hello : " + n);

            int fibN1 = FibonacciNumber(n - 1);
            int fibN2 = FibonacciNumber(n - 2);
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
        public static int FibonacciNumberMemoized(int n, int[] questionbank)
        {
            if (n <= 1)
                return n;

            if (questionbank[n] != 0)
                return questionbank[n];

            //Console.WriteLine("Hello : " + n);

            int fibN1 = FibonacciNumberMemoized(n - 1, questionbank);
            int fibN2 = FibonacciNumberMemoized(n - 2, questionbank);
            int fibN = fibN1 + fibN2;

            questionbank[n] = fibN;

            return fibN;
        }
    }
}
