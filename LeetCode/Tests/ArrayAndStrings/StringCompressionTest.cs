using FluentAssertions;
using LeetCode.ArrayAndStrings;

namespace Tests.ArrayAndStrings;

[TestFixture]
public class StringCompressionTest
{
    [TestCase<char[], int>(['a','a','b','b','c','c','c'], 6)]
    [TestCase<char[], int>(['a'], 1)]
    [TestCase<char[], int>(['a','b','b','b','b','b','b','b','b','b','b','b','b'], 4)]
    [TestCase<char[], int>(['a','a','a','b','b','a','a'], 6)]
    public void Test(char[] chars, int expected)
    {
        // Arrange
        StringCompression solution = new();

        // Act
        var result = solution.Compress(chars);

        // Assert
        result.Should().Be(expected);
    }
}