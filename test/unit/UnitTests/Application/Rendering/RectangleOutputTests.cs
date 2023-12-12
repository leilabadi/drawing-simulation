using DrawingSimulation.Core.Application.Rendering;
using DrawingSimulation.Core.Domain.Model;

namespace DrawingSimulation.UnitTests.Application.Rendering;

public class RectangleOutputTests
{
    [Fact]
    public void GenerateOutput_ReturnsCorrectOutputForRectangle()
    {
        // Arrange
        var rectangle = new Rectangle(1, 2, 300, 200);
        var sut = new RectangleOutput(rectangle);

        // Act
        var output = sut.GenerateOutput();

        // Assert
        output.Should().Be("Rectangle (1,2) width=300 height=200");
    }

    [Fact]
    public void GenerateOutput_ReturnsCorrectOutputForRectangleWithDifferentValues()
    {
        // Arrange
        var rectangle = new Rectangle(5, 10, 500, 400);
        var sut = new RectangleOutput(rectangle);

        // Act
        var output = sut.GenerateOutput();

        // Assert
        output.Should().Be("Rectangle (5,10) width=500 height=400");
    }
}