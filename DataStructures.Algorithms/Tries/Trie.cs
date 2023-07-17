using System.Text;

namespace DataStructures.Algorithms.Tries
{
    public class Trie : IExecute
    {
        public TrieNode _root { get; }

        public Trie()
        {
            _root = new TrieNode();
        }

        public void Execute()
        {
            Trie trie = new Trie();

            trie.Insert("and");
            trie.Insert("ant");
            trie.StartsWith("an").ForEach(Console.WriteLine);
            Console.WriteLine(trie.Search("an"));
            Console.WriteLine(trie.Search("and"));
            trie.Delete("ant");
        }

        public void Insert(string word)
        {
            TrieNode current = _root;

            foreach (char ch in word)
            {
                if (!current.Children.ContainsKey(ch))
                {
                    current.Children.Add(ch, new TrieNode());
                }

                current = current.Children[ch];
            }

            current.IsEndOfWord = true;
        }

        public bool Search(string word)
        {
            TrieNode current = _root;

            foreach (char ch in word)
            {
                if (!current.Children.TryGetValue(ch, out TrieNode node))
                {
                    return false;
                }

                current = node;
            }

            return current.IsEndOfWord;
        }

        public void Delete(string word)
        {
            Delete(_root, word, 0);
        }

        private bool Delete(TrieNode current, string word, int index)
        {
            if (index == word.Length)
            {
                if (!current.IsEndOfWord)
                {
                    return false;
                }
                current.IsEndOfWord = false;
                return current.Children.Count == 0;
            }
            if (!current.Children.TryGetValue(word[index], out TrieNode node))
            {
                return false;
            }
            bool shouldDeleteCurrentNode = Delete(node, word, index + 1) && !node.IsEndOfWord;
            if (shouldDeleteCurrentNode)
            {
                current.Children.Remove(word[index]);
                return current.Children.Count == 0;
            }
            return false;
        }


        public List<string> StartsWith(string prefix)
        {
            List<string> result = new List<string>();

            TrieNode current = _root;
            foreach (char ch in prefix)
            {
                if (!current.Children.TryGetValue(ch, out TrieNode node))
                {
                    return result;
                }
                current = node;
            }

            StringBuilder sbPrefix = new StringBuilder(prefix);
            foreach (var pair in current.Children)
            {
                CreateStrings(sbPrefix.Append(pair.Key), pair, result);
                sbPrefix.Remove(sbPrefix.Length - 1, 1);
            }

            return result;
        }

        private void CreateStrings(StringBuilder prefix, KeyValuePair<char, TrieNode> pair, List<string> result)
        {
            if (pair.Value.Children.Count == 0)
            {
                result.Add(prefix.ToString());
                return;
            }

            foreach (var child in pair.Value.Children)
            {
                CreateStrings(prefix.Append(child.Key), child, result);
                prefix.Remove(prefix.Length - 1, 1);
            }
        }
    }
}
