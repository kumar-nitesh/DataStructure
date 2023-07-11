/********************************************************************************************
* You are implementing your own programming language and you've decided to add support for 
* merging strings. A typical merge function would take two strings s1 and s2, and return the 
* lexicographically smallest result that can be obtained by placing the symbols of s2 between 
* the symbols of s1 in such a way that maintains the relative order of the chars in each string.
* 
* For example, if s1 = "super" and s2 = "tower", 
* the result should be merge(s1, s2) = "stouperwer"
* 
*  
* Company : Agoda
********************************************************************************************/



namespace Strings
{
    public class Merge : IExecute
    {
        public string LexicographMerge(string string1, string string2)
        {
            Dictionary<char, int> record1 = new Dictionary<char, int>();
            Dictionary<char, int> record2 = new Dictionary<char, int>();

            foreach (char ch in string1)
            {
                if (record1.ContainsKey(ch))
                    record1[ch]++;
                else
                    record1[ch] = 1;
            }

            foreach (char ch in string2)
            {
                if (record2.ContainsKey(ch))
                    record2[ch]++;
                else
                    record2[ch] = 1;
            }

            int pt1 = 0;
            int pt2 = 0;
            int len1 = string1.Length;
            int len2 = string2.Length;
            List<char> res = new List<char>();

            while (pt1 < len1 && pt2 < len2)
            {
                if (record1[string1[pt1]] < record2[string2[pt2]])
                {
                    res.Add(string1[pt1]);
                    pt1++;
                }
                else if (record1[string1[pt1]] > record2[string2[pt2]])
                {
                    res.Add(string2[pt2]);
                    pt2++;
                }
                else
                {
                    if (string1[pt1] <= string2[pt2])
                    {
                        res.Add(string1[pt1]);
                        pt1++;
                    }
                    else if (string1[pt1] > string2[pt2])
                    {
                        res.Add(string2[pt2]);
                        pt2++;
                    }
                }
            }

            while (pt1 < len1)
            {
                res.Add(string1[pt1]);
                pt1++;
            }

            while (pt2 < len2)
            {
                res.Add(string2[pt2]);
                pt2++;
            }

            return new string(res.ToArray());
        }

        public void Execute()
        {
            Console.WriteLine("#################Agoda#####################");
            Console.WriteLine("Lexicographically Merge");

            Console.WriteLine(LexicographMerge("super", "towers"));
        }
    }
}
