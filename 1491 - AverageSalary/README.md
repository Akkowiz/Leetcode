**[Link to the task](https://leetcode.com/problems/average-salary-excluding-the-minimum-and-maximum-salary/description/)**

## Description

You are given an array of unique integers salary where salary[i] is the salary of the ith employee.

Return the average salary of employees excluding the minimum and maximum salary. Answers within 10-5 of the actual answer will be accepted.

Example 1:

Input: salary = [4000,3000,1000,2000]
Output: 2500.00000
Explanation: Minimum salary and maximum salary are 1000 and 4000 respectively.
Average salary excluding minimum and maximum salary is (2000+3000) / 2 = 2500

## Personal Notes

Today I learned that a double-type Result does not save decimals if the opponents are integer. Good to know!
I made a copy of the array but as a list to make removing the min and max very easy to do
