namespace LeetCode.MonotonicStack;

[TestFixture]
public class DailyTemperatureTest
{
    [TestCase<int[], int[]>([73,74,75,71,69,72,76,73], [1,1,4,2,1,1,0,0])]
    [TestCase<int[], int[]>([30,40,50,60], [1,1,1,0])]
    [TestCase<int[], int[]>([30,60,90], [1,1,0])]
    public void Test(int[] temperatures, int[] expected)
    {
        // Arrange
        var solution = new DailyTemperature();

        // Act
        var result = solution.DailyTemperatures(temperatures);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }
}