namespace DrawingSimulation.Core.Domain.Model;

public abstract class Widget
{
    public Location Location { get; }

    public Widget(int x, int y)
    {
        Location = new Location(x, y);
    }
}