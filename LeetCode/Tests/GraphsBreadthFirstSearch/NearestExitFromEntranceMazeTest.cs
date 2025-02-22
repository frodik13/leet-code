namespace Tests.GraphsBreadthFirstSearch;

[TestFixture]
public class NearestExitFromEntranceMazeTest
{
    private readonly Dictionary<int, char[][]> _mazeCase = new()
    {
        { 1, [['+', '+', '.', '+'], ['.', '.', '.', '+'], ['+', '+', '+', '.']] },
        { 2, [['+', '+', '+'], ['.', '.', '.'], ['+', '+', '+']] },
        { 3, [['.', '+']] },
    };

    [TestCase<int, int[], int>(1, [1, 2], 1)]
    [TestCase<int, int[], int>(2, [1, 0], 2)]
    [TestCase<int, int[], int>(3, [0, 0], -1)]
    public void Test(int mazeCase, int[] entrance, int expected)
    {
        // Arrange
        var solution = new NearestExitFromEntranceMaze();
        var maze = _mazeCase[mazeCase];

        // Act
        var result = solution.NearestExit(maze, entrance);

        // Assert
        result.Should().Be(expected);
    }
}