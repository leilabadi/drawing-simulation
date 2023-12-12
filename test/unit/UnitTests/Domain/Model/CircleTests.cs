using DrawingSimulation.Core.Domain.Model;

namespace DrawingSimulation.UnitTests.Domain.Model;

public class CircleTests
{
    [Fact]
    public void Constructor_ShouldSetValuesCorrectly()
    {
        // Arrange
        int x = 5;
        int y = 10;
        int diameter = 15;
        Func<Circle> CreateWidget = () => new Circle(x, y, diameter);

        // Act
        var sut = CreateWidget();

        // Assert
        sut.Location.Should().NotBeNull();
        sut.Location.X.Should().Be(x);
        sut.Location.Y.Should().Be(y);
        sut.Diameter.Should().Be(diameter);
    }
}