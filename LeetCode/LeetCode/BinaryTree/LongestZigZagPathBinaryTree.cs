namespace LeetCode.BinaryTree;

public class LongestZigZagPathBinaryTree
{
    private int _max;

    public int LongestZigZag(TreeNode root)
    {
        DFS(root, 0, 0);
        return _max;
    }

    private void DFS(TreeNode node, int left, int right)
    {
        _max = Math.Max(_max, left);
        _max = Math.Max(_max, right);

        if (node.left != null)
        {
            DFS(node.left, right + 1, 0);
        }

        if (node.right != null)
        {
            DFS(node.right, 0, left + 1);
        }
    }
}