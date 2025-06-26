namespace Tests.DynamicProgramming;

[TestFixture]
public class DominoTrominoTilingTest
{
    [TestCase(3, 5)]
    [TestCase(1, 1)]
    [TestCase(30, 312342182)]
    public void Test(int n, int expected)
    {
        // Arrange
        DominoTrominoTiling solution = new();
        
        // Act
        var result = solution.NumTilings(n);

        // Assert
        result.Should().Be(expected);
    }
}