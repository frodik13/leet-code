namespace LeetCode.Intervals;

public class NonOverlappingIntervals
{
    public int EraseOverlapIntervals(int[][] intervals)
    {
        var count = 0;
        Array.Sort(intervals, (a, b) => a[1].CompareTo(b[1]));

        var end = intervals[0][1];
        for (var i = 1; i < intervals.Length; i++)
        {
            if (intervals[i][0] < end)
                count++;
            else 
                end = intervals[i][1];
        }

        return count;
    }
}