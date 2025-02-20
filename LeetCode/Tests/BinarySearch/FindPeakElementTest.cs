namespace Tests.BinarySearch;

[TestFixture]
public class FindPeakElementTest
{
    [TestCase<int[],int>([1, 2, 3, 1], 2)]
    [TestCase<int[],int>([1, 2, 1, 3, 5, 6, 4], 5)]
    [TestCase<int[],int>([1, 2], 1)]
    public void Test(int[] nums, int expected)
    {
        // Arrange
        var solution = new FindPeakElementSolution();

        // Act
        var result = solution.FindPeakElement(nums);

        // Assert
        result.Should().Be(expected);
    }
}