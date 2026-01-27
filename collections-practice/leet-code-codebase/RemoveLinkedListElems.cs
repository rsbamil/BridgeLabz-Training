// 27-1-26
// LC-203
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
    public ListNode RemoveElements(ListNode head, int val)
    {
        if (head == null)
            return null;

        // Remove matching nodes from the beginning
        while (head != null && head.val == val)
        {
            head = head.next;
        }

        ListNode temp = head;

        // Remove matching nodes from the rest of the list
        while (head != null && head.next != null)
        {
            if (head.next.val == val)
            {
                head.next = head.next.next;
            }
            else
            {
                head = head.next;
            }
        }

        return temp;
    }
}
