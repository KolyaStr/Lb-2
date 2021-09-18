using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb2._4
{
    public class Figure

    {

        private double s1, s2, s3, s4, s5;

        public Figure(Point a, Point b, Point c)

        {

            s1 = LengthSide(a, b);
            s2 = LengthSide(b, c);
            s3 = LengthSide(c, a);

        }
        public Figure(Point a, Point b, Point c, Point d)

        {

            s1 = LengthSide(a, b);
            s2 = LengthSide(b, c);
            s3 = LengthSide(c, d);
            s4 = LengthSide(d, a);

        }
        public Figure(Point a, Point b, Point c, Point d, Point e)
        {

            s1 = LengthSide(a, b);
            s2 = LengthSide(b, c);
            s3 = LengthSide(c, d);
            s4 = LengthSide(d, e);
            s5 = LengthSide(e, a);

        }

        public static double LengthSide(Point a, Point b)
        {
            return Math.Abs(Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2)));
        }

        public void PerimeterCalculator()
        {

            if (s5 != 0)
            {
                double perimeter = s1 + s2 + s3 + s4 + s5;
                Console.WriteLine($"Периметр: {perimeter}");
            }

            else if (s5 == 0 & s4 != 0)
            {
                double perimeter = s1 + s2 + s3 + s4;
                Console.WriteLine($"Периметр: {perimeter}");
            }
            else
            {
                double perimeter = s1 + s2 + s3;
                Console.WriteLine($"Периметр: {perimeter}");
            }

        }

    }
}
