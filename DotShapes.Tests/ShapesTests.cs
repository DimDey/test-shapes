using DotShapes.Interfaces;
using DotShapes.Shapes;

namespace DotShapes.Tests
{
    public class ShapesTests
    {
        [Fact]
        public void CheckShapesArea()
        {
            List<IShape> shapes = new List<IShape>();
            
            shapes.Add(new Circle(1));
            shapes.Add(new Triangle(4, 5, 6));
            
            var exception = Record.Exception(() =>
            {
                foreach (var shape in shapes)
                {
                    shape.GetArea();
                }
            });
            
            Assert.Null(exception);
        }
    }
}

