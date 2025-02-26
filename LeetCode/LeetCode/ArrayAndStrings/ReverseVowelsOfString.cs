using System.Text;

namespace LeetCode.ArrayAndStrings;

public class ReverseVowelsOfString
{
    private readonly HashSet<char> _vowels = ['A', 'a', 'E', 'e', 'U', 'u', 'I', 'i', 'O', 'o'];
    public string ReverseVowels(string s)
    {
        var left = 0;
        var right = s.Length - 1;

        var result = s.ToCharArray();

        var stringBuilder = new StringBuilder(s);

        while (left <= right)
        {
            while (!_vowels.Contains(s[left]))
            {
                result[left] = s[left];
                left++;
                if (left >= right)
                    break;
            }
            
            while (!_vowels.Contains(s[right]))
            {
                result[right] = s[right];
                right--;
                if (left >= right)
                    break;
            }

            if (left >= right)
                break;

            result[right] = s[left];
            result[left] = s[right];
            

            left++;
            right--;
        }

        return new string(result);
    }
}