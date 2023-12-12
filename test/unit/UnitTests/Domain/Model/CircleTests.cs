using DrawingSimulation.Core.Domain.Model;

namespace DrawingSimulation.UnitTests.Domain.Model;

public class CircleTests
{
    [Fact]
    public void Constructor_ValidParameters_CreatesCircle()
    {
        // Arrange
        int x = 5;
        int y = 5;
        int diameter = 10;

        // Act
        var sut = new Circle(x, y, diameter);

        // Assert
        sut.Location.Should().NotBeNull();
        sut.Location.X.Should().Be(x);
        sut.Location.Y.Should().Be(y);
        sut.Diameter.Should().Be(diameter);
    }

    [Theory]
    [InlineData(-5, 5, 10)]
    [InlineData(0, 5, 10)]
    [InlineData(5, -5, 10)]
    [InlineData(5, 0, 10)]
    [InlineData(5, 5, -10)]
    [InlineData(5, 5, 0)]
    public void Constructor_InvalidParameters_ThrowsArgumentException(int x, int y, int diameter)
    {
        // Act
        Action act = () => { var sut = new Circle(x, y, diameter); };

        // Assert
        act.Should().Throw<ArgumentException>();
    }
}