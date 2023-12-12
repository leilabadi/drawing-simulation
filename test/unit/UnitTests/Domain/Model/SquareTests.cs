using DrawingSimulation.Core.Domain.Model;

namespace DrawingSimulation.UnitTests.Domain.Model;

public class SquareTests
{
    [Fact]
    public void Constructor_ValidParameters_CreatesSquare()
    {
        // Arrange
        int x = 5;
        int y = 5;
        int width = 10;

        // Act
        var sut = new Square(x, y, width);

        // Assert
        sut.Location.Should().NotBeNull();
        sut.Location.X.Should().Be(x);
        sut.Location.Y.Should().Be(y);
        sut.Width.Should().Be(width);
    }

    [Theory]
    [InlineData(-5, 5, 10)]
    [InlineData(0, 5, 10)]
    [InlineData(5, -5, 10)]
    [InlineData(5, 0, 10)]
    [InlineData(5, 5, -10)]
    [InlineData(5, 5, 0)]
    public void Constructor_InvalidParameters_ThrowsArgumentException(int x, int y, int width)
    {
        // Act
        Action act = () => { var sut = new Square(x, y, width); };

        // Assert
        act.Should().Throw<ArgumentException>();
    }
}