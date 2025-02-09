namespace LeetCode.LinkedList.Models;

public class ListNode(int val = 0, ListNode next = null)
{
    public int val = val;
    public ListNode next = next;


    public override bool Equals(object? obj)
    {
        if (obj is ListNode listNode)
        {
            if (next != null && listNode.next != null)
            {
                return val == listNode.val && next.Equals(listNode.next);
            }
            else
            {
                return val == listNode.val;
            }
        }

        return false;
    }
}