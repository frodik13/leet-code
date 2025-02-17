namespace LeetCode.Trie.Model;

public class Trie
{
    private readonly TrieNode _root;

    public Trie()
    {
        _root = new TrieNode();
    }

    public void Insert(string word)
    {
        var node = _root;
        for (var i = 0; i < word.Length; i++)
        {
            node.Children.TryAdd(word[i], new TrieNode());
            node = node.Children[word[i]];
        }

        node!.IsEnd = true;
    }

    public bool Search(string word)
    {
        var node = _root;
        for (var i = 0; i < word.Length; i++)
        {
            if (!node.Children.TryGetValue(word[i], out node))
                return false;
        }

        return node!.IsEnd;
    }

    public bool StartsWith(string prefix)
    {
        var node = _root;
        for (var i = 0; i < prefix.Length; i++)
        {
            if (!node.Children.TryGetValue(prefix[i], out node))
                return false;
        }

        return true;
    }
}