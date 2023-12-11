using DrawingSimulation.Core.Domain.Model;

namespace DrawingSimulation.UnitTests;

public class WidgetTests
{
    [Fact]
    public void Created_rectangle_should_have_right_attributes()
    {
        // Arrange
        var location = new Location(1, 2);
        int width = 300;
        int height = 200;
        Func<Rectangle> CreateWidget = () => new Rectangle(location, width, height);

        // Act
        var sut = CreateWidget();

        // Assert
        sut.Location.Should().Be(location);
        sut.Width.Should().Be(width);
        sut.Height.Should().Be(height);
    }
}