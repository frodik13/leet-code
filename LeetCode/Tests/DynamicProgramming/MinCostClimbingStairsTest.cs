namespace Tests.DynamicProgramming;

[TestFixture]
public class MinCostClimbingStairsTest
{
    [TestCase<int[], int>([10,15,20], 15)]
    [TestCase<int[], int>([1,100,1,1,1,100,1,1,100,1], 6)]
    public void Test(int[] cost, int expected)
    {
        // Arrange
        MinCostClimbingStairsSolution solution = new();

        // Act
        var result = solution.MinCostClimbingStairs(cost);

        // Assert
        result.Should().Be(expected);
    }
}