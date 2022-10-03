// See https://aka.ms/new-console-template for more information
using MinPlatform;

int[] arr = new int[] { 0900, 0940, 0950, 1100, 1500, 1800 };
int[] dep = new int[] { 0910, 1200, 1120, 1130, 1900, 2000 };

Console.WriteLine(BruteForce.MinPlatform(arr, dep, 6));
