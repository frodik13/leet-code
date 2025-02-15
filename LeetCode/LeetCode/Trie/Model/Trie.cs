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
            node!.Children[word[i] - 'a'] ??= new TrieNode();
            node = node.Children[word[i] - 'a'];
        }

        node!.IsEnd = true;
    }

    public bool Search(string word)
    {
        var node = _root;
        for (var i = 0; i < word.Length; i++)
        {
            if (node.Children[word[i] - 'a'] == null)
                return false;

            node = node.Children[word[i] - 'a'];
        }

        return node!.IsEnd;
    }

    public bool StartsWith(string prefix)
    {
        var node = _root;
        for (var i = 0; i < prefix.Length; i++)
        {
            if (node!.Children[prefix[i] - 'a'] == null)
                return false;

            node = node.Children[prefix[i] - 'a'];
        }

        return true;
    }
}