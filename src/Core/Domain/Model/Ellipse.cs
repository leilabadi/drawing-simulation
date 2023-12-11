namespace DrawingSimulation.Core.Domain.Model;

public class Ellipse : Widget
{
    public int HorizontalDiameter { get; }
    public int VerticalDiameter { get; }

    public Ellipse(Location location, int horizontalDiameter, int verticalDiameter) : base(location)
    {
        HorizontalDiameter = horizontalDiameter;
        VerticalDiameter = verticalDiameter;
    }
}