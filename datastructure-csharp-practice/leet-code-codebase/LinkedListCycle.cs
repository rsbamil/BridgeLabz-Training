// 16-01-2026
// LC - 141
using System.Collections.Generic;

/**
 * Definition for singly-linked list.
 */
public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int x)
    {
        val = x;
        next = null;
    }
}

public class Solution
{
    public bool HasCycle(ListNode head)
    {
        Dictionary<ListNode, bool> map = new Dictionary<ListNode, bool>();
        ListNode temp = head;

        while (temp != null)
        {
            if (!map.ContainsKey(temp))
            {
                map[temp] = true;
            }
            else
            {
                return true; // cycle detected
            }

            temp = temp.next;
        }

        return false; // no cycle
    }
}
