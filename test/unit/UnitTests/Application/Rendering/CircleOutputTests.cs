using DrawingSimulation.Core.Application.Rendering;
using DrawingSimulation.Core.Domain.Model;

namespace DrawingSimulation.UnitTests.Application.Rendering;

public class CircleOutputTests
{
    [Fact]
    public void GenerateOutput_ReturnsCorrectOutputForCircle()
    {
        // Arrange
        var circle = new Circle(1, 2, 300);
        var sut = new CircleOutput(circle);

        // Act
        var output = sut.GenerateOutput();

        // Assert
        output.Should().Be("Circle (1,2) size=600");
    }

    [Fact]
    public void GenerateOutput_ReturnsCorrectOutputForCircleWithDifferentValues()
    {
        // Arrange
        var circle = new Circle(5, 10, 500);
        var sut = new CircleOutput(circle);

        // Act
        var output = sut.GenerateOutput();

        // Assert
        output.Should().Be("Circle (5,10) size=1000");
    }
}