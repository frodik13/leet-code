namespace Tests.ArrayAndStrings;

[TestFixture]
public class ReverseWordsInStringTest
{
    [TestCase("the sky is blue", "blue is sky the")]
    [TestCase("  hello world  ", "world hello")]
    [TestCase("a good   example", "example good a")]
    public void Test(string s, string expected)
    {
        // Arrange
        var solution = new ReverseWordsInString();
        
        // Act
        var result = solution.ReverseWords(s);

        // Assert
        result.Should().Be(expected);
    }
}