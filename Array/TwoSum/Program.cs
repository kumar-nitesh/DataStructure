using TwoSum;

int[] test = new int[] { 3, 2, 4 };

var result1 = BruteForce.TwoSum(test, 6);
Console.WriteLine("[{0}]", string.Join(", ", result1));

var result2 = Optimized.TwoSum(test, 6);
Console.WriteLine("[{0}]", string.Join(", ", result2));
