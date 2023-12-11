namespace DrawingSimulation.Core.Domain.Model;

public class Square : Widget
{
    public int Width { get; }

    public Square(Location location, int width) : base(location)
    {
        Width = width;
    }
}