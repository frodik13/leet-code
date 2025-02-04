namespace LeetCode.HashMap;

public class DetermineIfTwoStringsAreClose
{
    public bool CloseStrings(string word1, string word2)
    {
        if (word1.Length != word2.Length)
            return false;

        var letters1Count = new int[26];
        var letters2Count = new int[26];

        foreach (var letter in word1)
        {
            letters1Count[letter - 'a']++;
        }
        
        foreach (var letter in word2)
        {
            letters2Count[letter - 'a']++;
        }

        if (letters1Count.Where((t, i) => t > 0 != letters2Count[i] > 0).Any())
        {
            return false;
        }

        Array.Sort(letters1Count);
        Array.Sort(letters2Count);

        return !letters1Count.Where((t, i) => t != letters2Count[i]).Any();
    }
}