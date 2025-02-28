namespace LeetCode.TwoPointers;

public class ContainerWithMostWater
{
    public int MaxArea(int[] height)
    {
        var left = 0;
        var right = height.Length - 1;
        var maxArea = 0;

        while (left < right)
        {
            var currentArea = Math.Min(height[left], height[right]) * (right - left);
            if (currentArea > maxArea)
                maxArea = currentArea;

            if (height[left] > height[right])
                right--;
            else
                left++;
        }

        return maxArea;
    }
}