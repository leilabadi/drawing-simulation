using System.Text;

namespace DrawingSimulation.Core.Application.Rendering;

public class ConsoleRenderer : IRenderer
{
    private const string HorizontalLine = "----------------------------------------------------------------";

    public void Render(IReadOnlyList<WidgetOutput> widgets)
    {
        string output = RenderInternal(widgets);
        Console.WriteLine(output);
    }

    public string RenderInternal(IReadOnlyList<WidgetOutput> widgets)
    {
        var sb = new StringBuilder();
        sb.AppendLine(HorizontalLine);
        sb.AppendLine("Requested Drawing");
        sb.AppendLine(HorizontalLine);

        foreach (var widget in widgets)
        {
            sb.AppendLine(widget.GenerateOutput());
        }

        sb.AppendLine(HorizontalLine);
        return sb.ToString();
    }
}