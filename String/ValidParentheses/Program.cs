using ValidParentheses;

Console.WriteLine("#######LeetCode######");
Console.WriteLine("20. Valid Parentheses");
Console.WriteLine("Difficulty Level - EASY");

Console.WriteLine(BruteForce.ValidParentheses("()"));
Console.WriteLine(BruteForce.ValidParentheses("()[]{}"));
Console.WriteLine(BruteForce.ValidParentheses("(]"));
Console.WriteLine(BruteForce.ValidParentheses("{[]}"));
Console.WriteLine(BruteForce.ValidParentheses("([)]"));
Console.WriteLine("##################################");
Console.WriteLine(Optimized.ValidParentheses("()"));
Console.WriteLine(Optimized.ValidParentheses("()[]{}"));
Console.WriteLine(Optimized.ValidParentheses("(]"));
Console.WriteLine(Optimized.ValidParentheses("{[]}"));
Console.WriteLine(Optimized.ValidParentheses("([)]"));