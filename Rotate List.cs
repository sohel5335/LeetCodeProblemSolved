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
    public ListNode RotateRight(ListNode head, int k)
    {
        if (head is null)
            return head;
        int len = 0;
        ListNode cur = head;
        while (cur is not null)
        {
            len++;
            cur = cur.next;
        }
        k = k % len;
        if (k == 0)
            return head;
        ListNode fastHalfHead = head;
        ListNode fasthalfCur = fastHalfHead;
        ListNode secondHalf = null;
        for (int i = 0; i < len - (k + 1); i++)
        {
            fasthalfCur = fasthalfCur.next;

        }
        secondHalf = fasthalfCur.next;
        fasthalfCur.next = null;
        ListNode secondHalfcur = secondHalf;

        while (secondHalfcur.next is not null)
        {
            secondHalfcur = secondHalfcur.next;
        }
        secondHalfcur.next = fastHalfHead;

        return secondHalf;
    }
}