using DrawingSimulation.Core.Application.Rendering;
using DrawingSimulation.Core.Domain.Model;

namespace DrawingSimulation.UnitTests.Application.Rendering;

public class TextboxOutputTests
{
    [Fact]
    public void GenerateOutput_ReturnsCorrectOutputForTextbox()
    {
        // Arrange
        var textbox = new Textbox(1, 2, 300, 200, "Sample Text");
        var sut = new TextboxOutput(textbox);

        // Act
        var output = sut.GenerateOutput();

        // Assert
        output.Should().Be("Textbox (1,2) width=300 height=200 Text=\"Sample Text\"");
    }

    [Fact]
    public void GenerateOutput_ReturnsCorrectOutputForTextboxWithDifferentValues()
    {
        // Arrange
        var textbox = new Textbox(5, 10, 500, 400, "Different Text");
        var sut = new TextboxOutput(textbox);

        // Act
        var output = sut.GenerateOutput();

        // Assert
        output.Should().Be("Textbox (5,10) width=500 height=400 Text=\"Different Text\"");
    }
}