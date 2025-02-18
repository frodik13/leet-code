namespace LeetCode.HeapPriorityQueue;

public class KthLargestElementInArray
{
    public int FindKthLargest(int[] nums, int k)
    {
        var heap = new PriorityQueue<int,int>(k);
        for (var i = 0; i < k; i++)
        {
            heap.Enqueue(nums[i], nums[i]);
        }

        for (var i = k; i < nums.Length; i++)
        {
            if (nums[i] <= heap.Peek()) continue;
            heap.Dequeue();
            heap.Enqueue(nums[i], nums[i]);
        }

        return heap.Dequeue();
    }
}