using System.Text;

namespace LeetCode.Stack;

public class DecodeStringTask
{
    public string DecodeString(string s)
    {
        var stackWords = new Stack<string>();
        var stackNumbers = new Stack<int>();
        
        var currentString = string.Empty;
        var currentNumberStr = string.Empty;

        foreach (var c in s)
        {
            if (char.IsDigit(c)) currentNumberStr += c;

            if (char.IsLetter(c)) currentString += c;

            switch (c)
            {
                case '[':
                    stackWords.Push(currentString);
                    stackNumbers.Push(int.Parse(currentNumberStr));
                    currentNumberStr = string.Empty;
                    currentString = string.Empty;
                    continue;
                case ']':
                    currentString = stackWords.Pop() +
                                    string.Join("", Enumerable.Repeat(currentString, stackNumbers.Pop()));
                    continue;
            }
        }

        return currentString;
    }
}