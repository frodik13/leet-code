using FluentAssertions;
using LeetCode.PrefixSum;

namespace Tests.PrefixSum;

[TestFixture]
public class FindHighestAltitudeTest
{
    [TestCase(new[]{ -5, 1, 5, 0, -7 }, 1)]
    [TestCase(new[]{ -4, -3, -2, -1, 4, 3, 2 }, 0)]
    public void Test(int[] gain, int highestAltitude)
    {
        // Arrange
        var findHighestAltitude = new FindHighestAltitude();

        // Act
        var result = findHighestAltitude.LargestAltitude(gain);

        // Assert
        result.Should().Be(highestAltitude);
    }
}