namespace DrawingSimulation.Core.Domain.Model;

public class Rectangle : Widget
{
    public int Width { get; }
    public int Height { get; }

    public Rectangle(int x, int y, int width, int height) : base(x, y)
    {
        if (width <= 0) throw new ArgumentException("Width cannot be negative.", nameof(width));

        if (height <= 0) throw new ArgumentException("Height cannot be negative.", nameof(height));

        Width = width;
        Height = height;
    }
}