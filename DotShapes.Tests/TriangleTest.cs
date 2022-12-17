using DotShapes.Interfaces;
using DotShapes.Shapes;

namespace DotShapes.Tests
{

    public class TriangleTest
    {
    
        [Theory]
        [InlineData(0, 1, 2)]
        [InlineData(11, 0, -1)]
        [InlineData(1, 2, 3)]
        public void CheckIncorrectArguments(int a, int b, int c)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }

        [Theory]
        [InlineData(3, 4, 5, 6)]
        public void IsCorrectArea(int a, int b, int c, double area)
        {
            ITriangle triangle = new Triangle(a, b, c);
            
            Assert.Equal(area, triangle.GetArea());
        }
    }

}

