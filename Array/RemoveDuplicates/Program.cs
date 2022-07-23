using RemoveDuplicates;

int[] sample1 = new int[] { 1, 1, 2 };

var result = BruteForce.RemoveDuplicates(sample1);
Console.WriteLine(result);

int[] sample2 = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
Console.WriteLine(BruteForce.RemoveDuplicates(sample2));