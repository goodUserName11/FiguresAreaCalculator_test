using FiguresAreaCalculator;

namespace FiguresAreaCalculatorTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Side1_InRange_SetsValue()
        {
            double expected = 5;

            var triangle = new Triangle()
            {
                Side1 = 5,
            };

            double actual = triangle.Side1;
            Assert.AreEqual(expected, actual, "Side1 is not set correctly");
        }

        [TestMethod]
        public void Side1_OutOfRange_ShouldThrowArgumentOutOfRange()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle() { Side1 = -1 });
        }

        [TestMethod]
        public void Side2_InRange_SetsValue()
        {
            double expected = 1.11;

            var triangle = new Triangle()
            {
                Side2 = 1.11,
            };

            double actual = triangle.Side2;
            Assert.AreEqual(expected, actual, "Side2 is not set correctly");
        }

        [TestMethod]
        public void Side2_OutOfRange_ShouldThrowArgumentOutOfRange()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle() { Side2 = double.NaN });
        }

        [TestMethod]
        public void Side3_InRange_SetsValue()
        {
            double expected = 47;

            var triangle = new Triangle()
            {
                Side3 = 47,
            };

            double actual = triangle.Side3;
            Assert.AreEqual(expected, actual, "Side3 is not set correctly");
        }

        [TestMethod]
        public void Side3_OutOfRange_ShouldThrowArgumentOutOfRange()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle() { Side3 = double.PositiveInfinity });
        }

        [TestMethod]
        public void Area_CalculatesCorrectly()
        {
            double delta = 0.001;
            double expected = 12;
            var triangle = new Triangle()
            {
                Side1 = 5,
                Side2 = 5,
                Side3 = 6,
            };

            double actual = triangle.CalculateArea();

            Assert.AreEqual(expected, actual, delta, "Area is not calculated correctly");
        }

        [TestMethod]
        public void IsRightTriangle_Right_ChecksCorrectly()
        {
            bool expected = true;
            var triangle = new Triangle()
            {
                Side1 = 3,
                Side2 = 4,
                Side3 = 5,
            };

            bool actual = triangle.IsRightTriangle();

            Assert.AreEqual(expected, actual, "Is right is not checked correctly");
        }

        [TestMethod]
        public void IsRightTriangle_NotRight_ChecksCorrectly()
        {
            bool expected = false;
            var triangle = new Triangle()
            {
                Side1 = 6,
                Side2 = 7,
                Side3 = 8,
            };

            bool actual = triangle.IsRightTriangle();

            Assert.AreEqual(expected, actual, "Is right is not checked correctly");
        }
    }
}
