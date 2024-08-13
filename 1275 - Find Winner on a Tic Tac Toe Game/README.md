**[Link to the task](https://leetcode.com/problems/find-winner-on-a-tic-tac-toe-game/description/)**

## Description

Tic-tac-toe is played by two players A and B on a 3 x 3 grid. The rules of Tic-Tac-Toe are:

    - Players take turns placing characters into empty squares ' '.
    - The first player A always places 'X' characters, while the second player B always places 'O' characters.
    - 'X' and 'O' characters are always placed into empty squares, never on filled ones.
    - The game ends when there are three of the same (non-empty) character filling any row, column, or diagonal.
    - The game also ends if all squares are non-empty.
    - No more moves can be played if the game is over.

Given a 2D integer array moves where moves[i] = [row i, col i] indicates that the ith move will be played on grid[rowi][coli]. return the winner of the game if it exists (A or B). In case the game ends in a draw return "Draw". If there are still movements to play return "Pending".

You can assume that moves is valid (i.e., it follows the rules of Tic-Tac-Toe), the grid is initially empty, and A will play first.

## Personal Notes

It works but I want to revisit this task this week since this could be done more pragmatic.

I created a method for checking the winconditions of tictactoe and made 2 stringlists I can use to see 
which fields have been taken by which player.

Update: In the second version (FindWinner2.cs) is less logic involved to check the cases + I could remove the result variable
by simply using return in the appropriate places