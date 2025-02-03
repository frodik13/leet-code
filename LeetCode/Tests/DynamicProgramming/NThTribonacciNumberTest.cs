using FluentAssertions;
using LeetCode.DynamicProgramming;

namespace Tests.DynamicProgramming;

[TestFixture]
public class NThTribonacciNumberTest
{
    [TestCase(4, 4)]
    [TestCase(25, 1389537)]
    public void Test(int input, int expected)
    {
        // Arrange
        NThTribonacciNumber nthTribonacciNumber = new(); 

        // Act
        var result = nthTribonacciNumber.Tribonacci(input);

        // Assert
        result.Should().Be(expected);
    }
}