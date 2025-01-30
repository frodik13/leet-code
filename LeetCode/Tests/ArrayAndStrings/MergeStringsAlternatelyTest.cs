using FluentAssertions;
using LeetCode.ArrayAndStrings;

namespace Tests.ArrayAndStrings;

[TestFixture]
public class MergeStringsAlternatelyTest
{
    private readonly MergeStringsAlternately _mergeStringsAlternately = new();

    [TestCase("abc", "pqr", "apbqcr")]
    [TestCase("ab", "pqrs", "apbqrs")]
    [TestCase("abcd", "pq", "apbqcd")]
    public void Test(string word1, string word2, string mergedString)
    {
        // Arrange

        // Act
        var resultMergedString = _mergeStringsAlternately.MergeAlternately(word1, word2);

        // Assert
        resultMergedString.Should().Be(mergedString);
    }
}