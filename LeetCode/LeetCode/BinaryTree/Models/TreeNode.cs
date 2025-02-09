namespace LeetCode.BinaryTree.Models;

public class TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
{
    public int val { get; set; } = val;
    public TreeNode left { get; set; } = left;
    public TreeNode right { get; set; } = right;
}