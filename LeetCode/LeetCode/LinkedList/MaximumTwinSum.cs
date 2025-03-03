namespace LeetCode.LinkedList;

public class MaximumTwinSum
{
    public int PairSum(ListNode head)
    {
        if (head.next.next == null)
        {
            return head.val + head.next.val;
        }
        var middleNode = GetMiddleNode(head);
        var reverseNode = ReverseListNode(middleNode);
        var maxSum = 0;
        while (reverseNode != null)
        {
            if (maxSum < head.val + reverseNode.val)
            {
                maxSum = head.val + reverseNode.val;
            }

            reverseNode = reverseNode.next;
            head = head.next;
        }

        return maxSum;
    }

    private ListNode GetMiddleNode(ListNode head)
    {
        var fast = head;
        var slow = head;

        while (fast is { next: not null })
        {
            fast = fast.next.next;
            slow = slow.next;
        }

        return slow;
    }

    private ListNode ReverseListNode(ListNode head)
    {
        ListNode reverseListNode = null;
        var currentListNode = head;
        while (currentListNode != null)
        {
            var next = currentListNode.next;
            currentListNode.next = reverseListNode;
            reverseListNode = currentListNode;
            currentListNode = next;
        }
        return reverseListNode;
    }
}