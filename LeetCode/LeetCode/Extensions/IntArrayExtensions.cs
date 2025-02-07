namespace LeetCode.Extensions;

public static class IntArrayExtensions
{
    public static long GetHashCodeArray(this IEnumerable<int> array)
    {
        var result = 0l;

        var power = 179;
        var modulo = 179424673;

        foreach (var num in array)
        {
            result = (result + (long)power * num) % modulo;
            power = (power * 179) % modulo;
        }

        return result;
    }
}