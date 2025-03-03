namespace Tests.LinkedList;

[TestFixture]
public class MaximumTwinSumTest
{
    private readonly Dictionary<int, ListNode> _testCases = new()
    {
        { 1, new ListNode(5, new ListNode(4, new ListNode(2, new ListNode(1)))) },
        { 2, new ListNode(4, new ListNode(2, new ListNode(2, new ListNode(3)))) },
        { 3, new ListNode(1, new ListNode(100000)) }
    };

    [TestCase(1, 6)]
    [TestCase(2, 7)]
    [TestCase(3, 100001)]
    public void Test(int testCase, int expected)
    {
        // Arrange
        var solution = new MaximumTwinSum();
        var head = _testCases[testCase];

        // Act
        var result = solution.PairSum(head);

        // Assert
        result.Should().Be(expected);
    }
}