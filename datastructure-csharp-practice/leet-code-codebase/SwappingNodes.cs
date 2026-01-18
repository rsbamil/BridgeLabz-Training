// 16-01-2026
// LC - 1721
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
    public ListNode SwapNodes(ListNode head, int k)
    {
        int length = FindLength(head);

        int k1 = k;
        ListNode node1 = head;
        while (k1 > 1)
        {
            node1 = node1.next;
            k1--;
        }

        int k2 = length - k + 1;
        ListNode node2 = head;
        while (k2 > 1)
        {
            node2 = node2.next;
            k2--;
        }

        // Swap values
        int temp = node1.val;
        node1.val = node2.val;
        node2.val = temp;

        return head;
    }

    private int FindLength(ListNode head)
    {
        int length = 0;
        while (head != null)
        {
            head = head.next;
            length++;
        }
        return length;
    }
}
