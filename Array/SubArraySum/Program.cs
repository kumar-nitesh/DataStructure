using SubArraySum;

Console.WriteLine("***************************Brute Force***************************");

int[] sample1 = new int[] { 1, 2, 3, 7, 5 };
BruteForce.SubArraySum(sample1, 12);

int[] sample2 = new int[] { 15, 2, 4, 8, 9, 5, 10, 23 };
BruteForce.SubArraySum(sample2, 23);

Console.WriteLine("***************************Optimized Solution***************************");

Optimized.SubArraySum(sample1, 12);
Optimized.SubArraySum(sample2, 23);