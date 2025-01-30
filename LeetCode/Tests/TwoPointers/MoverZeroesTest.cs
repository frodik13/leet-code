using FluentAssertions;
using LeetCode.TwoPointers;

namespace Tests.TwoPointers;

[TestFixture]
public class MoverZeroesTest
{
    private readonly MoverZeroes _moveZeroes = new();

    [TestCase(new int[5] {0, 1, 0, 3, 12}, new int[5] { 1, 3, 12, 0, 0 })]
    [TestCase(new int[1] { 0 }, new int[1] { 0 })]
    [TestCase(new int[10] { 0, 1, 0, 3, 12, 0, 6, 20, 0, 10 }, new int[10] { 1, 3, 12, 6, 20, 10, 0, 0, 0, 0 })]
    public void Test(int[] inputArray, int[] outputArray)
    {
        // Arrange

        // Act
        _moveZeroes.MoveZeroes(inputArray);

        // Assert
        inputArray.Should().BeEquivalentTo(outputArray);
    }
}