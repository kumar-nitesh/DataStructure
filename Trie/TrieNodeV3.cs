namespace Trie
{
    public class TrieNodeV3
    {
        public TrieNodeV3[] Children;
        public int WordCount;

        public TrieNodeV3()
        {
            this.Children = new TrieNodeV3[26];
            this.WordCount = 0;
        }
    }
}
