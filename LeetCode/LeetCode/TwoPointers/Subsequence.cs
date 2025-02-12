namespace LeetCode.TwoPointers;

public class Subsequence
{
    public bool IsSubsequence(string s, string t)
	{
        var sIndex = 0;
		var tIndex = 0;
		while (sIndex < s.Length && tIndex < t.Length)
		{
			if (s[sIndex] == t[tIndex]) sIndex++;
            tIndex++;
		}
		
		return sIndex == s.Length;
	}
}