namespace LeetCode.SlidingWindow;

public class MaximumNumberVowelsSubstringGivenLength
{
    private readonly char[] vowels = ['a', 'e', 'i', 'o', 'u'];

    public int MaxVowels(string s, int k)
    {
        var maxVowels = 0;

        var charArray = s.ToCharArray();
        for (var i = 0; i < k; i++)
            if (vowels.Contains(charArray[i]))
                maxVowels++;

        var currentVowels = maxVowels;
        for (var i = k; i < charArray.Length; i++)
        {
            if (IsVowel(charArray[i])) currentVowels++;
            if (IsVowel(charArray[i - k])) currentVowels--;
            if (currentVowels > maxVowels)
                maxVowels = currentVowels;
        }

        return maxVowels;
    }

    private bool IsVowel(char c)
    {
        return c is 'a' or 'e' or 'i' or 'o' or 'u';
    }
}