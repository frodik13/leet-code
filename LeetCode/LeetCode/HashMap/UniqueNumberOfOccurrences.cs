namespace LeetCode.HashMap;

public class UniqueNumberOfOccurrences
{
    public bool UniqueOccurrences(int[] arr)
    {
        Dictionary<int, int> map = [];

        foreach (var i in arr)
        {
            map.TryAdd(i, 0);
            map[i]++;
        }

        HashSet<int> hashSet = [..map.Values];
        return hashSet.Count == map.Count;
    }
}