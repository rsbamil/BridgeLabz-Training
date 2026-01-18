// 15-01-2026
// LC - 206
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
    public ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        ListNode curr = head;
        ListNode next = null;

        while (curr != null)
        {
            next = curr.next;   // store next
            curr.next = prev;   // reverse link
            prev = curr;        // move prev
            curr = next;        // move curr
        }

        return prev; // new head
    }
}
