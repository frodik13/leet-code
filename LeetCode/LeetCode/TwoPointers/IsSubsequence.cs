namespace LeetCode.TwoPointers;

public class IsSubsequence
{
    public bool IsSubsequence(string s, string t)
	{
		var result = true;

		var sIndex = 0;
		var tIndex = 0;
		while (sIndex < s.Lenght || tIndex < t.Length)
		{
			var sLetter = s[sIndex];
			var tLetter = t[tIndex];
			if (sLetter == tLetter)
			{
				sIndex++;
				tIndex++;
			}
			else
			{
				tIndex++;
			}
		}
		
		if (sIndex == s.Length - 1 && tIndex < t.Length)
			return true;
		else return false;
		
		return result;
	}
}