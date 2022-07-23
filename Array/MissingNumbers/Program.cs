using MissingNumbers;

int[] test1 = new int[] { 3, 0, 1 };
int[] test2 = new int[] { 0, 1 };
int[] test3 = new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 };

var result1 = BruteForce.MissingNumber(test1);
Console.WriteLine("[{0}]", string.Join(", ", result1));

var result2 = BruteForce.MissingNumber(test2);
Console.WriteLine("[{0}]", string.Join(", ", result2));

var result3 = BruteForce.MissingNumber(test3);
Console.WriteLine("[{0}]", string.Join(", ", result3));
