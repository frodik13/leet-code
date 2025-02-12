namespace Tests.ArrayAndStrings;

[TestFixture]
public class KidsWithGreatestNumberOfCandiesTest
{
    [TestCase<int[], int, bool[]>([2,3,5,1,3], 3, [true, true, true, false, true])]
    [TestCase<int[], int, bool[]>([4,2,1,1,2], 1, [true,false,false,false,false])]
    [TestCase<int[], int, bool[]>([12,1,12], 10, [true,false,true])]
    public void Test(int[] candies, int extraCandies, bool[] expectedResult)
    {
        // Arrange
        KidsWithGreatestNumberOfCandies solution = new();
        var expected = expectedResult.ToList();
        
        // Act
        var result = solution.KidsWithCandies(candies, extraCandies);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }
}