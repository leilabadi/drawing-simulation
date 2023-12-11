using DrawingSimulation.Core.Domain.Model;

namespace DrawingSimulation.Core.Domain.Interface;

public interface ICircleFactory
{
    Circle CreateCircle(int x, int y, int diameter);
}