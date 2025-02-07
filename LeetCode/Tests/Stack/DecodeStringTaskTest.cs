namespace Tests.Stack;

[TestFixture]
public class DecodeStringTaskTest
{
    [TestCase("3[a]2[bc]", "aaabcbc")]
    [TestCase("3[a2[c]]", "accaccacc")]
    [TestCase("2[abc]3[cd]ef", "abcabccdcdcdef")]
    public void Test(string s, string expected)
    {
        // Arrange
        DecodeStringTask solution = new();
        
        // Act
        var result = solution.DecodeString(s);

        // Assert
        result.Should().Be(expected);
    }
}