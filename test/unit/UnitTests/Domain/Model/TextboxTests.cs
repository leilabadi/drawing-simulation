using DrawingSimulation.Core.Domain.Model;

namespace DrawingSimulation.UnitTests.Domain.Model;

public class TextboxTests
{
    [Fact]
    public void Constructor_ShouldSetValuesCorrectly()
    {
        // Arrange
        int x = 1;
        int y = 2;
        int width = 300;
        int height = 200;
        string text = "Test Text";
        Func<Textbox> CreateWidget = () => new Textbox(x, y, width, height, text);

        // Act
        var sut = CreateWidget();

        // Assert
        sut.Location.Should().NotBeNull();
        sut.Location.X.Should().Be(x);
        sut.Location.Y.Should().Be(y);
        sut.Width.Should().Be(width);
        sut.Height.Should().Be(height);
        sut.Text.Should().Be(text);
    }
}