namespace LeetCode.ArrayAndStrings;

public class KidsWithGreatestNumberOfCandies
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        var result = new List<bool>(candies.Length);
        var maxCandies = int.MinValue;
        foreach (var candy in candies)
        {
            if (candy > maxCandies)
                maxCandies = candy;
        }
        
        foreach (var candy in candies)
        {
            var extra = candy + extraCandies;
            result.Add(extra >= maxCandies);
        }

        return result;
    }
}