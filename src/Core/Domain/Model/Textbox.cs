namespace DrawingSimulation.Core.Domain.Model;

public class Textbox : Rectangle
{
    public string Text { get; }

    public Textbox(int x, int y, int width, int height, string text) : base(x, y, width, height)
    {
        Text = text;
    }
}