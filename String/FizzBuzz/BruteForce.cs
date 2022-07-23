namespace FizzBuzz
{
    public static class BruteForce
    {
        /// <summary>
        /// Fizz Buzz
        /// </summary>
        /// Time Complexity: O(n)
        /// Space complexity: O(n)
        public static IList<string> FizzBuzz(int n)
        {
            List<string> list = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    list.Add("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    list.Add("Buzz");
                }
                else if (i % 3 == 0)
                {
                    list.Add("Fizz");
                }
                else
                {
                    list.Add(i.ToString());
                }
            }

            return list;
        }
    }
}
