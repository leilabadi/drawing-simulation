using DrawingSimulation.Core.Domain.Model;

namespace DrawingSimulation.UnitTests.Domain.Model;

public class SquareTests
{
    [Fact]
    public void Constructor_ShouldSetValuesCorrectly()
    {
        // Arrange
        int x = 1;
        int y = 2;
        int width = 300;
        Func<Square> CreateWidget = () => new Square(x, y, width);

        // Act
        var sut = CreateWidget();

        // Assert
        sut.Location.Should().NotBeNull();
        sut.Location.X.Should().Be(x);
        sut.Location.Y.Should().Be(y);
        sut.Width.Should().Be(width);
    }
}