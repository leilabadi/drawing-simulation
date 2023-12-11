using DrawingSimulation.Core.Domain.Model;

namespace DrawingSimulation.Core.Domain.Interface;

public interface IRectangleFactory
{
    Rectangle CreateRectangle(int x, int y, int width, int height);
}