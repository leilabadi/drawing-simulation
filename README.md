# Drawing Simulation

## Code Excercise
This Visual Studio Console application demonstrates SOLID principles by simulating a drawing package. The application supports 5 drawing primitives (widgets):

1. Rectangle
2. Square
3. Ellipse
4. Circle
5. Textbox

### Requirements
- Add widgets to the drawing with location and size/shape specifications.
- Dimensions specified in integer units.
- Widget details:
  - Rectangle: width and height
  - Square: width
  - Ellipse: horizontal and vertical diameter
  - Circle: diameter
  - Textbox: bounding rectangle (text centered within)

### Clarifications
- Positive widths, heights, and diameters.
- Textbox: configure text only (font and alignment not considered).
- No user input handling (hard-coded widgets in Main() method).
- Console application prints current drawing details.
- Include appropriate unit tests with your solution

### Output Example
```plaintext
---------------------------------------------------------------- 
Requested Drawing 
---------------------------------------------------------------- 
Rectangle (10,10) width=30 height=40 
Square (15,30) size=35 
Ellipse (100,150) diameterH = 300 diameterV = 200 
Circle (1,1) size=300 
Textbox (5,5) width=200 height=100 Text="sample text" 
----------------------------------------------------------------
```

---

## Solution Explanation

A Visual Studio Console app that simulates a drawing package. It allows you to add various shapes like rectangles, squares, ellipses, circles, and textboxes to a canvas and render them using a provided renderer.

### Design Decisions

- I have considered OOP, DDD, SOLID, DRY, and KISS principles and tried to follow them as much as possible.

- I created a project structure inline with Hexagonal Architecture. This will allow our domain logic to be independent of the UI and the infrastructure.

- I have created a domain layer that only contains our models and contracts. (DDD)

- I have created a separate class for each widget. This will allow me to add more widgets in the future without changing the existing code. (OCP)

- Because all widgets should have a location property, I have created an abstract base class for them and moved the location property there. (DRY)

- I have created location as a C# record to make it immutable and prevent any accidental changes to it. (DRY)

- Considering that the widget creation logic is quite simple, I didn't create a factory to separate the creation logic. (KISS)

- I could inherit Square class from Rectangle and Circle class from Ellipse, but I didn't do that because it would break Liskov Substitution Principle. (LSP)

- I inherited TextBox from Rectangle and it doesn't break LSP because we can safely use a TextBox instead of a Rectangle, and it will fulfill the Rectangle's contract.

- I have created a Canvas class to hold all the widgets. This will allow us to add more functionality to the canvas in the future without changing the existing code. (OCP)

- The Canvas class has a Render method that takes an IRenderer as a parameter. This will allow us to render the canvas using different renderers in the future without changing the existing code. (OCP)

- I have created an abstract WidgetOutput class which is used by the renderers to output the widgets. This will allow us to add more output types in the future without changing the existing code. (OCP)

- I have created a ConsoleRenderer class that implements IRenderer. This will allow us to render widgets details on the console. This class loops through all the widgets provided by the Canvas and calls their specific logic to render them on the console. (Polymorphism)

### Further Work

- I could add integration tests to make sure objects work together as expected.

- If the widget creation logic becomes complex, I would create a factory to separate the creation logic. (SRP)

- Usually drawing applications have the ability to apply/undo each drawing step. If we wanted to make this app more like an actual drawing application, we could achieve that by using the command pattern. We could create a command for each drawing step and store them in a list. Then we could apply/undo each command.
