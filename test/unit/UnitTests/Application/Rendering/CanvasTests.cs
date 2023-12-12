using DrawingSimulation.Core.Application.Rendering;
using DrawingSimulation.Core.Domain.Model;

namespace DrawingSimulation.UnitTests.Application.Rendering;

public class CanvasTests
{
    private readonly Mock<IRenderer> rendererMock;
    private readonly Canvas canvas;

    public CanvasTests()
    {
        rendererMock = new Mock<IRenderer>();
        canvas = new Canvas(rendererMock.Object);
    }

    [Fact]
    public void Render_PassingAListOfWidgets_ShouldRenderTheSameWidject()
    {
        // Arrange
        canvas.AddWidget(new Rectangle(1, 2, 300, 200));
        canvas.AddWidget(new Square(1, 2, 300));
        canvas.AddWidget(new Ellipse(1, 2, 300, 200));
        canvas.AddWidget(new Circle(1, 2, 300));
        canvas.AddWidget(new Textbox(1, 2, 300, 200, "Hello World"));

        // Act
        canvas.Render();

        // Assert
        rendererMock.Verify(r => r.Render(It.Is<List<WidgetOutput>>(list =>
            list.Any(w => w is RectangleOutput) &&
            list.Any(w => w is SquareOutput) &&
            list.Any(w => w is CircleOutput) &&
            list.Any(w => w is EllipseOutput) &&
            list.Any(w => w is TextboxOutput))), Times.Once);
    }
}