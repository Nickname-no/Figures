using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Circle : IFigure
    {
        private string _notPositiveRadiusException = "Значение радиуса окружности не может быть отрицательным или равным 0";
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException(_notPositiveRadiusException, nameof(radius));

            Radius = radius;
        }

        public double GetSquare()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
