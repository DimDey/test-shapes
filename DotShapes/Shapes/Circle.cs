using DotShapes.Interfaces;

namespace DotShapes.Shapes
{
    public class Circle : ICircle
    {
        private readonly double _radius;
        
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Circle radius cannot be less then zero!");
            }
            
            _radius = radius;
        }

        // Площадь круга = (Pi * r^2)
        public double GetArea() => Math.PI * Math.Pow(_radius, 2);
    }
}

