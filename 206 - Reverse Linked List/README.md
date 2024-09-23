**[Link to the task](https://leetcode.com/problems/reverse-linked-list/description/)**

## Description

Given the head of a singly linked list, reverse the list, and return the reversed list.

Example 1:

![Example 1 Picture](https://assets.leetcode.com/uploads/2021/02/19/rev1ex1.jpg)

Input: head = [1,2,3,4,5]
Output: [5,4,3,2,1]

## Personal Notes

Same as the previous task but instead of sort its reverse.

I made a temporary int List that holds all the values, *reversed* the list and inserted it into a new ListNode that gets returned

I also took a look at other submissions and recreated another approach, which is iterating through the head ListNode, saving these
values but pointing the .next to the previous values, making it reversed too