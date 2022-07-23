using FindDuplicate;

Console.WriteLine("###########LeetCode###########");
Console.WriteLine("287. Find the Duplicate Number");
Console.WriteLine("Difficulty Level - MEDIUM");

int[] test1 = new int[] { 1, 3, 4, 2, 2 };
int[] test2 = new int[] { 1, 1, 2 };
int[] test3 = new int[] { 1, 1 };
int[] test4 = new int[] { 3, 1, 3, 4, 2 };

var result1 = BruteForce.FindDuplicate(test1);
Console.WriteLine("[{0}]", string.Join(", ", result1));

var result2 = BruteForce.FindDuplicate(test2);
Console.WriteLine("[{0}]", string.Join(", ", result2));

var result3 = Optimized.FindDuplicate(test3);
Console.WriteLine("[{0}]", string.Join(", ", result3));

var result4 = Optimized.FindDuplicate(test4);
Console.WriteLine("[{0}]", string.Join(", ", result4));


