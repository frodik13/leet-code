namespace Tests.BinaryTree;

[TestFixture]
public class LeafSimilarTreesTest
{
    private readonly Dictionary<int, TreeNode> _treeNodes = new()
    {
        { 1, new TreeNode(
            val: 3,
            left: new TreeNode(
                val: 5,
                left: new TreeNode(6),
                right: new TreeNode(
                    val: 2,
                    left: new TreeNode(7),
                    right: new TreeNode(4))),
            right: new TreeNode(
                val: 1,
                left: new TreeNode(9),
                right: new TreeNode(8)))
        },
        { 2, new TreeNode(
            val: 3,
            left: new TreeNode(
                val: 5,
                left: new TreeNode(6),
                right: new TreeNode(7)),
            right: new TreeNode(
                val: 1,
                left: new TreeNode(4),
                right: new TreeNode(
                    val: 2,
                    left: new TreeNode(9),
                    right: new TreeNode(8))))
        },
        { 3, new TreeNode(1, new TreeNode(2), new TreeNode(3))},
        { 4, new TreeNode(1, new TreeNode(3), new TreeNode(2))},
        { 5, new TreeNode(1, new TreeNode(2))},
        { 6, new TreeNode(2, new TreeNode(2))},
    };

    [TestCase(1, 2, true)]
    [TestCase(3, 4, false)]
    [TestCase(5, 6, true)]
    public void Test(int root1Index, int root2Index, bool expected)
    {
        // Arrange
        LeafSimilarTrees solution = new();
        var root1 = _treeNodes[root1Index];
        var root2 = _treeNodes[root2Index];

        // Act
        var result = solution.LeafSimilar(root1, root2);

        // Assert
        result.Should().Be(expected);
    }
}