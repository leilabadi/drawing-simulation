using DrawingSimulation.Core.Domain.Interface;
using DrawingSimulation.Core.Domain.Model;

namespace DrawingSimulation.Core.Application;

public class RectangleFactory : IRectangleFactory
{
    public Rectangle CreateRectangle(int x, int y, int width, int height)
    {
        return new Rectangle(new Location(x, y), width, height);
    }
}