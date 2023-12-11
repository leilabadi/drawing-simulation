// See https://aka.ms/new-console-template for more information
using DrawingSimulation.Core.Application;
using DrawingSimulation.Core.Application.Rendering;
using DrawingSimulation.Core.Domain.Interface;

IRenderer renderer = new ConsoleRenderer();
var canvas = new Canvas(renderer);

IRectangleFactory rectangleFactory = new RectangleFactory();
canvas.AddWidget(rectangleFactory.CreateRectangle(10, 10, 30, 40));

ISquareFactory squareFactory = new SquareFactory();
canvas.AddWidget(squareFactory.CreateSquare(15, 30, 35));

IEllipseFactory ellipseFactory = new EllipseFactory();
canvas.AddWidget(ellipseFactory.CreateEllipse(100, 150, 300, 200));

ICircleFactory circleFactory = new CircleFactory();
canvas.AddWidget(circleFactory.CreateCircle(1, 1, 300));

ITextboxFactory textboxFactory = new TextboxFactory();
canvas.AddWidget(textboxFactory.CreateTextbox(5, 5, 200, 100, "sample text"));

// Generate output
canvas.Render();

Console.ReadLine();