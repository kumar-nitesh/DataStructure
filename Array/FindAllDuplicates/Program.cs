using FindAllDuplicates;

Console.WriteLine("##############LeetCode##############");
Console.WriteLine("442. Find All Duplicates in an Array");
Console.WriteLine("Difficulty Level - MEDIUM");

int[] test1 = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };
int[] test2 = new int[] { 1, 1, 2 };
int[] test3 = new int[] { 2 };
int[] test4 = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };
int[] test5 = new int[] { 1, 1, 2 };
int[] test6 = new int[] { 2, 2 };

var result1 = BruteForce.FindDuplicates(test1);
Console.WriteLine("[{0}]", string.Join(", ", result1));

var result2 = BruteForce.FindDuplicates(test2);
Console.WriteLine("[{0}]", string.Join(", ", result2));

var result3 = BruteForce.FindDuplicates(test3);
Console.WriteLine("[{0}]", string.Join(", ", result3));

var result4 = Optimized.FindDuplicates(test4);
Console.WriteLine("[{0}]", string.Join(", ", result4));

var result5 = Optimized.FindDuplicates(test5);
Console.WriteLine("[{0}]", string.Join(", ", result5));

var result6 = Optimized.FindDuplicates(test6);
Console.WriteLine("[{0}]", string.Join(", ", result6));


