namespace LongestCommonPrefix
{
    public static class BruteForce
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

    }
}
