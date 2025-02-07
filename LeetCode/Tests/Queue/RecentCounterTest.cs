namespace Tests.Queue;

public class RecentCounterTest
{
    private readonly RecentCounter _recentCounter = new();

    [TestCase(1, 1)]
    [TestCase(100, 2)]
    [TestCase(3001, 3)]
    [TestCase(3002, 3)]
    public void Test(int t, int answer)
    {
        // Arrange

        // Act
        var count = _recentCounter.Ping(t);

        // Assert
        count.Should().Be(answer);
    }
}