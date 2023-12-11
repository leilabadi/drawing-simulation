namespace DrawingSimulation.Core.Domain.Model;

public class Rectangle : Widget
{
    public int Width { get; }
    public int Height { get; }

    public Rectangle(int x, int y, int width, int height) : base(x, y)
    {
        Width = width;
        Height = height;
    }
}