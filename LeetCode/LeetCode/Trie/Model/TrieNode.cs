namespace LeetCode.Trie.Model;

public class TrieNode
{
    public TrieNode()
    {
        Children = new TrieNode[26];
        IsEnd = false;
    }

    public TrieNode?[] Children { get; }
    public bool IsEnd { get; set; }
}