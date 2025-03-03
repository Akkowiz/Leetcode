**[Link to the task](https://leetcode.com/problems/to-be-or-not-to-be/description/)**

## Description

Write a function expect that helps developers test their code. It should take in any value val and return an object with the following two functions.

    toBe(val) accepts another value and returns true if the two values === each other. If they are not equal, it should throw an error "Not Equal".
    notToBe(val) accepts another value and returns true if the two values !== each other. If they are equal, it should throw an error "Equal".

Example 1:

Input: func = () => expect(5).toBe(5)
Output: {"value": true}
Explanation: 5 === 5 so this expression returns true.

Example 2:

Input: func = () => expect(5).toBe(null)
Output: {"error": "Not Equal"}
Explanation: 5 !== null so this expression throw the error "Not Equal".

Example 3:

Input: func = () => expect(5).notToBe(null)
Output: {"value": true}
Explanation: 5 !== null so this expression returns true.

## Personal Notes

Not the most performant I bet but it works xD
TIL, with the toBe: and notToBe: declaration I gave the expect function 2 properties via
key-value-pairing (toBe being the key, and the function being the value).
Also, the throw new Error() was new to me
