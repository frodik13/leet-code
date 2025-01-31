using FluentAssertions;
using LeetCode.SlidingWindow;

namespace Tests.SlidingWindow;

[TestFixture]
public class MaximumAverageSubarrayTest
{
    [TestCase(new[] {1,12,-5,-6,50,3}, 4, 12.75000)]
    [TestCase(new[] {5}, 1, 5.00000)]
    public void Test(int[] nums, int k, double expected)
    {
        // Arrange
        var maximumAverageSubarray = new MaximumAverageSubarray();
        
        // Act
        double result = maximumAverageSubarray.FindMaxAverage(nums, k);

        // Assert
        result.Should().Be(expected);
    }
}