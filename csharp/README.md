# Brutal Mars Rover

## Constaint: Brutal Constraints

Rules

1. No Conditionals
1. No Loops
1. TTDaiymi 
1. No Naked Primitives
1. No void
1. Immutable

added

* readable tests
* BugsZero type safety

https://blog.code-cop.org/2015/08/introducing-brutal-coding-constraints.html

## Kata: Mars Rover

http://kata-log.rocks/mars-rover-kata

* You are given the initial starting point (x,y) of a rover and the direction (N,S,E,W) it is facing.
* The rover receives a character array of commands.
* Implement commands that move the rover forward/backward (f,b).
* Implement commands that turn the rover left/right (l,r).
* Implement wrapping from one edge of the grid to another. (planets are spheres after all)
* Implement obstacle detection before each move to a new square. If a given sequence of commands encounters an obstacle, the rover moves up to the last possible point, aborts the sequence and reports the obstacle.

## Retrospectives

### 8th July

* VS Code has LiveShare. Cool in a way.
* TDDaiymi you make no progress, but then Naked Primitives and we have lots of classes.
* It took some time to create first production code because of TTDaiymi
* We are learning to work together.
* In the end it worked better.
* Liveshare - it is cool to type simultaneously
* Liveshare - saving on both sides is problematic
* Connection sufficient - no technical issues
* Peter guides the context switch
* Maybe figure out why we could not commit is VS Code
* Maybe figure out why Peter could not run tests is VS Code

Open for next

* wrap Direction
* wrap Tuple
* wrap Commands
* delete test which only goes one North
* Curious to see if Command and Direction will have behaviour
* BugZero Rule: can we create illegal Commands?
