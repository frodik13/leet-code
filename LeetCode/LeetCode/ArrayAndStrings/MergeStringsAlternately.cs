namespace LeetCode.ArrayAndStrings;

public class MergeStringsAlternately
{
    public string MergeAlternately(string word1, string word2)
    {
        var result = string.Empty;
        var maxIndex = Math.Max(word1.Length, word2.Length);
        var index = 0;

        while (index < maxIndex)
        {
            if (word1.Length > index)
            {
                result += word1[index];
            }

            if (word2.Length > index)
            {
                result += word2[index];
            }

            index++;
        }

        return result;
    }
}