namespace FiguresAreaCalculator
{
    public abstract class AbstractFigure : IAreable
    {
        /// <summary>
        /// Определение площади фигуры
        /// </summary>
        /// <returns></returns>
        public abstract double CalculateArea();

        /// <summary>
        /// Валидация длин сторон
        /// </summary>
        /// <param name="length"></param>
        /// <exception cref="ArgumentOutOfRangeException">ArgumentOutOfRangeException</exception>
        public static void ValidateLength(double length)
        {
            if (length < 0 || !double.IsFinite(length))
                throw new ArgumentOutOfRangeException(nameof(length), length, "Length cannot be negative, NaN, or infinity");
        }
    }
}
