using DrawingSimulation.Core.Domain.Model;

namespace DrawingSimulation.Core.Application.Rendering;

public class CircleOutput : WidgetOutput
{
    private readonly Circle circle;

    public CircleOutput(Circle circle)
    {
        this.circle = circle;
    }

    public override string GenerateOutput()
    {
        return $"Circle ({circle.Location.X},{circle.Location.Y}) size={2 * circle.Diameter}";
    }
}