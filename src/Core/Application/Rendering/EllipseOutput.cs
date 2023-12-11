using DrawingSimulation.Core.Domain.Model;

namespace DrawingSimulation.Core.Application.Rendering;

public class EllipseOutput : WidgetOutput
{
    private readonly Ellipse ellipse;

    public EllipseOutput(Ellipse ellipse)
    {
        this.ellipse = ellipse;
    }

    public override string GenerateOutput()
    {
        return $"Ellipse ({ellipse.Location.X},{ellipse.Location.Y}) diameterH = {ellipse.HorizontalDiameter} diameterV = {ellipse.VerticalDiameter}";
    }
}