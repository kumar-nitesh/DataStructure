using FibonacciNumber;

Console.WriteLine("#######LeetCode######");
Console.WriteLine("509. Fibonacci Number");
Console.WriteLine("Difficulty Level - EASY");

Console.WriteLine(BruteForce.FibonacciNumber(10));
Console.WriteLine(BruteForce.FibonacciNumberMemoized(10, new int[11]));
Console.WriteLine(Optimized.FibonacciNumber(10));

Console.WriteLine(BruteForce.FibonacciNumber(5));
Console.WriteLine(BruteForce.FibonacciNumberMemoized(5, new int[6]));
Console.WriteLine(Optimized.FibonacciNumber(5));

Console.WriteLine(BruteForce.FibonacciNumber(6));
Console.WriteLine(BruteForce.FibonacciNumberMemoized(6, new int[7]));
Console.WriteLine(Optimized.FibonacciNumber(6));