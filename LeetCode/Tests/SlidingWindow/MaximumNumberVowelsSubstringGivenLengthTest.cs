namespace Tests.SlidingWindow;

[TestFixture]
public class MaximumNumberVowelsSubstringGivenLengthTest
{
    [TestCase("abciiidef", 3, 3)]
    [TestCase("aeiou", 2, 2)]
    [TestCase("leetcode", 3, 2)]
    [TestCase("weallloveyou", 7, 4)]
    public void Test(string s, int k, int expected)
    {
        // Arrange
        var solution = new MaximumNumberVowelsSubstringGivenLength();

        // Act
        var result = solution.MaxVowels(s, k);

        // Assert
        result.Should().Be(expected);
    }
}