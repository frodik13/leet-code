namespace Tests.DynamicProgramming;

[TestFixture]
public class EditDistanceTest
{
    [TestCase("horse", "ros", 3)]
    [TestCase("intention", "execution", 5)]
    public void Test(string word1, string word2, int expected)
    {
        // Arrange
        var solution = new EditDistance();

        // Act
        var result = solution.MinDistance(word1, word2);

        // Assert
        result.Should().Be(expected);
    }
}