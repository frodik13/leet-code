using FluentAssertions;
using LeetCode.SlidingWindow;

namespace Tests.SlidingWindow;

[TestFixture]
public class LongestSubArray1AfterDeletingOneElementTest
{
    [TestCase<int[], int>([1, 1, 0, 1], 3)]
    [TestCase<int[], int>([0, 1, 1, 1, 0, 1, 1, 0, 1], 5)]
    [TestCase<int[], int>([1, 1, 1], 2)]
    [TestCase<int[], int>([1,1,1,0,1,1,0,1,1,1,1,0,1,1,0,1,1,1,1,1,0,1,1,1], 8)]
    public void Test(int[] nums, int expected)
    {
        // Arrange
        LongestSubArray1AfterDeletingOneElement solution = new();

        // Act
        var result = solution.LongestSubarray(nums);

        // Assert
        result.Should().Be(expected);
    }
}