namespace LeetCode.BinaryTree;

public class PathSumIII
{
    public int PathSum(TreeNode root, int targetSum)
    {
        var prefixSum = new Dictionary<long, int>();
        prefixSum.TryAdd(0, 1);
        return DFS(root, targetSum, 0, prefixSum);
    }

    private int DFS(TreeNode? root, int targetSum, long currentSum, Dictionary<long, int> prefixSum)
    {
        if (root == null) return 0;

        currentSum += root.val;

        var count = prefixSum.GetValueOrDefault(currentSum - targetSum, 0);

        if (!prefixSum.TryAdd(currentSum, 1))
            prefixSum[currentSum]++;

        count += DFS(root.left, targetSum, currentSum, prefixSum);
        count += DFS(root.right, targetSum, currentSum, prefixSum);

        prefixSum[currentSum]--;
        if (prefixSum[currentSum] == 0)
            prefixSum.Remove(currentSum);

        return count;
    }
}