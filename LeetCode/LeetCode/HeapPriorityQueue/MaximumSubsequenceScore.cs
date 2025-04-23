namespace LeetCode.HeapPriorityQueue;

public class MaximumSubsequenceScore
{
    public long MaxScore(int[] nums1, int[] nums2, int k)
    {
        var n = nums1.Length;
        var ess = new int[n][];
        for (var i = 0; i < n; i++)
            ess[i] = [nums2[i], nums1[i]];
        
        Array.Sort(ess, (x, y) => y[0] - x[0]);
        
        var heap = new PriorityQueue<int, int>();

        long result = 0;
        long score = 0;

        foreach (var es in ess)
        {
            heap.Enqueue(es[1], es[1]);
            score += es[1];

            if (heap.Count > k)
            {
                score -= heap.Dequeue();
            }
            if (heap.Count == k)
                result = Math.Max(result, score * es[0]);
        }

        return result;
    }
}