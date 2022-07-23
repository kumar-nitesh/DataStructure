using ContainsDuplicate;

int[] sample1 = new int[] { 1, 2, 3, 1 };
Console.WriteLine(BruteForce.ContainsDuplicate(sample1));

int[] sample2 = new int[] { 1, 2, 3, 4 };
Console.WriteLine(BruteForce.ContainsDuplicate(sample2));

int[] sample3 = new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
Console.WriteLine(BruteForce.ContainsDuplicate(sample3));

int[] sample4 = new int[] { 3, 3};
Console.WriteLine(BruteForce.ContainsDuplicate(sample4));