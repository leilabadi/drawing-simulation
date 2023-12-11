namespace DrawingSimulation.Core.Domain.Model;

public class Rectangle : Widget
{
    public int Width { get; }
    public int Height { get; }

    public Rectangle(Location location, int width, int height) : base(location)
    {
        Width = width;
        Height = height;
    }
}