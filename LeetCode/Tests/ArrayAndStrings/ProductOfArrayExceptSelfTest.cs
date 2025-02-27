namespace Tests.ArrayAndStrings;

[TestFixture]
public class ProductOfArrayExceptSelfTest
{
    [TestCase<int[], int[]>([1,2,3,4], [24,12,8,6])]
    [TestCase<int[], int[]>([-1,1,0,-3,3], [0,0,9,0,0])]
    public void Test(int[] nums, int[] expected)
    {
        // Arrange
        var solution = new ProductOfArrayExceptSelf();
        
        // Act
        var result = solution.ProductExceptSelf(nums);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }
}