namespace FiguresAreaCalculator
{
    public class Triangle : AbstractFigure
    {
        private double _side1;
        private double _side2;
        private double _side3;

        public Triangle() { }

        public Triangle(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public double Side1
        {
            get => _side1;

            set
            {
                ValidateLength(value);

                _side1 = value;
            }
        }

        public double Side2
        {
            get => _side2;

            set
            {
                ValidateLength(value);

                _side2 = value;
            }
        }

        public double Side3
        {
            get => _side3;

            set
            {
                ValidateLength(value);

                _side3 = value;
            }
        }

        public override double CalculateArea()
        {
            double semiPerimeter = (Side1 + Side2 + Side3) / 2;

            return Math.Sqrt(
                    semiPerimeter *
                    (semiPerimeter - Side1) *
                    (semiPerimeter - Side2) *
                    (semiPerimeter - Side3)
                );
        }

        /// <summary>
        /// Проверка, что треугольник прямоуголный
        /// </summary>
        /// <returns></returns>
        public bool IsRightTriangle()
        {
            bool res;

            if (Side1 > Side2 && Side1 > Side3)
                res = Math.Pow(Side1, 2) == Math.Pow(Side2, 2) + Math.Pow(Side3, 2);
            else if (Side2 > Side1 && Side2 > Side3)
                res = Math.Pow(Side2, 2) == Math.Pow(Side1, 2) + Math.Pow(Side3, 2);
            else
                res = Math.Pow(Side3, 2) == Math.Pow(Side1, 2) + Math.Pow(Side2, 2);

            return res;
        }
    }
}
