namespace DrawingSimulation.Core.Application.Rendering;

public interface IRenderer
{
    void Render(IReadOnlyList<WidgetOutput> widgets);
}