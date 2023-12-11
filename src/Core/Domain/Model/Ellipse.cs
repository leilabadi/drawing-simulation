namespace DrawingSimulation.Core.Domain.Model;

public class Ellipse : Widget
{
    public int HorizontalDiameter { get; }
    public int VerticalDiameter { get; }

    public Ellipse(int x, int y, int horizontalDiameter, int verticalDiameter) : base(x, y)
    {
        HorizontalDiameter = horizontalDiameter;
        VerticalDiameter = verticalDiameter;
    }
}