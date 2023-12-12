namespace DrawingSimulation.Core.Domain.Model;

public class Circle : Widget
{
    public int Diameter { get; }

    public Circle(int x, int y, int diameter) : base(x, y)
    {
        if (diameter <= 0) throw new ArgumentException("Diameter cannot be negative.", nameof(diameter));

        Diameter = diameter;
    }
}