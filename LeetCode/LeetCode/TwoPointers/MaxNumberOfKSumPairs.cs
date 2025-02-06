namespace LeetCode.TwoPointers;

public class MaxNumberOfKSumPairs
{
    public int MaxOperationsX(int[] nums, int k)
    {
        var numsList = nums.ToList();
        var index1 = 0;
        var index2 = 1;
        var count = 0;

        while (index1 < numsList.Count)
        {
            var number1 = numsList[index1];
            if (number1 > k)
            {
                numsList.RemoveAt(index1);
                continue;
            }
            
            while (index2 < numsList.Count)
            {
                var number2 = numsList[index2];
                if (number2 > k)
                {
                    numsList.RemoveAt(index2);
                    continue;
                }

                if (number2 + number1 == k)
                {
                    numsList.RemoveAt(index1);
                    numsList.RemoveAt(index2 - 1);
                    index1 = -1;
                    count++;
                    break;
                }

                index2++;
            }

            index1++;
            index2 = index1 + 1;

        }

        return count;
    }

    public int MaxOperations(int[] nums, int k)
    {
        Array.Sort(nums);

        var count = 0;
        var left = 0;
        var right = nums.Length - 1;
        while (left < right)
        {
            var sum = nums[left] + nums[right];

            if (sum > k)
                right--;
            else if (sum < k)
                left++;
            else
            {
                count++;
                left++;
                right--;
            }
        }

        return count;
    }
}