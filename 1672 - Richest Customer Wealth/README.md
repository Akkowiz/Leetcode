**[Link to the task](https://leetcode.com/problems/richest-customer-wealth/description/)**

## Description

You are given an m x n integer grid accounts where accounts[i][j] is the amount of money the i​​​​​​​​​​​th​​​​ customer has in the j​​​​​​​​​​​th​​​​ bank. Return the wealth that the richest customer has.

A customer's wealth is the amount of money they have in all their bank accounts. The richest customer is the customer that has the maximum wealth.

Example 1:

Input: accounts = [[1,2,3],[3,2,1]]
Output: 6
Explanation:
1st customer has wealth = 1 + 2 + 3 = 6
2nd customer has wealth = 3 + 2 + 1 = 6
Both customers are considered the richest with a wealth of 6 each, so return 6.

## Personal Notes

I solved this issue with a nested loop, in the 2nd iteration I just made 2 variables for the loops because
since the amount of elements in the array are fixed (x amount of banks each person uses/has) I could reuse the
variable instead of having to get the length of the array each time.

But the first version has a bit less memoryspace in return so both versions have an advantage I suppose