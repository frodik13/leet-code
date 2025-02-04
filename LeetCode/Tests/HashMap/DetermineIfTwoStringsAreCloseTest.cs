using FluentAssertions;
using LeetCode.HashMap;

namespace Tests.HashMap;

[TestFixture]
public class DetermineIfTwoStringsAreCloseTest
{
    [TestCase("abc", "bca", true)]
    [TestCase("a", "aa", false)]
    [TestCase("cabbba", "abbccc", true)]
    public void Test(string word1, string word2, bool expected)
    {
        // Arrange
        DetermineIfTwoStringsAreClose solution = new();
        
        // Act
        var result = solution.CloseStrings(word1, word2);

        // Assert
        result.Should().Be(expected);
    }
}