namespace ClimbStairs
{
    public static class Optimized
    {
        public static int ClimbStairs(int n)
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
    }
}