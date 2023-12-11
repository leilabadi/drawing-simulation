using DrawingSimulation.Core.Domain.Model;

namespace DrawingSimulation.Core.Application.Rendering;

public class SquareOutput : WidgetOutput
{
    private readonly Square square;

    public SquareOutput(Square square)
    {
        this.square = square;
    }

    public override string GenerateOutput()
    {
        return $"Square ({square.Location.X},{square.Location.Y}) size={square.Width}";
    }
}