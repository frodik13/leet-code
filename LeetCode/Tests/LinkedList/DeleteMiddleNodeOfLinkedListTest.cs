namespace Tests.LinkedList;

[TestFixture]
public class DeleteMiddleNodeOfLinkedListTest
{
    private readonly Dictionary<int, ListNode> _testCases = new()
    {
        { 1, new ListNode(1, new ListNode(3, new ListNode(4, new ListNode(7, new ListNode(1, new ListNode(2, new ListNode(6)))))))},
        { 2, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))))},
        { 3, new ListNode(2, new ListNode(1))},
    };
    
    private readonly Dictionary<int, ListNode> _expectedCase = new()
    {
        { 1, new ListNode(1, new ListNode(3, new ListNode(4, new ListNode(1, new ListNode(2, new ListNode(6))))))},
        { 2, new ListNode(1, new ListNode(2, new ListNode(4)))},
        { 3, new ListNode(2)},
    };
    
    [TestCase(1)]
    [TestCase(2)]
    [TestCase(3)]
    public void Test(int testCase)
    {
        // Arrange
        var solution = new DeleteMiddleNodeOfLinkedList();
        var head = _testCases[testCase];
        var expected = _expectedCase[testCase];

        // Act
        var result = solution.DeleteMiddle(head);

        // Assert
        result.Should().Be(expected);
    }
}