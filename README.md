# drawing-simulation
A Visual Studio Console app which simulates a drawing package. 

Design Decisions:

One way we can think about our system is by saying a square is a special kind of rectangle, having the same width and height. 
Similarly, a circle is like a special ellipse with the same features. But this design choice doesn't follow the Liskov Substitution Principle (LSP).

To explain the issue, imagine we have a square inherited from a rectangle. Now, if we try to use a square instead of a rectangle, 
we can't set different values for the rectangle's width and height and this is a break of LSP.

I would use command patter to record each drawing steps. This will give the app the ability to apply/undo each step like an actual drawing application.