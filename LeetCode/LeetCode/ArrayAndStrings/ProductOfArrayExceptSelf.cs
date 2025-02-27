namespace LeetCode.ArrayAndStrings;

public class ProductOfArrayExceptSelf
{
    public int[] ProductExceptSelf(int[] nums)
    {
        var answer = new int[nums.Length];
        var prefix = 1;
        for (var i = 0; i < nums.Length; i++)
        {
            answer[i] = prefix;
            prefix *= nums[i];
        }
        var suffix = 1;
        for (var i = nums.Length - 1; i >= 0; i--)
        {
            answer[i] *= suffix;
            suffix *= nums[i];
        }

        return answer;
    }
    public int[] ProductExceptSelfX(int[] nums)
    {
        var answer = new int[nums.Length];
        var prefix = new int[nums.Length];
        var suffix = new int[nums.Length];
        suffix[^1] = 1;
        prefix[0] = 1;
        
        for (var i = 1; i < nums.Length; i++)
            prefix[i] = prefix[i - 1] * nums[i - 1];

        for (var i = nums.Length - 2; i >= 0; i--)
            suffix[i] = suffix[i + 1] * nums[i + 1];
        

        for (var i = 0; i < answer.Length; i++)
            answer[i] = prefix[i] * suffix[i];
        
        return answer;
    }
}