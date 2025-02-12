namespace Tests.TwoPointers;

[TestFixture]
public class SubsequenceTest
{
    [TestCase("abc", "ahbgdc", true)]
    [TestCase("axc", "ahbgdc", false)]
    public void Test(string s, string t, bool expected)
    {
        // Arrange
		Subsequence solution = new();

        // Act
		var result = solution.IsSubsequence(s, t);

        // Assert
		result.Should().Be(expected);
    }
}