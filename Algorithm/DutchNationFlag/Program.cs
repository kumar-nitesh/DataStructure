using DutchNationFlag;

int[] array1 = { 2, 2, 2, 0, 0, 0, 1, 1 };
int[] array2 = { 1, 2, 0 };

var result1 = BruteForce.Sort(array1);
Console.WriteLine("[{0}]", string.Join(", ", result1));

var result2 = BruteForce.Sort(array2);
Console.WriteLine("[{0}]", string.Join(", ", result2));