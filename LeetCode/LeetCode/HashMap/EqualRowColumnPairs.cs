using LeetCode.Extensions;

namespace LeetCode.HashMap;

public class EqualRowColumnPairs
{
    public int EqualPairs(int[][] grid)
    {
        Dictionary<long, int> columnsHash = [];
        Dictionary<long, int> rowsHash = [];

        List<int[]> rows = [];
        rows.AddRange(grid.Select(_ => new int[grid.Length]));
        
        for (var column = 0; column < grid.Length; column++)
        {
            var columns = new int[grid[0].Length];
            for (var row = 0; row < grid[0].Length; row++)
            {
                columns[row] = grid[column][row];
                rows[row][column] = grid[column][row];
            }

            var hash = columns.GetHashCodeArray();
            columnsHash.TryAdd(hash, 0);
            columnsHash[hash]++;
        }

        foreach (var hash in rows.Select(x => x.GetHashCodeArray()))
        {
            rowsHash.TryAdd(hash, 0);
            rowsHash[hash]++;
        }

        return columnsHash.Where(c => rowsHash.ContainsKey(c.Key)).Sum(c => rowsHash[c.Key] * c.Value);
    }
}