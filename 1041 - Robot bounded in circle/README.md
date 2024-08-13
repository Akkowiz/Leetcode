**[Link to the task](https://leetcode.com/problems/robot-bounded-in-circle/description/)**

## Description

On an infinite plane, a robot initially stands at (0, 0) and faces north. Note that:

    The north direction is the positive direction of the y-axis.
    The south direction is the negative direction of the y-axis.
    The east direction is the positive direction of the x-axis.
    The west direction is the negative direction of the x-axis.

The robot can receive one of three instructions:

    "G": go straight 1 unit.
    "L": turn 90 degrees to the left (i.e., anti-clockwise direction).
    "R": turn 90 degrees to the right (i.e., clockwise direction).

The robot performs the instructions given in order, and repeats them forever.

Return true if and only if there exists a circle in the plane such that the robot never leaves the circle.

## Personal Notes

The second condition that determines if the robot will return to 0 tripped me up a bit,
but it does make sense, since the robot needs to be on a different direction than north the end to
have a chance of making it a finite loop.

