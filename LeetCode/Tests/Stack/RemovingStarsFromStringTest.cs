namespace Tests.Stack;

[TestFixture]
public class RemovingStarsFromStringTest
{
    [TestCase("leet**cod*e", "lecoe")]
    [TestCase("erase*****", "")]
    public void Test(string input, string expected)
    {
        // Arrange
        RemovingStarsFromString sut = new(); 
        
        // Act
        var result = sut.RemoveStars(input);

        // Assert
        result.Should().Be(expected);
    }
}