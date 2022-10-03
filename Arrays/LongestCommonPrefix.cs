using System.Text;

namespace Arrays
{
    public static class LongestCommonPrefix
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
