namespace DrawingSimulation.Core.Domain.Model;

public class Textbox : Rectangle
{
    public string Text { get; }

    public Textbox(Location location, int width, int height, string text) : base(location, width, height)
    {
        Text = text;
    }
}