using System.Net.Http.Headers;

namespace LeetCode.BinarySearch;

public class GuessGame
{
    private readonly int _guessNumber;

    public GuessGame(int guessNumber)
    {
        _guessNumber = guessNumber;
    }

    public int GuessNumber(int n)
    {
        var low = 1;
        var high = n;

        while (low <= high)
        {
            var mid = low + (high - low) / 2;

            var result = guess(mid);

            if (result == 0)
                return mid;
            else if (result == -1)
                high = mid - 1;
            else
                low = mid + 1;
        }

        return -1;
    }

    private int guess(int num)
    {
        return num == _guessNumber
            ? 0
            : num > _guessNumber
                ? -1
                : 1;
    }
}