using DrawingSimulation.Core.Domain.Interface;
using DrawingSimulation.Core.Domain.Model;

namespace DrawingSimulation.Core.Application;

public class TextboxFactory : ITextboxFactory
{
    public Textbox CreateTextbox(int x, int y, int width, int height, string text)
    {
        return new Textbox(new Location(x, y), width, height, text);
    }
}