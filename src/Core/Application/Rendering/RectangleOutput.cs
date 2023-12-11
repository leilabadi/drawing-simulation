using DrawingSimulation.Core.Domain.Model;

namespace DrawingSimulation.Core.Application.Rendering;

public class RectangleOutput : WidgetOutput
{
    private readonly Rectangle rectangle;

    public RectangleOutput(Rectangle rectangle)
    {
        this.rectangle = rectangle;
    }

    public override string GenerateOutput()
    {
        return $"Rectangle ({rectangle.Location.X},{rectangle.Location.Y}) width={rectangle.Width} height={rectangle.Height}";
    }
}