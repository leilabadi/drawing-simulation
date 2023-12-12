using DrawingSimulation.Core.Application.Rendering;
using DrawingSimulation.Core.Domain.Model;

namespace DrawingSimulation.UnitTests.Application.Rendering;

public class SquareOutputTests
{
    [Fact]
    public void GenerateOutput_ReturnsCorrectOutputForSquare()
    {
        // Arrange
        var square = new Square(1, 2, 300);
        var sut = new SquareOutput(square);

        // Act
        var output = sut.GenerateOutput();

        // Assert
        output.Should().Be("Square (1,2) size=300");
    }

    [Fact]
    public void GenerateOutput_ReturnsCorrectOutputForSquareWithDifferentValues()
    {
        // Arrange
        var square = new Square(5, 10, 500);
        var sut = new SquareOutput(square);

        // Act
        var output = sut.GenerateOutput();

        // Assert
        output.Should().Be("Square (5,10) size=500");
    }
}