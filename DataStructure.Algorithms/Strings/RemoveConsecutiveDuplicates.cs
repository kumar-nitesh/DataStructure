/********************************************************************************************
 * Given a string, Remove the last consecutive character duplicates.
 * 
 * Company : VMware
 ********************************************************************************************/

namespace DataStructures.Algorithms.Strings
{
    public class RemoveConsecutiveDuplicates : IExecute
    {
        public static string Remove(string s)
        {
            char[] stack = new char[s.Length];
            int index = 0;

            for (int i = 0; i < s.Length; i++)
            {
                char currentChar = s[i];

                if (index > 0 && stack[index - 1] == currentChar)
                {
                    index--;
                }
                else
                {
                    stack[index] = currentChar;
                    index += 1;
                }
            }

            return new string(stack, 0, index);
        }

        public void Execute()
        {
            Console.WriteLine("#################VMware#####################");
            Console.WriteLine("Remove the last consecutive character duplicates");
            string inputString = "abbaca";
            Console.WriteLine(Remove(inputString));
        }
    }
}
