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
    public ListNode DeleteDuplicates(ListNode head) {

        List<int> tempList = new List<int>();

         while (head != null){
            bool containsItem = tempList.Contains(head.val);
            if(!containsItem){
                tempList.Add(head.val);
            } 
            head = head.next;
         }
        tempList.Sort();

        ListNode temp = new ListNode(69);
        ListNode headList = temp;
        foreach(int number in tempList)
        {
            temp.next = new ListNode(number);
            temp = temp.next;
        }
        headList = headList.next;
        return headList;
    }
}