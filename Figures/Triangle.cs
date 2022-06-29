using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Triangle : ITriangle
    {
        private string _notPositiveEdgeException = "Значение стороны треугольника не может быть отрицательным или равным 0";
        private string _notSatisfyTriangleInequalityException = "Наибольшая сторона треугольника должна быть меньше суммы других сторон";
        public double EdgeA { get; }
        public double EdgeB { get; }
        public double EdgeC { get; }
        
        public Triangle(double edgeA, double edgeB, double edgeC)
        {
            if (edgeA <= 0)
                throw new ArgumentException(_notPositiveEdgeException, nameof(edgeA));

            if (edgeB <= 0)
                throw new ArgumentException(_notPositiveEdgeException, nameof(edgeB));

            if(edgeC <= 0)
                throw new ArgumentException(_notPositiveEdgeException, nameof(edgeC));

            double maxEdge = Math.Max(edgeA, Math.Max(edgeB, edgeC));
            double perimeter = edgeA + edgeB + edgeC;

            if(perimeter - maxEdge <= maxEdge)
                throw new ArgumentException(_notSatisfyTriangleInequalityException);

            EdgeA = edgeA;
            EdgeB = edgeB;
            EdgeC = edgeC;
        }

        public double GetSquare()
        {
            double halfPerimeter = (EdgeA + EdgeB + EdgeC) / 2;
            double square = Math.Sqrt(halfPerimeter
                                      * (halfPerimeter - EdgeA)
                                      * (halfPerimeter - EdgeB)
                                      * (halfPerimeter - EdgeC)
            );
            return square;
        }

        public bool isRightTriangle()
        {
            double edgeA = EdgeA;
            double edgeB = EdgeB;
            double maxEdge = EdgeC;

            if (maxEdge - edgeA < 0)
                Swap(ref edgeA, ref maxEdge);
            else if (maxEdge - edgeB < 0)
                Swap(ref edgeB, ref maxEdge);

            if (Math.Pow(edgeA,2) + Math.Pow(edgeB,2) == Math.Pow(maxEdge,2))
                return true;
            else
                return false;

        }

        private void Swap(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }
    }
}
