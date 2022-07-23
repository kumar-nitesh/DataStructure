using RotateArray;

int[] sample1 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
var result1 = BruteForce.Rotate(sample1, 3);
Console.WriteLine("[{0}]", string.Join(", ", result1));

int[] sample2 = new int[] { -1, -100, 3, 99 };
var result2 = BruteForce.Rotate(sample2, 2);
Console.WriteLine("[{0}]", string.Join(", ", result2));

int[] sample3 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
var result3 = Optimized.Rotate(sample3, 3);
Console.WriteLine("[{0}]", string.Join(", ", result3));

int[] sample4 = new int[] { -1, -100, 3, 99 };
var result4 = Optimized.Rotate(sample4, 2);
Console.WriteLine("[{0}]", string.Join(", ", result4));