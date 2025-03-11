namespace LeetCode.BinaryTree;

public class CountGoodNodesBinaryTree
{
    public int GoodNodes(TreeNode root)
    {
        return CountGoodNodesRecurse(root, root.val);
    }

    private int CountGoodNodesRecurse(TreeNode? root, int maxValue)
    {
        var result = 0;
        if (root == null) return 0;

        if (root.val >= maxValue)
        {
            maxValue = root.val;
            result++;
        }

        result += CountGoodNodesRecurse(root?.left, maxValue);
        result += CountGoodNodesRecurse(root.right, maxValue);

        return result;
    }

    public int GoodNodesStack(TreeNode root)
    {
        var result = 1;
        if (root.left == null && root.right == null) return 1;

        if (root.left != null)
        {
            result += CountGoodNodes(root.left, root.val);
        }

        if (root.right != null)
        {
            result += CountGoodNodes(root.right, root.val);
        }

        return result;
    }

    private int CountGoodNodes(TreeNode root, int maxVal)
    {
        Stack<(TreeNode node, int maxValue)> stack = new();
        var result = 0;
        stack.Push((root, maxVal));
        while (stack.Count > 0)
        {
            var tree = stack.Pop();
            maxVal = tree.maxValue;
            if (maxVal <= tree.node.val)
            {
                result++;
                maxVal = tree.node.val;
            }

            if (tree.node.left != null) stack.Push((tree.node.left, maxVal));
            if (tree.node.right != null) stack.Push((tree.node.right, maxVal));
        }

        return result;
    }
}