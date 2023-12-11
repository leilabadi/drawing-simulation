namespace DrawingSimulation.Core.Domain.Model;

public class Circle : Widget
{
    public int Diameter { get; }

    public Circle(Location location, int diameter) : base(location)
    {
        Diameter = diameter;
    }
}