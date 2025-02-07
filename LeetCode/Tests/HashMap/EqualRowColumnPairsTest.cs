namespace Tests.HashMap;

[TestFixture]
public class EqualRowColumnPairsTest
{
    private readonly Dictionary<int, int[][]> _testData = new()
    {
        { 1,
            [[3,2,1], [1,7,6], [2,7,7]]
        },
        { 2,
            [[3,1,2,2], [1,4,4,5], [2,4,2,2], [2,4,2,2]]
        }
    };
    
    [TestCase<int, int>(1, 1)]
    [TestCase<int, int>(2, 3)]
    public void Test(int testDataIndex, int expected)
    {
        // Arrange
        EqualRowColumnPairs solution = new();
        var grid = _testData[testDataIndex];
        
        // Act
        var result = solution.EqualPairs(grid);

        // Assert
        result.Should().Be(expected);
    }
}