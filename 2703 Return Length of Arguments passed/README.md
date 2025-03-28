**[Link to the task](https://leetcode.com/problems/return-length-of-arguments-passed/description/)**

## Description

Write a function argumentsLength that returns the count of arguments passed to it.

 

Example 1:

Input: args = [5]
Output: 1
Explanation:
argumentsLength(5); // 1

One value was passed to the function so it should return 1.

Example 2:

Input: args = [{}, null, "3"]
Output: 3
Explanation: 
argumentsLength({}, null, "3"); // 3

Three values were passed to the function so it should return 3.

## Personal Notes

While the task was solved in a minute, I did learn about rest parameters. Rest parameter
allows a flexable amount of arguments to be passed and they also are in an array so you
can loop through them, find their length, and so on and so forth
