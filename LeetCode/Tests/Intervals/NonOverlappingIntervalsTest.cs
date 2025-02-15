namespace Tests.Intervals;

[TestFixture]
public class NonOverlappingIntervalsTest
{
    private readonly Dictionary<int, int[][]> _testCases = new()
    {
        { 1, [[1,2],[2,3],[3,4],[1,3]]},
        { 2, [[1,2],[1,2],[1,2]]},
        { 3, [[1,2],[2,3]]},
    };

    [TestCase(1, 1)]
    [TestCase(2, 2)]
    [TestCase(3, 0)]
    public void Test(int testCase, int expected)
    {
        // Arrange
        NonOverlappingIntervals solution = new();
        var intervals = _testCases[testCase];

        // Act
        var result = solution.EraseOverlapIntervals(intervals);

        // Assert
        result.Should().Be(expected);
    }
}