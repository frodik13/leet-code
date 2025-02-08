namespace Tests.Queue;

[TestFixture]
public class Dota2SenateTest
{
    [TestCase("RD", "Radiant")]
    [TestCase("RDD", "Dire")]
    [TestCase("DDRRR", "Dire")]
    [TestCase("DDR", "Dire")]
    public void Test(string senate, string expected)
    {
        // Arrange
        Dota2Senate solution = new();

        // Act
        var result = solution.PredictPartyVictory(senate);

        // Assert
        result.Should().Be(expected);
    }
}