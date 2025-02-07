namespace Tests.HashMap;

public class FindDifferenceOfTwoArraysTest
{
    private static readonly Dictionary<int, IList<IList<int>>> Answers = new()
    {
        { 1, new List<IList<int>>(){ new List<int>{ 1, 3 }, new List<int>{ 4, 6 } }},
        { 2, new List<IList<int>>(){ new List<int>{ 3 }, new List<int>{}}},
    };


    [TestCase(new[] { 1, 2, 3 }, new[]{ 2, 4, 6 }, 1)]
    [TestCase(new[] { 1, 2, 3, 3 }, new[]{ 1, 1, 2, 2 }, 2)]
    public void Test(int[] nums1, int[] nums2, int indexAnswers)
    {
        // Arrange
        var finder = new FindDifferenceOfTwoArrays();

        // Act
        var result = finder.FindDifference(nums1, nums2);

        // Assert
        result.Should().BeEquivalentTo(Answers[indexAnswers]);
    }
}