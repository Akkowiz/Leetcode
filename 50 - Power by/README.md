**[Link to the task](https://leetcode.com/problems/powx-n/description/)**

## Description

Implement pow(x, n), which calculates x raised to the power n (i.e., xn).
 
Example 1:

Input: x = 2.00000, n = 10
Output: 1024.00000

Example 2:

Input: x = 2.10000, n = 3
Output: 9.26100

Example 3:

Input: x = 2.00000, n = -2
Output: 0.25000
Explanation: 2-2 = 1/22 = 1/4 = 0.25

## Personal Notes

As of right now, my draft exceeds the timelimit. The solution i will be going for is exponential
squaring but I am still trying to wrap my head around what or how it works before I use it

Update: It works now, the main getaway is instead of base x (original base) x (original base),
exponential squaring does base x (new base) x (new base), while cutting n short by / 2 each time to make sure the amount of
iterations are still right. 
However, Math.Pow(x, n) is still the way to go I think...