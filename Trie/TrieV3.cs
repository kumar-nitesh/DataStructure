namespace Trie
{
    public class TrieV3 : IExecute
    {
        public TrieNodeV3 _root;

        public TrieV3()
        {
            _root = new TrieNodeV3();
        }

        public void Execute()
        {
            TrieV3 trie = new TrieV3();
            trie.Insert("and");
            trie.Insert("ant");
        }

        public void Insert(string word)
        {
            TrieNodeV3 currentNode = _root;

            for (int i = 0; i < word.Length; i++)
            {
                int index = word[i] - 'a';

                if (currentNode.Children[index] == null)
                {
                    currentNode.Children[index] = new TrieNodeV3();
                }

                currentNode = currentNode.Children[index];
            }

            currentNode.WordCount++;
        }
    }
}
