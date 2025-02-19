namespace Tests.ArrayAndStrings;

[TestFixture]
public class CanPlaceFlowersTest
{
    [TestCase<int[],int,bool>([1,0,0,0,1], 1, true)]
    [TestCase<int[],int,bool>([1,0,0,0,1], 2, false)]
    [TestCase<int[],int,bool>([1,0,0,0,1,0,1,0,0,0,1], 2, true)]
    [TestCase<int[],int,bool>([1,0,0,0,1,0,1,0,0,0,1], 3, false)]
    [TestCase<int[],int,bool>([1,0,0,0,0,1], 2, false)]
    [TestCase<int[],int,bool>([1,0,0,0,1], 2, false)]
    [TestCase<int[],int,bool>([0,0,1,0,0], 1, true)]
    [TestCase<int[],int,bool>([1], 0, true)]
    [TestCase<int[],int,bool>([0], 1, true)]
    [TestCase<int[],int,bool>([1], 1, false)]
    [TestCase<int[],int,bool>([0], 0, true)]
    public void Test(int[] flowerbed, int n, bool expected)
    {
        // Arrange
        CanPlaceFlowersSolution solution = new();

        // Act
        var result = solution.CanPlaceFlowers(flowerbed, n);

        // Assert
        result.Should().Be(expected);
    }
}