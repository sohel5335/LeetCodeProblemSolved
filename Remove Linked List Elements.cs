/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
    public ListNode RemoveElements(ListNode head, int val)
    {
        ListNode dummy = new ListNode(0, head);
        ListNode prv = dummy, cur = head;
        while (cur != null)
        {
            if (cur.val == val)
            {
                prv.next = cur.next;
            }
            else
            {
                prv = cur;
            }
            cur = cur.next;
        }


        return dummy.next;
    }
}