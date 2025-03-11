namespace LeetCode.BinarySearchTree;

public class SearchInBinarySearchTree
{
    public TreeNode SearchBST(TreeNode root, int val)
    {
        TreeNode result = null;
        
        FindNode(root, val, ref result);
            
        return result;
    }

    private void FindNode(TreeNode root, int val, ref TreeNode? result)
    {
        if (root == null) return;
        if (root.val == val)
        {
            result = root;
            return;
        }
        
        FindNode(root.left, val, ref result);
        FindNode(root.right, val, ref result);
        
    }
}