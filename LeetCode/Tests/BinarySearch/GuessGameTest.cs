using FluentAssertions;
using LeetCode.BinarySearch;

namespace Tests.BinarySearch;

[TestFixture]
public class GuessGameTest
{
    [TestCase(10, 6, 6)]
    [TestCase(1, 1, 1)]
    [TestCase(2, 1, 1)]
    [TestCase(100, 74, 74)]
    [TestCase(10000000, 452876, 452876)]
    public void Test(int n, int pick, int answer)
    {
        // Arrange
        var guessGame = new GuessGame(pick);

        // Act
        var result = guessGame.GuessNumber(n);

        // Assert
        result.Should().Be(answer);
    }
}