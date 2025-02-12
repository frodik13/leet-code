namespace Tests.TwoPointers;

[TestFixture]
public class IsSubsequenceTest
{
    [TestCase("abc", "ahbgdc", true)]
    [TestCase("axc", "ahbgdc", true)]
    public void Test(string s, string t, bool expected)
    {
        // Arrange
		IsSubsequence solution = new();

        // Act
		var result = solution.IsSubsequence(s, t);

        // Assert
		result.Should().Be(expected);
    }
}