/********************************************************************************************
 * Given an array of integers a, your task is to count the number of pairs i and j 
 * (where 0 ≤ i < j < a.length), such that a[i] and a[j] are digit anagrams.
 * 
 * Two integers are considered to be digit anagrams if they contain the same digits. 
 * 
 * For example, 54275 and 45572 are digit anagrams, but 321 and 782 are not 
 * 220 and 22 are also not considered as digit anagrams.
 * 
 * Example
 * For a = [25, 35, 872, 228, 53, 278, 872], the output should be solution(a) = 4.
 * There are 4 pairs of digit anagrams:
 * a[1] = 35 and a[4] = 53 (i = 1 and j = 4),
 * a[2] = 872 and a[5] = 278 (i = 2 and j = 5),
 * a[2] = 872 and a[6] = 872 (i = 2 and j = 6),
 * a[5] = 278 and a[6] = 872 (i = 5 and j = 6).
 * 
 * Company : Agoda
 ********************************************************************************************/

namespace Arrays
{
    public class Anagrams : IExecute
    {
        public void Execute()
        {
            int[] array1 = new int[] { 25, 35, 872, 228, 53, 278, 872 };
            int[] array2 = new int[] { 30, 72, 3, 227 };
            Console.WriteLine(FindAnagrams(array1));
            Console.WriteLine(FindAnagrams(array2));
        }

        public int FindAnagrams(int[] array)
        {
            int count = 0;
            Dictionary<string, int> digitAnagramCounts = new Dictionary<string, int>();

            foreach (int num in array)
            {
                string sortedDigits = SortDigits(num);
                if (digitAnagramCounts.ContainsKey(sortedDigits))
                {
                    count += digitAnagramCounts[sortedDigits];
                    digitAnagramCounts[sortedDigits]++;
                }
                else
                {
                    digitAnagramCounts[sortedDigits] = 1;
                }
            }

            return count;
        }

        string SortDigits(int number)
        {
            Console.WriteLine("#################Agoda#####################");
            char[] digits = number.ToString().ToCharArray();
            Array.Sort(digits);
            return new string(digits);
        }
    }
}
