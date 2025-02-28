namespace Tests.TwoPointers;

[TestFixture]
public class ContainerWithMostWaterTest
{
    [TestCase<int[], int>([1, 8, 6, 2, 5, 4, 8, 3, 7], 49)]
    [TestCase<int[], int>([1, 1], 1)]
    public void Test(int[] height, int expected)
    {
        // Arrange
        var solution = new ContainerWithMostWater();

        // Act
        var result = solution.MaxArea(height);

        // Assert
        result.Should().Be(expected);
    }
}