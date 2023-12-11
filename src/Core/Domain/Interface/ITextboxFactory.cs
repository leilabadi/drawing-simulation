using DrawingSimulation.Core.Domain.Model;

namespace DrawingSimulation.Core.Domain.Interface;

public interface ITextboxFactory
{
    Textbox CreateTextbox(int x, int y, int width, int height, string text);
}