using DrawingSimulation.Core.Domain.Interface;
using DrawingSimulation.Core.Domain.Model;

namespace DrawingSimulation.Core.Application;

public class CircleFactory : ICircleFactory
{
    public Circle CreateCircle(int x, int y, int diameter)
    {
        return new Circle(new Location(x, y), diameter);
    }
}