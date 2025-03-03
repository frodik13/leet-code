namespace Tests.Stack;

[TestFixture]
public class AsteroidCollisionTest
{
    [TestCase<int[], int[]>([5, 10, -5], [5, 10])]
    [TestCase<int[], int[]>([8, -8], [])]
    [TestCase<int[], int[]>([10, 2, -5], [10])]
    public void Test(int[] asteroids, int[] expected)
    {
        // Arrange
        var solution = new AsteroidCollisionSolution();

        // Act
        var result = solution.AsteroidCollision(asteroids);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }
}