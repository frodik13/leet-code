namespace LeetCode.LinkedList;

public class OddEvenLinkedList
{
    public ListNode OddEvenList(ListNode head)
    {
        if (head?.next == null) return head;

        var odd = head;
        var even = head.next;
        var temp = even;

        while (even is { next: not null })
        {
            odd.next = odd.next.next;
            even.next = even.next.next;

            odd = odd.next;
            even = even.next;
        }

        odd.next = temp;

        return head;
    }
}