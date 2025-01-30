namespace LeetCode.TwoPointers;

public class MoverZeroes
{
    public void MoveZeroes(int[] nums)
    {
        var indexNonZero = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0) continue;

            (nums[i], nums[indexNonZero]) = (nums[indexNonZero], nums[i]);
            indexNonZero++;
        }
    }
}