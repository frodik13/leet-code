namespace Tests.TwoPointers;

[TestFixture]
public class MaxNumberOfKSumPairsTest
{
    [TestCase<int[], int, int>([1, 2, 3, 4], 5, 2)]
    [TestCase<int[], int, int>([3, 1, 3, 4, 3], 6, 1)]
    public void Test(int[] nums, int k, int expected)
    {
        // Arrange
        MaxNumberOfKSumPairs solution = new();

        // Act
        var result = solution.MaxOperations(nums, k);

        // Assert
        result.Should().Be(expected);
    }
}