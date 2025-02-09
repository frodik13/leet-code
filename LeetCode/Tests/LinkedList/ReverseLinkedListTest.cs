using LeetCode.LinkedList.Models;

namespace Tests.LinkedList;

[TestFixture]
public class ReverseLinkedListTest
{
    private readonly Dictionary<int, ListNode> _input = new()
    {
        { 1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))))},
        { 2, new ListNode(1, new ListNode(2))},
        { 3, null }
    };

    private readonly Dictionary<int, ListNode> _expected = new()
    {
        { 1, new ListNode(5, new ListNode(4, new ListNode(3, new ListNode(2, new ListNode(1)))))},
        { 2, new ListNode(2, new ListNode(1))},
        { 3, null }
    };

    [TestCase(1)]
    public void Test(int index)
    {
        // Arrange
        ReverseLinkedList solution = new();
        var head = _input[index];
        var expected = _expected[index];

        // Act
        var result = solution.ReverseList(head);

        // Assert
        result.Should().Be(expected);
    }
}