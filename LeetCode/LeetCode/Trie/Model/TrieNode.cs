namespace LeetCode.Trie.Model;

public class TrieNode
{
    public TrieNode()
    {
        Children = new Dictionary<char, TrieNode>();
        IsEnd = false;
    }

    public Dictionary<char, TrieNode> Children { get; set; }
    public bool IsEnd { get; set; }
}