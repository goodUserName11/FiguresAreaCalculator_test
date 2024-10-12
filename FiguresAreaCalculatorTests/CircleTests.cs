using FiguresAreaCalculator;

namespace FiguresAreaCalculatorTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Radius_InRange_SetsValue()
        {
            double expected = 5;

            var circle = new Circle()
            {
                Radius = 5,
            };

            double actual = circle.Radius;
            Assert.AreEqual(expected, actual, "Radius is not set correctly");
        }

        [TestMethod]
        public void Radius_OutOfRange_ShouldThrowArgumentOutOfRange()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Circle(-1));
        }

        [TestMethod]
        public void Area_CalculatesCorrectly()
        {
            double delta = 0.001;
            double expected = 78.539;
            var circle = new Circle(5);

            double actual = circle.CalculateArea();

            Assert.AreEqual(expected, actual, delta, "Area is not calculated correctly");
        }
    }
}
