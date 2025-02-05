namespace LeetCode.ArrayAndStrings;

public class GreatestCommonDivisorOfStrings
{
    public string GcdOfStrings(string str1, string str2)
    {
        if ((str1 + str2) != (str2 + str1))
            return string.Empty;

        var previousShortest = str1.Length;
        var previousRemainder = str2.Length;
        
        var remainder = previousShortest % previousRemainder;

        while (remainder != 0)
        {
            previousShortest = previousRemainder;
            previousRemainder = remainder;
            remainder = previousShortest % previousRemainder;
        }
        
        return str1[..previousRemainder];
    }
}