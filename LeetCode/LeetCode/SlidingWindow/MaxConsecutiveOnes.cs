namespace LeetCode.SlidingWindow;

public class MaxConsecutiveOnes
{
    public int LongestOnes(int[] nums, int k)
    {
        var i = 0;
        int j;
        for (j = 0; j < nums.Length; ++j)
        {
            if (nums[j] == 0) k--;
            if (k < 0 && nums[i++] == 0) k++;
        }

        return j - i;
    }
}