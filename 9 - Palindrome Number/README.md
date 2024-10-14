**[Link to the task](https://leetcode.com/problems/palindrome-number/description/)**

## Description
Given an integer x, return true if x is a palindrome, and false otherwise.

Example 1:

Input: x = 121
Output: true
Explanation: 121 reads as 121 from left to right and from right to left.

Example 2:

Input: x = -121
Output: false
Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.

Example 3:

Input: x = 10
Output: false
Explanation: Reads 01 from right to left. Therefore it is not a palindrome.

Follow up: Could you solve it without converting the integer to a string?

## Personal Notes

No string needed thanks to the cool while loop. The while loop first takes the first digit
with help of the modulo % 10 operation. In the  next line it saves that into the reversed X variable
and if reverseX already has a value, make it x10 beforehand. The last line divides the temporary x placeholder
by 10 to make sure that the loop eventually ends.


