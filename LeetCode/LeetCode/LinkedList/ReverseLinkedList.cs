namespace LeetCode.LinkedList;

public class ReverseLinkedList
{
    public ListNode ReverseListX(ListNode head)
    {
        if (head == null) return null;
        
        List<int> heapValue = [];
        while (head != null)
        {
            heapValue.Add(head.val);
            head = head.next;
        }

        heapValue.Reverse();

        if (heapValue.Count == 1)
        {
            return new ListNode(heapValue[0]);
        }

        var result = new ListNode(heapValue[0]);
        var next = result;
        for (var index = 1; index < heapValue.Count; index++)
        {
            next.next = new ListNode(heapValue[index]);
            next = next.next;
        }

        return result;
    }

    public ListNode ReverseList(ListNode head)
    {
        if (head == null) return head;

        ListNode reverseNode = null;

        while (head != null)
        {
            reverseNode = new ListNode(head.val, reverseNode);
            head = head.next;
        }

        return reverseNode;
    }
}