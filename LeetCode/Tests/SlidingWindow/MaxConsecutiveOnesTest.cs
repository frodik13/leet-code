namespace Tests.SlidingWindow;

[TestFixture]
public class MaxConsecutiveOnesTest
{
    [TestCase<int[], int, int>([1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0], 2, 6)]
    [TestCase<int[], int, int>([0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1], 3, 10)]
    public void Test(int[] nums, int k, int expected)
    {
        // Arrange
        var solution = new MaxConsecutiveOnes();

        // Act
        var result = solution.LongestOnes(nums, k);

        // Assert
        result.Should().Be(expected);
    }
}