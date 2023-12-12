using DrawingSimulation.Core.Domain.Model;

namespace DrawingSimulation.UnitTests.Domain.Model;

public class RectangleTests
{
    [Fact]
    public void Constructor_ValidParameters_CreatesRectangle()
    {
        // Arrange
        int x = 5;
        int y = 5;
        int width = 10;
        int height = 15;

        // Act
        var sut = new Rectangle(x, y, width, height);

        // Assert
        sut.Location.Should().NotBeNull();
        sut.Location.X.Should().Be(x);
        sut.Location.Y.Should().Be(y);
        sut.Width.Should().Be(width);
        sut.Height.Should().Be(height);
    }

    [Theory]
    [InlineData(-5, 5, 10, 15)]
    [InlineData(0, 5, 10, 15)]
    [InlineData(5, -5, 10, 15)]
    [InlineData(5, 0, 10, 15)]
    [InlineData(5, 5, -10, 15)]
    [InlineData(5, 5, 0, 15)]
    [InlineData(5, 5, 10, -15)]
    [InlineData(5, 5, 10, 0)]
    public void Constructor_InvalidParameters_ThrowsArgumentException(int x, int y, int width, int height)
    {
        // Act
        Action act = () => { var sut = new Rectangle(x, y, width, height); };

        // Assert
        act.Should().Throw<ArgumentException>();
    }
}