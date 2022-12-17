namespace DotShapes.Interfaces
{
    public interface ITriangle : IShape
    {
        
        /// <summary>
        /// Проверяет, является ли треугольник прямоугольным.
        /// </summary>
        public bool IsRectangular();
    }
}

