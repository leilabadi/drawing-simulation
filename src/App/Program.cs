// See https://aka.ms/new-console-template for more information
using DrawingSimulation.Core.Application.Rendering;
using DrawingSimulation.Core.Domain.Model;

IRenderer renderer = new ConsoleRenderer();
var canvas = new Canvas(renderer);

canvas.AddWidget(new Rectangle(10, 10, 30, 40));
canvas.AddWidget(new Square(15, 30, 35));
canvas.AddWidget(new Ellipse(100, 150, 300, 200));
canvas.AddWidget(new Circle(1, 1, 300));
canvas.AddWidget(new Textbox(5, 5, 200, 100, "sample text"));

// Generate output
canvas.Render();

Console.ReadLine();