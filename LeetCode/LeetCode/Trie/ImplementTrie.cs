namespace LeetCode.Trie;

public class ImplementTrie
{
    private readonly Model.Trie _trie = new();

    public void Insert(string word)
    {
        _trie.Insert(word);
    }

    public bool Search(string word)
    {
        return _trie.Search(word);
    }

    public bool StartsWith(string prefix)
    {
        return _trie.StartsWith(prefix);
    }
}