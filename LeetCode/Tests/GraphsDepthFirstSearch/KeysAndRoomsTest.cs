namespace Tests.GraphsDepthFirstSearch;

[TestFixture]
public class KeysAndRoomsTest
{
    private readonly Dictionary<int, List<List<int>>> _testData = new()
    {
        { 1, [[1], [2], [3], []] },
        { 2, [[1, 3], [3, 0, 1], [2], [0]] },
        { 3, [[2],[],[1]]},
    };
    
    [TestCase(1, true)]
    [TestCase(2, false)]
    [TestCase(3, true)]
    public void Test(int testCaseIndex, bool expectedResult)
    {
        // Arrange
        var solution = new KeysAndRooms();
        var rooms = _testData[testCaseIndex];
        
        // Act
        var result = solution.CanVisitAllRooms(rooms);

        // Assert
        result.Should().Be(expectedResult);
    }
}