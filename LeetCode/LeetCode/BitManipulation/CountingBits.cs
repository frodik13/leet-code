namespace LeetCode.BitManipulation;

public class CountingBits
{
    public int[] CountBits(int n)
    {
        var result = new int[n + 1];

        for (var i = 0; i < n + 1; i++)
        {
            // var binary = Convert.ToString(i, 2).PadLeft(n, '0');
            // var count = binary.Count(c => c == '1');
            // result[i] = count;
            var count = 0;
            for (var j = 31; j >= 0; j--)
            {
                count += (i & (1 << j)) == 0 ? 0 : 1;
            }
            result[i] = count;
        }

        return result;
    }
}