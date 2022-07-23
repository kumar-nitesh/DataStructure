using ShipPackage;

Console.WriteLine("###LeetCode###");
Console.WriteLine("1011.  Capacity To Ship Packages Within D Days");
Console.WriteLine("Difficulty Level - MEDIUM");

int[] sample1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Console.WriteLine(BruteForce.ShipWithinDays(sample1, 5));

int[] sample2 = new int[] { 3, 2, 2, 4, 1, 4 };
Console.WriteLine(BruteForce.ShipWithinDays(sample2, 3));

int[] sample3 = new int[] { 1, 2, 3, 1, 1 };
Console.WriteLine(BruteForce.ShipWithinDays(sample3, 4));
