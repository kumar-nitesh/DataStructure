namespace DataStructures.Algorithms.Arrays
{
    public class NewYearChaos : IExecute
    {
        /// Time Complexity: O(n)
        /// Space complexity: O(1)
        public static string MinimumBribes(int[] queue)
        {
            int bribes = 0;
            string result = string.Empty;
            for (int i = 0; i < queue.Length; i++)
            {
                if (queue[i] - (i + 1) > 2)
                {
                    result = "Too Chaotic";
                    break;
                }

                for (int j = 0; j < i; j++)
                {
                    if (queue[j] > queue[i])
                    {
                        bribes++;
                    }
                }

                result = bribes.ToString();
            }

            return result;
        }

        public void Execute()
        {
            int[] queue1 = new int[] { 2, 1, 5, 3, 4 };
            int[] queue2 = new int[] { 2, 5, 1, 3, 4 };

            Console.WriteLine(MinimumBribes(queue1));
            Console.WriteLine(MinimumBribes(queue2));
        }
    }
}
