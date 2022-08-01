using LongestCommonPrefix;
using System.Text;

string[] strs = new string[] { "flower", "flow", "flight" };
Console.WriteLine(LongestCommonPrefix(strs));

int[] arr = new int[] { 6, 2, 10, 49, 193, 1 };
var result = BruteForce.Solution(arr);
Console.WriteLine("[{0}]", string.Join(", ", result));

static string LongestCommonPrefix(string[] strs)
{
    var strbuilder = new StringBuilder();
    for (int index = 0; index < strs[0].Length; index++)
    {
        for (int i = 1; i < strs.Length; i++)
        {
            if (index >= strs[i].Length || strs[i][index] != strs[0][index])
            {
                return strbuilder.ToString();
            }
        }
        strbuilder.Append(strs[0][index]);
    }

    return strbuilder.ToString();
}

class A
{
    public int ab = 9;
    public double b = 10;

    public A(int num)
    {
        ab = num;
        b = 2 * num;
    }
}