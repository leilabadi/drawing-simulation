namespace DrawingSimulation.Core.Domain.Model;

public class Ellipse : Widget
{
    public int HorizontalDiameter { get; }
    public int VerticalDiameter { get; }

    public Ellipse(int x, int y, int horizontalDiameter, int verticalDiameter) : base(x, y)
    {
        if (horizontalDiameter <= 0) throw new ArgumentException("Horizontal iameter cannot be negative.", nameof(horizontalDiameter));

        if (verticalDiameter <= 0) throw new ArgumentException("Vertical diameter cannot be negative.", nameof(verticalDiameter));

        HorizontalDiameter = horizontalDiameter;
        VerticalDiameter = verticalDiameter;
    }
}