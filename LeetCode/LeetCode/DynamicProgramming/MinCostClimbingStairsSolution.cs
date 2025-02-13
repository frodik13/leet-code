namespace LeetCode.DynamicProgramming;

public class MinCostClimbingStairsSolution
{
    public int MinCostClimbingStairsX(int[] cost)
    {
        if (cost.Length < 3) return Math.Min(cost[0], cost[1]);

        for (var i = 2; i < cost.Length; i++)
            cost[i] += Math.Min(cost[i - 1], cost[i - 2]);
        
        return Math.Min(cost[^1], cost[^2]);
    }
    
    public int MinCostClimbingStairs(int[] cost)
    {
        var cost1 = cost[^1];
        var cost0 = cost[^2];

        for (var i = cost.Length - 3; i >= 0; i--)
        {
            var temp = cost0;
            cost0 = cost[i] + (cost0 <= cost1 ? cost0 : cost1);
            cost1 = temp;
        }
        
        return cost0 <= cost1 ? cost0 : cost1;
    }
}