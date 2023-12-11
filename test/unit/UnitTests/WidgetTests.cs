using DrawingSimulation.Core.Domain.Model;

namespace DrawingSimulation.UnitTests;

public class WidgetTests
{
    [Fact]
    public void Created_rectangle_should_have_right_attributes()
    {
        // Arrange
        int x = 1;
        int y = 2;
        int width = 300;
        int height = 200;
        Func<Rectangle> CreateWidget = () => new Rectangle(x, y, width, height);

        // Act
        var sut = CreateWidget();

        // Assert
        sut.Location.Should().NotBeNull();
        sut.Location.X.Should().Be(x);
        sut.Location.Y.Should().Be(y);
        sut.Width.Should().Be(width);
        sut.Height.Should().Be(height);
    }
}