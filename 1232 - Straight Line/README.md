**[Link to the task](https://leetcode.com/problems/check-if-it-is-a-straight-line/description/)**

## Description

You are given an array coordinates, coordinates[i] = [x, y], where [x, y] represents the coordinate of a point. Check if these points make a straight line in the XY plane.

Example 1:

![Example 1 Picture](https://assets.leetcode.com/uploads/2019/10/15/untitled-diagram-2.jpg)

Input: coordinates = [[1,2],[2,3],[3,4],[4,5],[5,6],[6,7]]
Output: true

Example 2:

![Example 1 Picture](https://assets.leetcode.com/uploads/2019/10/09/untitled-diagram-1.jpg)

Input: coordinates = [[1,1],[2,2],[3,4],[4,5],[5,6],[7,7]]
Output: false

## Personal Notes

I made a Draft.cs because my first approach failed. It didnt cover the cases of if the line moves like y+1, y+2, which
is still a straight line since x didnt change. It also didnt cover cases like if the % Angle was still the same but with a different distance

The solution was calculating and comparing the % angle, 
(y1-y0) / (x1-x0) == (y2-y0) / (x2-x0)

To avoid dividing by 0, cross-multiplication makes comparing the % Angle a bit easier,
(yi​-y1​) * (x1​-x0​) == (y1​-y0​) * (xi​-x1​)