using ThreeWayPartition;

int[] arr = { 2, 5, 87, 56, 12, 4, 9, 23, 76, 1, 45 };

var result1 = BruteForce.Partition(arr, 15, 30);
Console.WriteLine("[{0}]", string.Join(", ", result1));

int[] array = { 2, 2, 2, 0, 0, 0, 1, 1 };
var result2 = BruteForce.Partition(array, 1, 1);
Console.WriteLine("[{0}]", string.Join(", ", result2));