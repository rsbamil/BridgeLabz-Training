// 27-1-26
// LC-2095
/**
 * Definition for singly-linked list.
 */
public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode() { }

    public ListNode(int val)
    {
        this.val = val;
        this.next = null;
    }

    public ListNode(int val, ListNode next)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode DeleteMiddle(ListNode head)
    {
        return Delete(head);
    }

    private ListNode Delete(ListNode head)
    {
        // Edge case: empty list or single node
        if (head == null || head.next == null)
            return null;

        ListNode temp = head;
        ListNode slow = head;
        ListNode fast = head;
        ListNode prev = null;

        while (fast != null && fast.next != null)
        {
            prev = slow;
            slow = slow.next;
            fast = fast.next.next;
        }

        // Remove middle node
        prev.next = slow.next;
        slow.next = null;

        return temp;
    }
}
