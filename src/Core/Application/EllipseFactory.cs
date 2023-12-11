using DrawingSimulation.Core.Domain.Interface;
using DrawingSimulation.Core.Domain.Model;

namespace DrawingSimulation.Core.Application;

public class EllipseFactory : IEllipseFactory
{
    public Ellipse CreateEllipse(int x, int y, int horizontalDiameter, int verticalDiameter)
    {
        return new Ellipse(new Location(x, y), horizontalDiameter, verticalDiameter);
    }
}