namespace LeetCode.Stack;

public class AsteroidCollisionSolution
{
    public int[] AsteroidCollision(int[] asteroids)
    {
        var result = new List<int>();

        for (var i = 0; i < asteroids.Length; i++)
        {
            if (result.Count > 0 &&
                result[^1] > 0 &&
                asteroids[i] < 0)
            {
                if (result[^1] > -asteroids[i]) continue;

                if (result[^1] < -asteroids[i]) i--;
                result.RemoveAt(result.Count - 1);
            }
            else
            {
                result.Add(asteroids[i]);
            }
        }

        return [.. result];
    }

    public int[] AsteroidCollisionX(int[] asteroids)
    {
        var stack = new Stack<int>();
        foreach (var asteroid in asteroids)
        {
            if (stack.Count == 0)
            {
                stack.Push(asteroid);
                continue;
            }

            if (asteroid > 0)
            {
                stack.Push(asteroid);
                continue;
            }

            while (stack.Count > 0 && stack.Peek() > 0 && stack.Peek() < Math.Abs(asteroid))
                stack.Pop();

            if (stack.Count == 0)
            {
                stack.Push(asteroid);
                continue;
            }

            if (stack.Peek() == Math.Abs(asteroid))
            {
                stack.Pop();
                continue;
            }

            if (stack.Peek() < 0)
                stack.Push(asteroid);
        }

        return stack.Reverse().ToArray();
    }
}