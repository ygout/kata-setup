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

