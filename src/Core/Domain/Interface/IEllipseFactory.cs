using DrawingSimulation.Core.Domain.Model;

namespace DrawingSimulation.Core.Domain.Interface;

public interface IEllipseFactory
{
    Ellipse CreateEllipse(int x, int y, int horizontalDiameter, int verticalDiameter);
}