namespace LeetCode.BinaryTree.Models;

public class TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
{
    public int Val { get; } = val;
    public TreeNode Left { get; } = left;
    public TreeNode Right { get; } = right;
}