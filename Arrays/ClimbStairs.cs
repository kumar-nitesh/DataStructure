namespace Arrays
{
    public class ClimbStairs : IExecute
    {
        /// <summary>
        /// Bottom Up - Tabular Approach
        /// State: 
        /// dp[i] - number of ways to reach the ith step
        /// State Transfer Function: 
        /// dp[i] = dp[i - 1] + dp[i - 2] 
        /// taking a step from(i - 1), or 
        /// taking a step of 2 from(i - 2) 
        /// Initial State: 
        /// dp[0] = 0;
        /// dp[1] = 1;
        /// dp[2] = 2;
        /// Answer: dp[n]
        /// </summary>
        /// Time Complexity: O(n)
        /// Space complexity: O(n)
        public static int Tabular(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            if (n == 2) return 2;

            int[] steps = new int[n + 1];

            steps[0] = 0;
            steps[1] = 1;
            steps[2] = 2;

            for (int i = 3; i < n + 1; i++)
            {
                steps[i] = steps[i - 1] + steps[i - 2];
            }

            return steps[n];
        }

        public static int Optimized(int n)
        {
            int fibN1 = 1;
            int fibN2 = 2;

            if (n == 1)
            {
                return 1;
            }

            for (int i = 3; i <= n; i++)
            {
                int fibN = fibN1 + fibN2;
                fibN1 = fibN2;
                fibN2 = fibN;
            }

            return fibN2;
        }

        public void Execute()
        {
            Console.WriteLine("######LeetCode#####");
            Console.WriteLine("70. Climbing Stairs");
            Console.WriteLine("Difficulty Level - EASY");

            Console.WriteLine(Tabular(2));
            Console.WriteLine(Optimized(2));
            Console.WriteLine(Tabular(3));
            Console.WriteLine(Optimized(3));
            Console.WriteLine(Tabular(5));
            Console.WriteLine(Optimized(5));
            Console.WriteLine(Tabular(10));
            Console.WriteLine(Optimized(10));
        }
    }
}
