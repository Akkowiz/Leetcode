**[Link to the task](https://leetcode.com/problems/spiral-matrix/description/)**

## Description

Given an m x n matrix, return all elements of the matrix in spiral order.

![Example 1 Picture](https://assets.leetcode.com/uploads/2020/11/13/spiral1.jpg)

Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
Output: [1,2,3,6,9,8,7,4,5]

## Personal Notes

I tried to solve this by using the same idea in task 1041, keeping track of the direction and
going in the specific loop for that (switchcases).

Especially in the end I had issues with this task and referred to how others did it,
my biggest issue was figuring out why I kept going out of index-bounds, thats because I did ++ to all
directions, instead of doing -- for the directions that were defined by the sizes of the matrix
    |
    v T++
L-> ++
    --<-R
    ^B--
    |
I will probably revisit this task very soon to make sure I 100% understand it now


