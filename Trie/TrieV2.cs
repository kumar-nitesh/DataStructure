/********************************************************************************************
 * Insert in a Trie
 * 
 * Problem    : https://leetcode.com/problems/implement-trie-prefix-tree/
 * Solution   : https://www.byteinthesky.com/tutorials/trie-implementation-in-c-sharp/
 * https://code-maze.com/csharp-using-trie-class-for-efficient-text-pattern-searching/
 *
 ********************************************************************************************/

namespace Trie
{
    public class TrieV2 : IExecute
    {
        private readonly TrieNodeV2 _root;

        public TrieV2()
        {
            _root = new TrieNodeV2('^', 0, null);
        }

        public void Execute()
        {
            TrieV2 trie = new TrieV2();
            trie.InsertRange(new string[] { "and", "ant" });
            Console.WriteLine("Search : " + trie.Search("an"));
            Console.WriteLine("Search : " + trie.Search("and"));
            trie.Delete("ant");
        }

        public TrieNodeV2 Prefix(string word)
        {
            var currentNode = _root;
            var result = currentNode;

            foreach (char ch in word)
            {
                currentNode = currentNode.FindChildNode(ch);

                if (currentNode == null)
                {
                    break;
                }

                result = currentNode;
            }

            return result;
        }

        public void Insert(string word)
        {
            var commonPrefix = Prefix(word);
            var current = commonPrefix;

            for (int i = current.Depth; i < word.Length; i++)
            {
                var newNode = new TrieNodeV2(word[i], current.Depth + 1, current);

                current.Children.Add(newNode);
                current = newNode;
            }

            current.Children.Add(new TrieNodeV2('$', current.Depth + 1, current));
        }

        public void InsertRange(string[] words)
        {
            for (int i = 0; i < words.Count(); i++)
            {
                Insert(words[i]);
            }
        }

        public bool Search(string word)
        {
            var prefix = Prefix(word);
            return prefix.Depth == word.Length && prefix.FindChildNode('$') != null;
        }

        public void Delete(string word)
        {
            if (Search(word))
            {
                var node = Prefix(word).FindChildNode('$');

                while (node.IsLeaf())
                {
                    var parent = node.Parent;
                    parent.DeleteChildNode(node.Value);
                    node = parent;
                }
            }
        }
    }
}
