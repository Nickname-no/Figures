using Figure;
using NUnit.Framework;
using System;

namespace TestFigure
{
    public class UnitTestCircle
    {

        [Test]
        public void ZeroRadiusTest()
        {
            Assert.Catch<ArgumentException>(() => new Circle(0));
        }

        [Test]
        public void NegativeRadiusTest()
        {
            Assert.Catch<ArgumentException>(() => new Circle(-1));
        }

        [Test]
        public void GetSquareTest()
        {
            double radius = 5;
            IFigure circle = new Circle(radius);
            double expectedValue = Math.PI * Math.Pow(radius, 2d);

            double square = circle.GetSquare();

            Assert.AreEqual(expectedValue, square);
        }
    }
}