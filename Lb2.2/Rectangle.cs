using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb2._2
{
    class Rectangle
    {
        private double side1;

        public double Side1
        {
            get { return side1; }
        }

        private double side2;

        public double Side2
        {
            get { return side1; }
        }

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public double AreaCalculator(double side1, double side2)
        {
            double S = side1 * side2;
            return S;
        }
        public double PerimeterCalculator(double side1, double side2)
        {
            double P = side1 + side2;
            return P;
        }

    }
}
