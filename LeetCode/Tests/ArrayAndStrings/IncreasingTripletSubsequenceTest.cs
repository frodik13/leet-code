namespace Tests.ArrayAndStrings;

[TestFixture]
public class IncreasingTripletSubsequenceTest
{
    [TestCase<int[], bool>([1,2,3,4,5], true)]
    [TestCase<int[], bool>([5,4,3,2,1], false)]
    [TestCase<int[], bool>([2,1,5,0,4,6], true)]
    [TestCase<int[], bool>([20,100,10,12,5,13], true)]
    public void Test(int[] nums, bool expected)
    {
        // Arrange
        var solution = new IncreasingTripletSubsequence();

        // Act
        var result = solution.IncreasingTriplet(nums);

        // Assert
        result.Should().Be(expected);
    }
}