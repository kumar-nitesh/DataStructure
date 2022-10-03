namespace Arrays
{
    public static class MaximumProfit
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
    }
}
