using DrawingSimulation.Core.Application.Rendering;
using DrawingSimulation.Core.Domain.Model;

namespace DrawingSimulation.UnitTests.Application.Rendering;

public class EllipseOutputTests
{
    [Fact]
    public void GenerateOutput_ReturnsCorrectOutputForEllipse()
    {
        // Arrange
        var ellipse = new Ellipse(1, 2, 300, 200);
        var sut = new EllipseOutput(ellipse);

        // Act
        var output = sut.GenerateOutput();

        // Assert
        output.Should().Be("Ellipse (1,2) diameterH = 300 diameterV = 200");
    }

    [Fact]
    public void GenerateOutput_ReturnsCorrectOutputForEllipseWithDifferentValues()
    {
        // Arrange
        var ellipse = new Ellipse(5, 10, 500, 400);
        var sut = new EllipseOutput(ellipse);

        // Act
        var output = sut.GenerateOutput();

        // Assert
        output.Should().Be("Ellipse (5,10) diameterH = 500 diameterV = 400");
    }
}