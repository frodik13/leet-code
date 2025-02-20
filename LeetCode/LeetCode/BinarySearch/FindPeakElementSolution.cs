namespace LeetCode.BinarySearch;

public class FindPeakElementSolution
{
    public int FindPeakElement(int[] nums)
    {
        var left = 0;
        var right = nums.Length - 1;

        while (left < right)
        {
            var middle = (left + right) / 2;

            if (nums[middle] > nums[middle + 1])
                right = middle;
            else
                left = middle + 1;
        }

        return left;
    }

    public int FindPeakElementY(int[] nums)
    {
        var left = 0;
        var right = nums.Length - 1;

        while (left < right)
        {
            var middle = left + (right - left) / 2;
            if (middle > 0 && nums[middle - 1] > nums[middle])
                right = middle - 1;
            else if (middle < nums.Length - 1 && nums[middle + 1] > nums[middle])
                left = middle + 1;
            else
                return middle;
        }

        return right;
    }

    public int FindPeakElementX(int[] nums)
    {
        var findPeakIndex = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            var left = i == 0 || nums[i - 1] < nums[i];
            var right = i == nums.Length - 1 || nums[i] > nums[i + 1];
            if (!left || !right) continue;
            
            findPeakIndex = i;
            break;
        }

        return findPeakIndex;
    }
}