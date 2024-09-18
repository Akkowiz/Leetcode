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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {

        List<int> list3 = new List<int>();
         while (list1 != null || list2 != null) {
            if(list1 != null){
                list3.Add(list1.val);
                list1 = list1.next;
            } 
            if(list2 != null){
                list3.Add(list2.val);
                list2 = list2.next;
            } 
        }

        list3.Sort();

        ListNode temp = new ListNode(69);
        ListNode head = temp;
        foreach(int number in list3)
        {
            temp.next = new ListNode(number);
            temp = temp.next;
        }
        head = head.next;
        return head;
    }
}