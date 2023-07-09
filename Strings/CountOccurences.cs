namespace Strings
{
    public class CountOccurences : IExecute
    {
        public static void Print(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char i in s)
            {
                if (dict.ContainsKey(i))
                {
                    dict[i]++;
                }
                else
                {
                    dict[i] = 1;
                }
            }

            foreach (char i in s)
            {
                if (dict[i] != 0)
                {
                    Console.WriteLine(i + " : " + dict[i].ToString());
                    dict[i] = 0;
                }
            }
        }

        public void Execute()
        {
            Console.WriteLine("########Hacker Earth##########");
            Console.WriteLine("Count occurrences");

            Console.WriteLine("##########################################");
            Print("occurences");

            Console.WriteLine("##########################################");
        }
    }
}
