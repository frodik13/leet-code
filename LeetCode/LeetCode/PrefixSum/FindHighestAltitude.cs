namespace LeetCode.PrefixSum;

public class FindHighestAltitude
{
    public int LargestAltitude(int[] gain)
    {
        var largestAltitude = 0;
        var temp = 0;
        foreach (var value in gain)
        {
            temp += value;
            if (temp > largestAltitude)
            {
                largestAltitude = temp;
            }
        }

        return largestAltitude;
    }
}