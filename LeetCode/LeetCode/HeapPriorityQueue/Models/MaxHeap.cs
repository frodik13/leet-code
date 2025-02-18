namespace LeetCode.HeapPriorityQueue.Models;

public class MaxHeap<T> where T : IComparable<T>
{
    private readonly T[] _heap;
    private int _size = 0;

    public MaxHeap(int capacity)
    {
        _heap = new T[capacity];
    }

    public void Insert(T item)
    {
        _heap[_size] = item;
    }
}