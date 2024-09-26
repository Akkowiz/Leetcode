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
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {

        ListNode sumList = new ListNode();
        ListNode current = sumList;
        int carryOver = 0;

        while(l1 != null || l2 != null)
        {
            int currentl1 = (l1 != null) ? l1.val : 0;
            int currentl2 = (l2 != null) ? l2.val : 0;
            int Result = currentl1 + currentl2 + carryOver;

            carryOver = Result / 10;
            Result %= 10;

            current.next = new ListNode(Result);
            current = current.next;

            if (l1 != null) l1 = l1.next;
            if (l2 != null) l2 = l2.next;
        }

        if (carryOver > 0) {
            current.next = new ListNode(carryOver);
        }

        return sumList.next;
    }
}

