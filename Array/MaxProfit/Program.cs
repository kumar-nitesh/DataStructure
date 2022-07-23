using MaxProfit;

int[] sample1 = new int[] { 7, 1, 5, 3, 6, 4 };
var result1 = BruteForce.MaxProfit(sample1);
Console.WriteLine("[{0}]", string.Join(", ", result1));

int[] sample2 = new int[] { 7, 6, 4, 3, 1 };
var result2 = BruteForce.MaxProfit(sample2);
Console.WriteLine("[{0}]", string.Join(", ", result2));