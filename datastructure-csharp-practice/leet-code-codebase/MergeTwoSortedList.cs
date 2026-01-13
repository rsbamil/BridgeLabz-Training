// 13-01-2026
// Leet code - 21
public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
public class Solution
{
    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        ListNode dummy = new ListNode(-1);
        ListNode temp = dummy;

        while (l1 != null && l2 != null)
        {
            if (l1.val < l2.val)
            {
                dummy.next = l1;
                l1 = l1.next;
            }
            else
            {
                dummy.next = l2;
                l2 = l2.next;
            }
            dummy = dummy.next;
        }

        // Attach remaining nodes
        if (l1 != null)
            dummy.next = l1;

        if (l2 != null)
            dummy.next = l2;

        return temp.next;
    }
}
