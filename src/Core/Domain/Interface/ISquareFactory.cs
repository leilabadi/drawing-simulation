using DrawingSimulation.Core.Domain.Model;

namespace DrawingSimulation.Core.Domain.Interface;

public interface ISquareFactory
{
    Square CreateSquare(int x, int y, int width);
}