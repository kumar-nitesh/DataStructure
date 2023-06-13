namespace Trie
{

    public class TrieNodeV2
    {
        public char Value { get; set; }
        public List<TrieNodeV2> Children { get; set; }
        public TrieNodeV2 Parent { get; set; }
        public int Depth { get; set; }

        public TrieNodeV2(char value, int depth, TrieNodeV2 parent)
        {
            this.Value = value;
            this.Children = new List<TrieNodeV2>();
            this.Depth = depth;
            this.Parent = parent;
        }

        public bool IsLeaf()
        {
            return Children.Count == 0;
        }

        public TrieNodeV2 FindChildNode(char c)
        {
            foreach (var child in Children)
            {
                if (child.Value == c)
                {
                    return child;
                }
            }

            return null;
        }

        public void DeleteChildNode(char c)
        {
            for (int i = 0; i < Children.Count; i++)
            {
                if (Children[i].Value == c)
                {
                    Children.RemoveAt(i);
                }
            }
        }
    }
}
