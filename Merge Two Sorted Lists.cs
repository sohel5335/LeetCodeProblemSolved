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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)

    {
        ListNode mergeList = new ListNode(0);
        ListNode MergeHead = mergeList;

        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                mergeList.next = list1;
                list1 = list1.next;
            }
            else
            {
                mergeList.next = list2;
                list2 = list2.next;
            }

            mergeList = mergeList.next;
        }
        while (list2 != null)
        {
            mergeList.next = list2;
            list2 = list2.next;
            mergeList = mergeList.next;
        }
        while (list1 != null)
        {
            mergeList.next = list1;
            list1 = list1.next;
            mergeList = mergeList.next;
        }
        return MergeHead.next;
    }
}