using RemoveAdjacentDuplicates;

Console.WriteLine("#################LeetCode#####################");
Console.WriteLine("1047. Remove All Adjacent Duplicates In String");
Console.WriteLine("Difficulty Level - EASY");

Console.WriteLine(BruteForce.RemoveAdjacentDuplicates("abbaca"));
Console.WriteLine(BruteForce.RemoveAdjacentDuplicates("azxxzy"));
Console.WriteLine("##########################################");
Console.WriteLine(Optimized.RemoveAdjacentDuplicates("abbaca"));
Console.WriteLine(Optimized.RemoveAdjacentDuplicates("azxxzy"));
