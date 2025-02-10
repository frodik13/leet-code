namespace Tests.BinarySearchTree;

[TestFixture]
public class SearchInBinarySearchTreeTest
{
    private readonly Dictionary<int, TreeNode> _testTree = new()
    {
        { 1 , new TreeNode(
            val: 4,
            left: new TreeNode(
                val: 2,
                left: new TreeNode(1),
                right: new TreeNode(3)),
            right: new TreeNode(7))
        },
        { 2, new TreeNode(
            val: 4,
            left: new TreeNode(
                val: 2,
                left: new TreeNode(1),
                right: new TreeNode(3)),
            right: new TreeNode(7))}
    };
    
    private readonly Dictionary<int, TreeNode> _expectedTree = new()
    {
        { 1, new TreeNode(2, new TreeNode(1), new TreeNode(3))},
        { 2, null }
    };
    
    [TestCase(1, 2)]
    [TestCase(2, 5)]
    public void Test(int input, int val)
    {
        // Arrange
        SearchInBinarySearchTree solution = new();
        var root = _testTree[input];
        var expected = _expectedTree[input];
        
        // Act
        var result = solution.SearchBST(root, val);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }
}