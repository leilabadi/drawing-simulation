using DrawingSimulation.Core.Domain.Model;

namespace DrawingSimulation.UnitTests.Domain.Model;

public class TextboxTests
{
    [Fact]
    public void Constructor_ValidParameters_CreatesTextbox()
    {
        // Arrange
        int x = 5;
        int y = 5;
        int width = 10;
        int height = 15;
        string text = "Sample Text";

        // Act
        var sut = new Textbox(x, y, width, height, text);

        // Assert
        sut.Location.Should().NotBeNull();
        sut.Location.X.Should().Be(x);
        sut.Location.Y.Should().Be(y);
        sut.Width.Should().Be(width);
        sut.Height.Should().Be(height);
        sut.Text.Should().NotBeNullOrWhiteSpace().And.Be(text);
    }

    [Theory]
    [InlineData(-5, 5, 10, 15, "Sample Text")]
    [InlineData(0, 5, 10, 15, "Sample Text")]
    [InlineData(5, -5, 10, 15, "Sample Text")]
    [InlineData(5, 0, 10, 15, "Sample Text")]
    [InlineData(5, 5, -10, 15, "Sample Text")]
    [InlineData(5, 5, 0, 15, "Sample Text")]
    [InlineData(5, 5, 10, -15, "Sample Text")]
    [InlineData(5, 5, 10, 0, "Sample Text")]
    [InlineData(5, 5, 10, 15, null)]
    [InlineData(5, 5, 10, 15, "")]
    [InlineData(5, 5, 10, 15, " ")]
    public void Constructor_InvalidParameters_ThrowsArgumentException(int x, int y, int width, int height, string text)
    {
        // Act
        Action act = () => { var sut = new Textbox(x, y, width, height, text); };

        // Assert
        act.Should().Throw<ArgumentException>();
    }
}