namespace LeetCode.SlidingWindow;

public class LongestSubArray1AfterDeletingOneElement
{
    public int LongestSubarrayX(int[] nums)
    {
        var lastZero = -1;

        List<int> counts = [];

        var count = 0;
        for (var i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == 0)
            {
                counts.Add(count);
                lastZero = i;
                count = 0;
            }
            else
            {
                count++;
            }
        }

        if (lastZero == -1)
        {
            return nums.Length - 1;
        }

        if (nums[^1] == 1)
        {
            count++;
        }

        counts.Add(count);

        var maxSum = counts[0] + counts[1];
        var tempSum = maxSum;

        for (var i = 1; i < counts.Count - 1; i++)
        {
            tempSum -= counts[i - 1];
            tempSum += counts[i + 1];
            if (tempSum > maxSum)
            {
                maxSum = tempSum;
            }
        }
        

        return maxSum;
    }

    public int LongestSubarray(int[] nums)
    {
        var current = 0;
        var previous = 0;
        var result = 0;

        //if (nums.All(x => x == 1)) return nums.Length - 1;
        //if (nums.All(x => x == 0)) return 0;

        foreach (var num in nums)
        {
            if (num == 1)
            {
                current++;
            }
            else
            {
                result = Math.Max(result, current + previous);
                previous = current;
                current = 0;
            }
        }

        result = Math.Max(result, current + previous);

        return result == nums.Length ? nums.Length - 1 : result;
    }
}