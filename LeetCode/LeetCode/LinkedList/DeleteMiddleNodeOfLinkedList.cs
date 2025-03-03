namespace LeetCode.LinkedList;

public class DeleteMiddleNodeOfLinkedList
{
    public ListNode DeleteMiddle(ListNode head)
    {
        if (head == null) return null;
        if (head.next == null) return null;

        var fast = head.next?.next;
        var slow = head;

        while (slow != null && fast is { next: not null })
        {
            fast = fast.next.next;
            slow = slow.next;
        }
        
        slow.next = slow.next?.next;
        return head;
    }

    public ListNode DeleteMiddleX(ListNode head)
    {
        if (head == null) return null;
        if (head.next == null) return null;
        var middle = head;
        var next = head.next;
        var middleNodeIndex = 0;
        var nodeCount = 0;
        var temp = head;
        while (temp != null)
        {
            nodeCount++;
            temp = temp.next;
        }
        
        middleNodeIndex = (nodeCount + 1) % 2 == 0 ? nodeCount / 2 : (nodeCount + 1) / 2;
        next = head;
        while (middleNodeIndex > 0)
        {
            middle = next;
            next = next.next;
            middleNodeIndex--;
        }
        
        middle.next = next.next;

        return head;
    }
}