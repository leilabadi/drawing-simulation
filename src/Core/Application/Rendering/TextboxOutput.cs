using DrawingSimulation.Core.Domain.Model;

namespace DrawingSimulation.Core.Application.Rendering;

public class TextboxOutput : WidgetOutput
{
    private readonly Textbox textbox;

    public TextboxOutput(Textbox textbox)
    {
        this.textbox = textbox;
    }

    public override string GenerateOutput()
    {
        return $"Textbox ({textbox.Location.X},{textbox.Location.Y}) width={textbox.Width} height={textbox.Height} Text=\"{textbox.Text}\"";
    }
}