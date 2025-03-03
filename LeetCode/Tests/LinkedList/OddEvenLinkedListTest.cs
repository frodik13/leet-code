namespace Tests.LinkedList;

[TestFixture]
public class OddEvenLinkedListTest
{
    private readonly Dictionary<int, ListNode> _testCase = new()
    {
        { 1, new ListNode(1,
                new ListNode(2,
                    new ListNode(3,
                        new ListNode(4,
                            new ListNode(5)))))},
        { 2, new ListNode(2,
                new ListNode(1,
                    new ListNode(3,
                        new ListNode(5,
                            new ListNode(6,
                                new ListNode(4,
                                    new ListNode(7)))))))}
    };

    private readonly Dictionary<int, ListNode> _answerCase = new()
    {
        { 1, new ListNode(1,
                new ListNode(3,
                    new ListNode(5,
                        new ListNode(2,
                            new ListNode(4)))))},
        { 2, new ListNode(2,
                new ListNode(3,
                    new ListNode(6,
                        new ListNode(7,
                            new ListNode(1,
                                new ListNode(5,
                                    new ListNode(4)))))))}
    };

    [TestCase(1)]
    [TestCase(2)]
    public void Test(int testCase)
    {
        // Arrange
        var solution = new OddEvenLinkedList();
        var head = _testCase[testCase];
        var expected = _answerCase[testCase];

        // Act
        var result = solution.OddEvenList(head);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }
}