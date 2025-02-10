namespace Tests.BitManipulation;

[TestFixture]
public class CountingBitsTest
{
    [TestCase<int, int[]>(2, [0,1,1])]
    [TestCase<int, int[]>(5, [0,1,1,2,1,2])]
    public void Test(int n, int[] expected)
    {
        // Arrange
        CountingBits solution = new();

        // Act
        var result = solution.CountBits(n);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }
}