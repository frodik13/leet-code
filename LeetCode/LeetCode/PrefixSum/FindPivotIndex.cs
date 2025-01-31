namespace LeetCode.PrefixSum;

public class FindPivotIndex
{
    public int PivotIndex(int[] nums)
    {
        var sumRight = nums.Sum();
        var sumLeft = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            sumRight -= nums[i];

            if (sumRight == sumLeft) return i;

            sumLeft += nums[i];
        }

        return -1;
    }
}