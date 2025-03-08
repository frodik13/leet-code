namespace LeetCode.BinaryTree.Models;

public class TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
{
    public int val { get; set; } = val;
    public TreeNode? left { get; set; } = left;
    public TreeNode? right { get; set; } = right;

    public override bool Equals(object? obj)
    {
        if (obj is not TreeNode treeNode) return false;

        var resultVal = val == treeNode.val;
        if (resultVal == false) return false;

        var resultRight = false;
        if (right is null && treeNode.right is null) resultRight = true;
        else if (right is not null && treeNode.right is null) resultRight = false;
        else if (right is null && treeNode.right is not null) resultRight = false;
        else resultRight = right.Equals(treeNode.right);

        if (resultRight == false) return false;

        var resultLeft = false;
        if (left is null && treeNode.left is null) resultLeft = true;
        else if (left is not null && treeNode.left is null) resultLeft = false;
        else if (left is null && treeNode.left is not null) resultLeft = false;
        else resultLeft = left.Equals(treeNode.left);

        return resultLeft;
    }
}