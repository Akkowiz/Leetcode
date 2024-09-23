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
    public ListNode ReverseList(ListNode head) {

    ListNode reverseList = null;

    while(head != null)
    {
        reverseList = new ListNode(head.val, reverseList);
        head = head.next;
    }
    
    return reverseList;
    }
}