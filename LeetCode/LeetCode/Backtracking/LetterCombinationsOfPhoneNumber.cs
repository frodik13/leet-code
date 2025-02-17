using System.Text.RegularExpressions;

namespace LeetCode.Backtracking;

public class LetterCombinationsOfPhoneNumber
{
    public IList<string> LetterCombinations(string digits)
    {
        if (string.IsNullOrEmpty(digits)) return new List<string>();
        string[] comb = ["", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"];
        List<string> result = [];
        Solve(0, digits,comb, result, "");
        return result;
    }

    private void Solve(int index, string digits, string[] comb,  List<string> result, string temp)
    {
        if (index == digits.Length)
        {
            result.Add(temp);
            return;
        }

        foreach (var c in comb[digits[index] - '0'])
        {
            Solve(index + 1, digits, comb, result, temp + c);
        }
    }
}