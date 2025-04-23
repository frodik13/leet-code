namespace Tests.HeapPriorityQueue;

[TestFixture]
public class MaximumSubsequenceScoreTest
{
    [TestCase<int[], int[], int, long>([1, 3, 3, 2], [2, 1, 3, 4], 3, 12)]
    [TestCase<int[], int[], int, long>([4, 2, 3, 1, 1], [7, 5, 10, 9, 6], 1, 30)]
    [TestCase<int[], int[], int, long>([2, 1, 14, 12], [11, 7, 13, 6], 3, 168)]
    public void Test(int[] nums1, int[] nums2, int k, long expected)
    {
        // Arrange
        var solution = new MaximumSubsequenceScore();

        // Act
        var result = solution.MaxScore(nums1, nums2, k);

        // Assert
        result.Should().Be(expected);
    }
}