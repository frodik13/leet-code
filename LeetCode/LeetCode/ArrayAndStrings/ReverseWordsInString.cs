namespace LeetCode.ArrayAndStrings;

public class ReverseWordsInString
{
    public string ReverseWords(string s)
    {
        var words = s.Split(" ", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        Array.Reverse(words);
        return string.Join(" ", words);
    }
}