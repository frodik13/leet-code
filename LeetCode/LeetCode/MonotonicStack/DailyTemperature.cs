namespace LeetCode.MonotonicStack;

public class DailyTemperature
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        var answer = new int[temperatures.Length];
        Stack<int> stack = [];
        for (var i = 0; i < temperatures.Length; i++)
        {
            while (stack.TryPeek(out var index) && temperatures[index] < temperatures[i])
            {
                stack.Pop();
                answer[index] = i - index;
            }
            stack.Push(i);
        }
        return answer;
    }
}