using DrawingSimulation.Core.Domain.Interface;
using DrawingSimulation.Core.Domain.Model;

namespace DrawingSimulation.Core.Application;

public class SquareFactory : ISquareFactory
{
    public Square CreateSquare(int x, int y, int width)
    {
        return new Square(new Location(x, y), width);
    }
}