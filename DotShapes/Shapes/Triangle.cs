using DotShapes.Interfaces;

namespace DotShapes.Shapes
{
    public class Triangle : ITriangle
    {
        private readonly double _sideA, _sideB, _sideC;
        private const double _inAccuracy = 0.000001f;

        public Triangle(double aSide, double bSide, double cSide)
        {
            if (aSide <= 0 || bSide <= 0 || cSide <= 0)
            {
                throw new ArgumentException("Triangle sides cannot be less then zero!");
            }

            if ((aSide + bSide) <= cSide ||
                (bSide + cSide) <= aSide ||
                (aSide + cSide <= bSide))
            {
                throw new ArgumentException("Incorrect triangle sides!");
            }

            _sideA = aSide; _sideB = bSide; _sideC = cSide;
        }

        public double GetArea()
        {
            double p = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
        }

        public bool IsRectangular()
        {
            // Так как у нас числа с плавающей точкой, то для того чтобы корректно сравнить
            // Я использую расстояние между квадратом C и суммой квадратов A и B.
            // Если расстояние < константное маленькое значение 
            return Math.Abs(Math.Pow(_sideC, 2) - (Math.Pow(_sideA, 2) + Math.Pow(_sideC, 2))) < _inAccuracy;
        }
            

    }
}