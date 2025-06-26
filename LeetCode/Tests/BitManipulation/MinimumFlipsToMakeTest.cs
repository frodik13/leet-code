namespace Tests.BitManipulation;

[TestFixture]
public class MinimumFlipsToMakeTest
{
    [TestCase(2, 6, 5, 3)]
    [TestCase(4, 2, 7, 1)]
    [TestCase(1, 2, 3, 0)]
    public void Test(int a, int b, int c, int expected)
    {
        // Arrange
        MinimumFlipsToMake solution = new();

        // Act
        var result = solution.MinFlips(a, b, c);

        // Assert
        result.Should().Be(expected);
    }
}