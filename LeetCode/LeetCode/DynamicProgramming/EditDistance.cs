namespace LeetCode.DynamicProgramming;

public class EditDistance
{
    public int MinDistance(string word1, string word2)
    {
        if (word1.Length == 0 && word2.Length == 0) return 0;
        if (word1.Length == 0) return word2.Length;
        if (word2.Length == 0) return word1.Length;

        var m = word1.Length;
        var n = word2.Length;

        var table = new int[m + 1, n + 1];
        for (var i = 0; i <= m; i++)
            table[i, 0] = i;

        for (var i = 0; i <= n; i++)
            table[0, i] = i;

        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                if (word1[i] == word2[j])
                    table[i + 1, j+ 1] = Math.Min(table[i,j], Math.Min(table[i, j+ 1] + 1, table[i + 1, j] + 1));
                else
                    table[i +1, j+ 1] = Math.Min(table[i, j], Math.Min(table[i, j + 1], table[i +1, j])) + 1;
            }
        }

        return table[m,n];
    }
}