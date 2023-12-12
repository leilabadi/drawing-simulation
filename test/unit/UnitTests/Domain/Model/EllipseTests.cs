using DrawingSimulation.Core.Domain.Model;

namespace DrawingSimulation.UnitTests.Domain.Model;

public class EllipseTests
{
    [Fact]
    public void Constructor_ValidParameters_CreatesEllipse()
    {
        // Arrange
        int x = 5;
        int y = 5;
        int horizontalDiameter = 10;
        int verticalDiameter = 15;

        // Act
        var sut = new Ellipse(x, y, horizontalDiameter, verticalDiameter);

        // Assert
        sut.Location.Should().NotBeNull();
        sut.Location.X.Should().Be(x);
        sut.Location.Y.Should().Be(y);
        sut.HorizontalDiameter.Should().Be(horizontalDiameter);
        sut.VerticalDiameter.Should().Be(verticalDiameter);
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
    public void Constructor_InvalidParameters_ThrowsArgumentException(int x, int y, int horizontalDiameter, int verticalDiameter)
    {
        // Act
        Action act = () => { var sut = new Ellipse(x, y, horizontalDiameter, verticalDiameter); };

        // Assert
        act.Should().Throw<ArgumentException>();
    }
}