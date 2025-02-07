namespace Tests.BinaryTree;

[TestFixture]
public class MaximumDepthBinaryTreeTest
{
    private static readonly Dictionary<int, TreeNode> Input = new()
    {
        { 
            1, new TreeNode(
                val: 3,
                left: new TreeNode(9),
                right: new TreeNode(
                    val: 20,
                    left: new TreeNode(15),
                    right: new TreeNode(7)))},
        {
            2, new TreeNode(
                val: 1, 
                right: new TreeNode(2))
        },
        {
            3, new TreeNode(
                val: 1, 
                left: new TreeNode(
                    val: 5, 
                    left: new TreeNode(7),
                    right: new TreeNode(
                        val: 10,
                        right: new TreeNode(15))),
                right: new TreeNode(
                    val: 8,
                    right: new TreeNode(
                        val: 20,
                        right: new TreeNode(
                            val: 30,
                            left: new TreeNode(60)))))
        }
    };

    [TestCase(1, 3)]
    [TestCase(2, 2)]
    [TestCase(3, 5)]
    public void Test(int input, int answer)
    {
        // Arrange
        MaximumDepthBinaryTree maximumDepthBinaryTree = new();
        var root = Input[input];

        // Act
        var result = maximumDepthBinaryTree.MaxDepth(root);

        // Assert
        result.Should().Be(answer);
    }
}