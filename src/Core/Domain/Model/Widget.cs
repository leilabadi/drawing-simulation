namespace DrawingSimulation.Core.Domain.Model;

public abstract class Widget
{
    public Location Location { get; }

    public Widget(int x, int y)
    {
        if (x <= 0) throw new ArgumentException("X cannot be negative.", nameof(x));

        if (y <= 0) throw new ArgumentException("Y cannot be negative.", nameof(y));

        Location = new Location(x, y);
    }
}