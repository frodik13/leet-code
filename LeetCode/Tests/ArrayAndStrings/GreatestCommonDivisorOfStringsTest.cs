using FluentAssertions;
using LeetCode.ArrayAndStrings;

namespace Tests.ArrayAndStrings;

[TestFixture]
public class GreatestCommonDivisorOfStringsTest
{
    [TestCase<string, string, string>("ABCABC", "ABC", "ABC")]
    [TestCase<string, string, string>("ABABAB", "ABAB", "AB")]
    [TestCase<string, string, string>("LEET", "CODE", "")]
    public void Test(string str1, string str2, string expected)
    {
        // Arrange
        GreatestCommonDivisorOfStrings solution = new();

        // Act
        var result = solution.GcdOfStrings(str1, str2);

        // Assert
        result.Should().Be(expected);
    }
}