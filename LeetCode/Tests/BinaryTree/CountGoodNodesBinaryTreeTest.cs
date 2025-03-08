namespace Tests.BinaryTree;

[TestFixture]
public class CountGoodNodesBinaryTreeTest
{
    private readonly Dictionary<int, TreeNode> _testCases = new()
    {
        {
            1, new TreeNode(
                val: 3,
                left: new TreeNode(
                    val: 1, left: new TreeNode(3)),
                right: new TreeNode(
                    val: 4,
                    left: new TreeNode(1),
                    right: new TreeNode(5)))
        },
        {
            2, new TreeNode(
                val: 3,
                left: new TreeNode(
                    val: 3,
                    left: new TreeNode(4),
                    right: new TreeNode(2)))
        },
        { 3, new TreeNode(1) },
        {
            4, new TreeNode(
                val: -1,
                left: new TreeNode(
                    val: 5,
                    left: new TreeNode(4),
                    right: new TreeNode(
                        val: 4,
                        left: new TreeNode(-4))),
                right: new TreeNode(
                    val: -2,
                    left: new TreeNode(
                        val: 2,
                        left: new TreeNode(-2, new TreeNode(-1)),
                        right: new TreeNode(3, new TreeNode(-3))),
                    right: new TreeNode(
                        val: -2,
                        right: new TreeNode(
                            val: -2,
                            left: new TreeNode(-4),
                            right: new TreeNode(-3, new TreeNode(3), new TreeNode(-3))))))
        }
    };

    [TestCase(1, 4)]
    [TestCase(2, 3)]
    [TestCase(3, 1)]
    [TestCase(4, 5)]
    public void Test(int testCase, int expected)
    {
        // Arrange
        var solution = new CountGoodNodesBinaryTree();
        var root = _testCases[testCase];

        // Act
        var result = solution.GoodNodes(root);

        // Assert
        result.Should().Be(expected);
    }
}