namespace DrawingSimulation.Core.Domain.Model;

public abstract class Widget
{
    public Location Location { get; }

    public Widget(Location location)
    {
        Location = location;
    }
}