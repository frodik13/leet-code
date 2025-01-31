using System.Diagnostics;

namespace LeetCode.SlidingWindow;

public class MaximumAverageSubarray
{
    public double FindMaxAverage(int[] nums, int k)
    {
        var tempSum = 0;
        for (var i = 0; i < k; i++)
            tempSum += nums[i];

        var maxSum = tempSum;

        for (var i = 1; i < nums.Length - k + 1; i++)
        {
            tempSum -= nums[i - 1];
            tempSum += nums[i + k - 1];
            
            if (tempSum > maxSum)
                maxSum = tempSum;
        }

        return maxSum / (double)k;
    }
}