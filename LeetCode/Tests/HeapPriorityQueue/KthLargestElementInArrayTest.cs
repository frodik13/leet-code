namespace Tests.HeapPriorityQueue;
[TestFixture]
public class KthLargestElementInArrayTest
{
    [TestCase<int[],int,int>([3,2,1,5,6,4], 2, 5)]
    [TestCase<int[],int,int>([3,2,3,1,2,4,5,5,6], 4, 4)]
    [TestCase<int[],int,int>([-1,2,0], 1, 2)]
    public void Test(int[] nums, int k, int expected)
    {
        // Arrange
        KthLargestElementInArray solution = new();
        
        // Act
        var result = solution.FindKthLargest(nums, k);

        // Assert
        result.Should().Be(expected);
    }
}