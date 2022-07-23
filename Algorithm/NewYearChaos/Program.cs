// See https://aka.ms/new-console-template for more information
using NewYearChaos;

int[] queue1 = new int[] { 2, 1, 5, 3, 4 };
int[] queue2 = new int[] { 2, 5, 1, 3, 4 };

Console.WriteLine(BruteForce.MinimumBribes(queue1));
Console.WriteLine(BruteForce.MinimumBribes(queue2));
