using MergeTwoSortedArrays;

int[] array1 = new int[] { 1, 2, 3, };
int[] array2 = new int[] { 4, 5, 6 };

Console.WriteLine("Merge 2 Sorted Arrays");
var result1 = BruteForce.Merge(array1, array2);
Console.WriteLine("[{0}]", string.Join(", ", result1));

int[] array3 = new int[] { 1, 2, 3, };
int[] array4 = new int[] { 4, 5, 6, 7, 8 };

Console.WriteLine("Merge 2 Sorted Arrays");
var result2 = BruteForce.Merge(array3, array4);
Console.WriteLine("[{0}]", string.Join(", ", result2));

int[] array5 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int[] array6 = new int[] { 10, 11, 12, 13, 14, 15 };

Console.WriteLine("Merge 2 Sorted Arrays");
var result3 = BruteForce.Merge(array5, array6);
Console.WriteLine("[{0}]", string.Join(", ", result3));

int[] array7 = new int[] { 1, 2, 3, 4 };
int[] array8 = new int[] { 3, 4, 5, 6 };

Console.WriteLine("Merge 2 Sorted Arrays");
var result4 = BruteForce.Merge(array7, array8);
Console.WriteLine("[{0}]", string.Join(", ", result4));