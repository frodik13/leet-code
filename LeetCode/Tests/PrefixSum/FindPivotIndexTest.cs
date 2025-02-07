namespace Tests.PrefixSum;

[TestFixture]
public class FindPivotIndexTest
{
    [TestCase(new[]{ 1, 7, 3, 6, 5, 6 }, 3)]
    [TestCase(new[]{ 1, 2, 3 }, -1)]
    [TestCase(new[]{ 2, 1, -1 }, 0)]
    public void Test(int[] nums, int pivotIndex)
    {
        // Arrange
        var findPivotIndex = new FindPivotIndex();

        // Act
        var result = findPivotIndex.PivotIndex(nums);

        // Assert
        result.Should().Be(pivotIndex);
    }
}