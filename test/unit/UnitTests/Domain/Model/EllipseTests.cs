using DrawingSimulation.Core.Domain.Model;

namespace DrawingSimulation.UnitTests.Domain.Model;

public class EllipseTests
{
    [Fact]
    public void Constructor_ShouldSetValuesCorrectly()
    {
        // Arrange
        int x = 1;
        int y = 2;
        int horizontalDiameter = 300;
        int verticalDiameter = 200;
        Func<Ellipse> CreateWidget = () => new Ellipse(x, y, horizontalDiameter, verticalDiameter);

        // Act
        var sut = CreateWidget();

        // Assert
        sut.Location.Should().NotBeNull();
        sut.Location.X.Should().Be(x);
        sut.Location.Y.Should().Be(y);
        sut.HorizontalDiameter.Should().Be(horizontalDiameter);
        sut.VerticalDiameter.Should().Be(verticalDiameter);
    }
}