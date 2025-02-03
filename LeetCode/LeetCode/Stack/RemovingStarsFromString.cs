using System.Text;

namespace LeetCode.Stack;

public class RemovingStarsFromString
{
    public string RemoveStars(string s)
    {
        var stack = new Stack<char>();

        foreach (var c in s)
        {
            if (c != '*')
                stack.Push(c);
            else
                stack.Pop();
        }

        var result = new string(stack.Reverse().ToArray());
        return result;
    }
}