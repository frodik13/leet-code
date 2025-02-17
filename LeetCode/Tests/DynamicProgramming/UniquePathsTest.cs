namespace Tests.DynamicProgramming;

[TestFixture]
public class UniquePathsTest
{
    [TestCase(3, 7, 28)]
    [TestCase(3, 2, 3)]
    public void Test(int m, int n, int expected)
    {
        // Arrange
        UniquePathsSolution solution = new();

        // Act
        var result = solution.UniquePaths(m, n);

        // Assert
        result.Should().Be(expected);
    }
}