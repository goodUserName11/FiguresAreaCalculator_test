namespace FiguresAreaCalculator
{
    public class Circle : AbstractFigure
    {
        private double _radius;

        public Circle() { }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius
        {
            get => _radius;

            set
            {
                ValidateLength(value);

                _radius = value;
            }
        }

        public override double CalculateArea() =>
            Math.PI * Math.Pow(Radius, 2);
    }
}
