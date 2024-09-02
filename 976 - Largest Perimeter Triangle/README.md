**[Link to the task](https://leetcode.com/problems/largest-perimeter-triangle/description/)**

## Description
Given an integer array nums, return the largest perimeter of a triangle with a non-zero area, formed from three of these lengths. If it is impossible to form any triangle of a non-zero area, return 0.

Example 1:

Input: nums = [2,1,2]
Output: 5
Explanation: You can form a triangle with three side lengths: 1, 2, and 2.

## Personal Notes
To make sure the for loop doesnt go longer than it needs to, I first sort (ascending) and reverse (now descending)
the array. Afterwards its just checking if i+1 and i+2 are bigger than the current i, since the task is asking for the
largest triangle possible.

