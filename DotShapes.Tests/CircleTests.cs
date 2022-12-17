using DotShapes.Shapes;

namespace DotShapes.Tests
{
    public class CircleTests
    {

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void CheckIncorrectArguments(double radius)
        {
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }

        [Theory]
        [InlineData(1, Math.PI)]
        [InlineData(2, Math.PI * 4)]
        [InlineData(9, Math.PI * 81)]
        public void IsCorrectArea(double radius, double area)
        {
            Assert.Equal(area, new Circle(radius).GetArea());
        }
    }
}

