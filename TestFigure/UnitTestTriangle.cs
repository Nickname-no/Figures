using Figure;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFigure
{
    public class UnitTestTriangle
    {
		[TestCase(0, 0, 0)]
		[TestCase(-1, 1, 1)]
		[TestCase(1, -1, 1)]
		[TestCase(1, 1, -1)]
		public void InitTriangleWithErrorTest(double a, double b, double c)
		{
			Assert.Catch<ArgumentException>(() => new Triangle(a, b, c));
		}

		[Test]
		public void InitTriangleTest()
		{
			double a = 1;
			double b = 2;
			double c = 2;

			IFigure triangle = new Triangle(a, b, c);

			Assert.NotNull(triangle);
		}

		[Test]
		public void InitNotTriangleTest()
		{
			Assert.Catch<ArgumentException>(() => new Triangle(1, 1, 4));
		}

		[Test]
		public void GetSquareTest()
        {
			double result = 6;

			IFigure triangle = new Triangle(3, 4, 5);

			double square = triangle.GetSquare();

			Assert.AreEqual(result, square);
        }

		[Test]
		public void RightTriangle()
        {
			Triangle triangle = new Triangle(3, 4, 5);

			bool isRightTriangle = triangle.isRightTriangle();

			Assert.IsTrue(isRightTriangle);
		}
	}
}
