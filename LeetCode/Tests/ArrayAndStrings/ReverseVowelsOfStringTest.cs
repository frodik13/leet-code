namespace Tests.ArrayAndStrings;

[TestFixture]
public class ReverseVowelsOfStringTest
{
    [TestCase("IceCreAm", "AceCreIm")]
    [TestCase("leetcode", "leotcede")]
    [TestCase("a.", "a.")]
    public void Test(string s, string expected)
    {
        // Arrange
        var solution = new ReverseVowelsOfString();

        // Act
        var result = solution.ReverseVowels(s);

        // Assert
        result.Should().Be(expected);
    }
}