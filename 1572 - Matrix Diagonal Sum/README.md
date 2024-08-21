**[Link to the task](https://leetcode.com/problems/matrix-diagonal-sum/description/)**

## Description

Given a square matrix mat, return the sum of the matrix diagonals.

Only include the sum of all the elements on the primary diagonal and all the elements on the secondary diagonal that are not part of the primary diagonal.

Example 1:

![Example 1 Picture](https://assets.leetcode.com/uploads/2020/08/14/sample_1911.png)

Input: mat = [[1,2,3],
              [4,5,6],
              [7,8,9]]
Output: 25
Explanation: Diagonals sum: 1 + 5 + 9 + 3 + 7 = 25
Notice that element mat[1][1] = 5 is counted only once.

## Personal Notes

The first condition made perfect sense to me, if i and j are the same, add the matrix-element to the result.

With the anti-diagonal i struggled and watched what others did. If i+j = MatrixWidth then add the element to the result.
So for the first row it can only be [0][MaxWidth], for the second [1][MaxWidth-1] and so forth...