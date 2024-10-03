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

        l1 = ReverseList(l1);
        l2 = ReverseList(l2);
        
        // ==================================

        ListNode dummylist = new ListNode();
        ListNode l3 = dummylist;
        int carry = 0;

        while(l1 != null || l2 != null || carry > 0){

            int l3Current = carry;

            if (l1 != null){
                    l3Current += l1.val;
                    l1 = l1.next; 
                }
            
            if (l2 != null){
                l3Current += l2.val;
                l2 = l2.next; 
            }
                
            carry = l3Current / 10;
            l3.next = new ListNode(l3Current % 10);
            l3 = l3.next;
            
        }
        return ReverseList(dummylist.next);
    }

    static ListNode ReverseList(ListNode List){
      ListNode reverseList = null;

        while(List != null){
            reverseList = new ListNode(List.val, reverseList);
            List = List.next;
        }
    return reverseList;
    }
}
