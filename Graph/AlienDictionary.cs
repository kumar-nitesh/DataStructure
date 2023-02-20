/********************************************************************************************
 * Alien Dictionary
 * 
 * Source     : Geeks for Geeks
 * Difficulty : Graph - Hard
 * Problem    : https://practice.geeksforgeeks.org/problems/alien-dictionary/1
 * Solution   : https://www.youtube.com/watch?v=nV_wOZnhbog
 * Time Complexity  : O(v + e)        
 * Space Complexity : O(v) 
 ********************************************************************************************/

namespace Graph
{
    public class AlienDictionary : IExecute
    {
        /// <summary>
        /// 1. Find Indegree
        /// 2. Find Mismatch characters
        /// 3. Topological Sort
        /// </summary>
        /// <param name="alienDictionary"></param>
        /// <returns></returns>
        private List<char> FindOrder(string[] alienDictionary)
        {
            Dictionary<char, HashSet<char>> mapping = new();

            // Step 1
            var indegree = FindIndegree(alienDictionary);

            for (int i = 0; i < alienDictionary.Length - 1; i++)
            {
                bool mismatchFound = false;
                string currentWord = alienDictionary[i];
                string nextWord = alienDictionary[i + 1];

                var length = Math.Min(currentWord.Length, nextWord.Length);

                for (int j = 0; j < length; j++)
                {
                    char charCurrentWord = currentWord[j];
                    char nextCharCurrentWord = nextWord[j];

                    if (charCurrentWord != nextCharCurrentWord)
                    {
                        var hashSet = new HashSet<char>();

                        if (mapping.ContainsKey(charCurrentWord))
                        {
                            hashSet = mapping[charCurrentWord];
                        }

                        if (!hashSet.Contains(nextCharCurrentWord))
                        {
                            hashSet.Add(nextCharCurrentWord);
                            mapping[charCurrentWord] = hashSet;
                            indegree[nextCharCurrentWord]++;
                        }

                        mismatchFound = true;
                        break;
                    }
                }
                if (!mismatchFound && nextWord.Length < currentWord.Length)
                {
                    return new List<char>();
                }
            }

            return TopologicalSort(mapping, indegree);
        }

        private static Dictionary<char, int> FindIndegree(string[] alienDictionary)
        {
            Dictionary<char, int> indegree = new();

            foreach (var word in alienDictionary)
            {
                foreach (char c in word)
                {
                    indegree[c] = 0;
                }
            }

            return indegree;
        }

        private static List<char> TopologicalSort(Dictionary<char, HashSet<char>> mapping, Dictionary<char, int> indegree)
        {
            List<char> result = new();
            Queue<char> queue = new Queue<char>();
            foreach (var keyValuePair in indegree.Keys)
            {
                if (indegree[keyValuePair] == 0)
                {
                    queue.Enqueue(keyValuePair);
                }
            }

            while (queue.Count > 0)
            {
                char vertex = queue.Dequeue();
                result.Add(vertex);

                if (mapping.ContainsKey(vertex))
                {
                    foreach (var neighbour in mapping[vertex])
                    {
                        indegree[neighbour]--;

                        if (indegree[neighbour] == 0)
                        {
                            queue.Enqueue(neighbour);
                        }
                    }
                }
            }

            if (result.Count != indegree.Count)
            {
                return new List<char>();
            }

            return result;
        }

        public void Execute()
        {
            // Sorted Dictionary
            string[] alienDictionary = { "baa", "abcd", "abca", "cab", "cad" };

            var result = FindOrder(alienDictionary);
            result.ForEach(Console.WriteLine);
        }
    }
}
