namespace Tests.BinaryTree;

[TestFixture]
public class PathSumIIITest
{
    private readonly Dictionary<int, TreeNode> _treeCases = new()
    {
        {
            1, new TreeNode(
                val: 10,
                left: new TreeNode(
                    val: 5,
                    left: new TreeNode(
                        val: 3,
                        left: new TreeNode(3),
                        right: new TreeNode(-2)),
                    right: new TreeNode(2, right: new TreeNode(1))),
                right: new TreeNode(-3, right: new TreeNode(11)))
        },
        {
            2, new TreeNode(
                val: 5,
                left: new TreeNode(
                    val: 4,
                    left: new TreeNode(11, new TreeNode(7), new TreeNode(2))),
                right: new TreeNode(
                    val: 8,
                    left: new TreeNode(13),
                    right: new TreeNode(4, new TreeNode(5), new TreeNode(1))))
        },
        {
            3, new TreeNode(
                val: 1000000000,
                left: new TreeNode(
                    val: 1000000000,
                    left: new TreeNode(
                        val: 294967296,
                        left: new TreeNode(
                            val: 1000000000,
                            left: new TreeNode(
                                val: 1000000000,
                                left: new TreeNode(1000000000))))))
        }
    };

    [TestCase(1, 8, 3)]
    [TestCase(2, 22, 3)]
    [TestCase(3, 0, 0)]
    public void Test(int treeCase, int targetSum, int expected)
    {
        // Arrange
        var solution = new PathSumIII();
        var root = _treeCases[treeCase];

        // Act
        var result = solution.PathSum(root, targetSum);

        // Assert
        result.Should().Be(expected);
    }
}