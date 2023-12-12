namespace DrawingSimulation.Core.Domain.Model;

public class Square : Widget
{
    public int Width { get; }

    public Square(int x, int y, int width) : base(x, y)
    {
        if (width <= 0) throw new ArgumentException("Width cannot be negative.", nameof(width));

        Width = width;
    }
}