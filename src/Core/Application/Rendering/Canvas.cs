using DrawingSimulation.Core.Domain.Model;

namespace DrawingSimulation.Core.Application.Rendering;

public class Canvas
{
    private readonly List<WidgetOutput> widgetOutputs = [];
    private readonly IRenderer renderer;

    public Canvas(IRenderer renderer)
    {
        this.renderer = renderer;
    }

    public void Render()
    {
        renderer.Render(widgetOutputs);
    }

    public void AddWidget(Rectangle rectangle)
    {
        widgetOutputs.Add(new RectangleOutput(rectangle));
    }

    public void AddWidget(Square square)
    {
        widgetOutputs.Add(new SquareOutput(square));
    }

    public void AddWidget(Ellipse ellipse)
    {
        widgetOutputs.Add(new EllipseOutput(ellipse));
    }

    public void AddWidget(Circle circle)
    {
        widgetOutputs.Add(new CircleOutput(circle));
    }

    public void AddWidget(Textbox textbox)
    {
        widgetOutputs.Add(new TextboxOutput(textbox));
    }
}