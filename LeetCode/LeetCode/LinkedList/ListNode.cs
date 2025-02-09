namespace LeetCode.LinkedList;

public class ListNode(int val = 0, ListNode next = null)
{
    public int val = val;
    public ListNode next = next;


    public override bool Equals(object? obj)
    {
        if (obj is ListNode listNode)
        {
            return val == listNode.val && next.Equals(listNode.next);
        }

        return false;
    }
}