// 13-01-2026
// Leet code - 83
public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode() { }

    public ListNode(int val)
    {
        this.val = val;
    }

    public ListNode(int val, ListNode next)
    {
        this.val = val;
        this.next = next;
    }
}
public class Solution
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head == null)
            return null;

        ListNode temp = head;

        while (temp != null && temp.next != null)
        {
            if (temp.val == temp.next.val)
            {
                temp.next = temp.next.next; // skip duplicate
            }
            else
            {
                temp = temp.next;
            }
        }

        return head;
    }
}
