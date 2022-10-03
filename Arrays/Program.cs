using Arrays;

int[] choclist = new int[] { 3, 4, 1, 9, 56, 7, 9, 12 };
Console.WriteLine(ChocolateDistribution.FindMinDiff(choclist, 8, 5));

int[] choclist1 = new int[] { 17, 83, 59, 25, 38, 63, 25, 1, 37 };
Console.WriteLine(ChocolateDistribution.FindMinDiff(choclist1, 9, 9));

int[] height = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
Console.WriteLine(TrapRainWater.TrapWater(height));

int[] arr = new int[] { 0900, 0940, 0950, 1100, 1500, 1800 };
int[] dep = new int[] { 0910, 1200, 1120, 1130, 1900, 2000 };

Console.WriteLine(MinimumPlatform.MinPlatform(arr, dep, 6));

int[] array1 = new int[] { 1, 2, 3, };
int[] array2 = new int[] { 4, 5, 6 };

Console.WriteLine("Merge 2 Sorted Arrays");
var result1 = MergeTwoSortedArrays.Merge(array1, array2);
Console.WriteLine("[{0}]", string.Join(", ", result1));

int[] array3 = new int[] { 1, 2, 3, };
int[] array4 = new int[] { 4, 5, 6, 7, 8 };

Console.WriteLine("Merge 2 Sorted Arrays");
var result2 = MergeTwoSortedArrays.Merge(array3, array4);
Console.WriteLine("[{0}]", string.Join(", ", result2));

int[] array5 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int[] array6 = new int[] { 10, 11, 12, 13, 14, 15 };

Console.WriteLine("Merge 2 Sorted Arrays");
var result3 = MergeTwoSortedArrays.Merge(array5, array6);
Console.WriteLine("[{0}]", string.Join(", ", result3));

int[] array7 = new int[] { 1, 2, 3, 4 };
int[] array8 = new int[] { 3, 4, 5, 6 };

Console.WriteLine("Merge 2 Sorted Arrays");
var result4 = MergeTwoSortedArrays.Merge(array7, array8);
Console.WriteLine("[{0}]", string.Join(", ", result4));

int[] sample1 = new int[] { 7, 1, 5, 3, 6, 4 };
var resultMaxProfit = MaximumProfit.MaxProfit(sample1);
Console.WriteLine("[{0}]", string.Join(", ", resultMaxProfit));

int[] sample2 = new int[] { 7, 6, 4, 3, 1 };
var resultMaxProfit1 = MaximumProfit.MaxProfit(sample2);
Console.WriteLine("[{0}]", string.Join(", ", resultMaxProfit1));

string[] strs = new string[] { "flower", "flow", "flight" };
Console.WriteLine(LongestCommonPrefix.Prefix(strs));

int[] arrPrefix = new int[] { 6, 2, 10, 49, 193, 1 };
var result = LongestCommonPrefix.Solution(arrPrefix);
Console.WriteLine("[{0}]", string.Join(", ", result));

int[] test1 = new int[] { 3, 0, 1 };
int[] test2 = new int[] { 0, 1 };
int[] test3 = new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 };

var result1Number = MissingNumbers.MissingNumber(test1);
Console.WriteLine("[{0}]", string.Join(", ", result1Number));

var result2Number = MissingNumbers.MissingNumber(test2);
Console.WriteLine("[{0}]", string.Join(", ", result2Number));

var result3Number = MissingNumbers.MissingNumber(test3);
Console.WriteLine("[{0}]", string.Join(", ", result3Number));

Console.WriteLine(RomanToInteger.RomanToInt("MCMXCIV"));

int[] sample1Remove = new int[] { 1, 1, 2 };
Console.WriteLine(RemoveDuplicates.Remove(sample1Remove));

int[] sample2Remove = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
Console.WriteLine(RemoveDuplicates.Remove(sample2Remove));

int[] sample1Duplicate = new int[] { 1, 2, 3, 1 };
Console.WriteLine(ContainsDuplicate.Duplicate(sample1Duplicate));

int[] sample2Duplicate = new int[] { 1, 2, 3, 4 };
Console.WriteLine(ContainsDuplicate.Duplicate(sample2Duplicate));

int[] sample3Duplicate = new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
Console.WriteLine(ContainsDuplicate.Duplicate(sample3Duplicate));

int[] sample4Duplicate = new int[] { 3, 3 };
Console.WriteLine(ContainsDuplicate.Duplicate(sample4Duplicate));

int[] test = new int[] { 3, 2, 4 };
var result1Triplets = CountTriplets.Count(test, 6);
Console.WriteLine("[{0}]", string.Join(", ", result1Triplets));

Console.WriteLine("#######LeetCode######");
Console.WriteLine("509. Fibonacci Number");
Console.WriteLine("Difficulty Level - EASY");

Console.WriteLine(FibonacciNumber.Recursion(10));
Console.WriteLine(FibonacciNumber.Memoized(10, new int[11]));
Console.WriteLine(FibonacciNumber.Optimized(10));

Console.WriteLine(FibonacciNumber.Recursion(5));
Console.WriteLine(FibonacciNumber.Memoized(5, new int[6]));
Console.WriteLine(FibonacciNumber.Optimized(5));

Console.WriteLine(FibonacciNumber.Recursion(6));
Console.WriteLine(FibonacciNumber.Memoized(6, new int[7]));
Console.WriteLine(FibonacciNumber.Optimized(6));

Console.WriteLine("##############LeetCode##############");
Console.WriteLine("442. Find All Duplicates in an Array");
Console.WriteLine("Difficulty Level - MEDIUM");

int[] t1 = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };
int[] t2 = new int[] { 1, 1, 2 };
int[] t3 = new int[] { 2 };
int[] t4 = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };
int[] t5 = new int[] { 1, 1, 2 };
int[] t6 = new int[] { 2, 2 };

var r1 = FindAllDuplicates.Find(t1);
Console.WriteLine("[{0}]", string.Join(", ", r1));

var r2 = FindAllDuplicates.Find(t2);
Console.WriteLine("[{0}]", string.Join(", ", r2));

var r3 = FindAllDuplicates.Find(t3);
Console.WriteLine("[{0}]", string.Join(", ", r3));

var r4 = FindAllDuplicates.Optimized(t4);
Console.WriteLine("[{0}]", string.Join(", ", r4));

var r5 = FindAllDuplicates.Optimized(t5);
Console.WriteLine("[{0}]", string.Join(", ", r5));

var r6 = FindAllDuplicates.Optimized(t6);
Console.WriteLine("[{0}]", string.Join(", ", r6));

int[] s1 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
var ra1 = RotateArray.Rotate(s1, 3);
Console.WriteLine("[{0}]", string.Join(", ", ra1));

int[] s2 = new int[] { -1, -100, 3, 99 };
var ra2 = RotateArray.Rotate(s2, 2);
Console.WriteLine("[{0}]", string.Join(", ", ra2));

int[] s3 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
var ra3 = RotateArray.RotateWithExtraSpace(s3, 3);
Console.WriteLine("[{0}]", string.Join(", ", ra3));

int[] s4 = new int[] { -1, -100, 3, 99 };
var ra4 = RotateArray.RotateWithExtraSpace(s4, 2);
Console.WriteLine("[{0}]", string.Join(", ", ra4));

int[] testSum = new int[] { 3, 2, 4 };
Console.WriteLine("[{0}]", string.Join(", ", TwoSum.Sum(testSum, 6)));
Console.WriteLine("[{0}]", string.Join(", ", TwoSum.Optimized(testSum, 6)));

Console.WriteLine("***************************Brute Force***************************");

int[] sample1Sum = new int[] { 1, 2, 3, 7, 5 };
SubArraySum.Sum(sample1Sum, 12);

int[] sample2Sum = new int[] { 15, 2, 4, 8, 9, 5, 10, 23 };
SubArraySum.Sum(sample2Sum, 23);

Console.WriteLine("***************************Optimized Solution***************************");

SubArraySum.SumOptimized(sample1, 12);
SubArraySum.SumOptimized(sample2, 23);

Console.WriteLine("###########LeetCode###########");
Console.WriteLine("287. Find the Duplicate Number");
Console.WriteLine("Difficulty Level - MEDIUM");

int[] test1DN = new int[] { 1, 3, 4, 2, 2 };
int[] test2DN = new int[] { 1, 1, 2 };
int[] test3DN = new int[] { 1, 1 };
int[] test4DN = new int[] { 3, 1, 3, 4, 2 };

Console.WriteLine("[{0}]", string.Join(", ", FindDuplicate.Find(test1DN)));
Console.WriteLine("[{0}]", string.Join(", ", FindDuplicate.Find(test2DN)));
Console.WriteLine("[{0}]", string.Join(", ", FindDuplicate.Find(test3DN)));
Console.WriteLine("[{0}]", string.Join(", ", FindDuplicate.Find(test4DN)));

int[] array1DNF = { 2, 2, 2, 0, 0, 0, 1, 1 };
int[] array2DNF = { 1, 2, 0 };

Console.WriteLine("[{0}]", string.Join(", ", DutchNationFlag.Sort(array1DNF)));
Console.WriteLine("[{0}]", string.Join(", ", DutchNationFlag.Sort(array2DNF)));

int[] queue1 = new int[] { 2, 1, 5, 3, 4 };
int[] queue2 = new int[] { 2, 5, 1, 3, 4 };

Console.WriteLine(NewYearChaos.MinimumBribes(queue1));
Console.WriteLine(NewYearChaos.MinimumBribes(queue2));
