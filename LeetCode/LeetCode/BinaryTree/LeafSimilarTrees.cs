using LeetCode.BinaryTree.Models;

namespace LeetCode.BinaryTree;

public class LeafSimilarTrees
{
    public bool LeafSimilar(TreeNode root1, TreeNode root2)
    {
        var leaves1 = GetLeaves(root1);
        var leaves2 = GetLeaves(root2);

        if (leaves1.Count != leaves2.Count) return false;

        for (var i = 0; i < leaves1.Count; i++)
        {
            if (leaves1[i] != leaves2[i]) return false;
        }

        return true;
    }

    private List<int> GetLeaves(TreeNode root)
    {
        List<int> leaves = [];

        FindLeaves(root, leaves);

        return leaves;
    }

    private void FindLeaves(TreeNode root, List<int> leaves)
    {
        if (root == null) return;

        if (root.left == null && root.right == null)
            leaves.Add(root.val);

        FindLeaves(root.left, leaves);
        FindLeaves(root.right, leaves);
    }
}