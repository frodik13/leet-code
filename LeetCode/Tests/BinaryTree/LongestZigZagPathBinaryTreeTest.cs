namespace Tests.BinaryTree;

[TestFixture]
public class LongestZigZagPathBinaryTreeTest
{
    private readonly Dictionary<int, TreeNode> _treeCases = new()
    {
        {
            1, new TreeNode(
                val: 1,
                right: new TreeNode(
                    val: 1,
                    left: new TreeNode(1),
                    right: new TreeNode(
                        val: 1,
                        left: new TreeNode(
                            val: 1,
                            right: new TreeNode(1, right: new TreeNode(1))),
                        right: new TreeNode(1))))
        },
        {
            2, new TreeNode(
                val: 1,
                left: new TreeNode(
                    val: 1,
                    right: new TreeNode(
                        val: 1,
                        left: new TreeNode(1, right: new TreeNode(1)),
                        right: new TreeNode(1))),
                right: new TreeNode(1))
        },
        {
            3, new TreeNode(1)
        }
    };

    [TestCase(1, 3)]
    [TestCase(2, 4)]
    [TestCase(3, 0)]
    public void Test(int treeCase, int expected)
    {
        // Arrange
        var solution = new LongestZigZagPathBinaryTree();
        var root = _treeCases[treeCase];

        // Act
        var result = solution.LongestZigZag(root);

        // Assert
        result.Should().Be(expected);
    }
}