using System.Text;

namespace DataStructures.Algorithms.Arrays
{
    public class LongestCommonPrefix : IExecute
    {
        public static int[] Solution(int[] dataStream)
        {
            int median = 0;
            int sum = 0;
            int dataStreamLength = dataStream.Length;
            for (int i = 0; i < dataStreamLength; i++)
            {
                sum += dataStream[i];
                median = getMedian(sum, i);
                dataStream[i] = (int)median;
            }

            return dataStream;
        }

        static int getMedian(int sum, int i)
        {
            return sum / ++i;
        }
        public static string Prefix(string[] strs)
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

        public void Execute()
        {
            string[] strs = new string[] { "flower", "flow", "flight" };
            Console.WriteLine(Prefix(strs));

            int[] arrPrefix = new int[] { 6, 2, 10, 49, 193, 1 };
            Console.WriteLine("[{0}]", string.Join(", ", Solution(arrPrefix)));
        }
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
}
