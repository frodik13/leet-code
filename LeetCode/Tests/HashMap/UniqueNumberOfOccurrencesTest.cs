namespace Tests.HashMap;

[TestFixture]
public class UniqueNumberOfOccurrencesTest
{
    [TestCase<int[], bool>([1, 2, 2, 1, 1, 3], true)]
    [TestCase<int[], bool>([1, 2], false)]
    [TestCase<int[], bool>([-3, 0, 1, -3, 1, 1, 1, -3, 10, 0], true)]
    public void Test(int[] arr, bool expected)
    {
        // Arrange
        UniqueNumberOfOccurrences solution = new();

        // Act
        var result = solution.UniqueOccurrences(arr);

        // Assert
        result.Should().Be(expected);
    }
}