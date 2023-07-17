namespace DataStructures.Algorithms.Arrays
{
    public class MaximumProfit : IExecute
    {
        ///  Time: O(n), Space: O(1)
        public static int MaxProfit(int[] prices)
        {
            int buyElement = int.MaxValue;
            int profitToday = 0;
            int profitOverall = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < buyElement)
                {
                    buyElement = prices[i];
                }

                profitToday = prices[i] - buyElement;

                if (profitToday > profitOverall)
                {
                    profitOverall = profitToday;
                }
            }

            return profitOverall;
        }

        public void Execute()
        {
            int[] sample1 = new int[] { 7, 1, 5, 3, 6, 4 };
            Console.WriteLine("[{0}]", string.Join(", ", MaxProfit(sample1)));

            int[] sample2 = new int[] { 7, 6, 4, 3, 1 };
            Console.WriteLine("[{0}]", string.Join(", ", MaxProfit(sample2)));
        }
    }
}
