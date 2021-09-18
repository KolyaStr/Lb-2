using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую сторону:");
            double side1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите вторую сторону:");
            double side2 = double.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(side1, side2);

            double S = rectangle.AreaCalculator(side1, side2);
            double P = rectangle.PerimeterCalculator(side1, side2);

            Console.WriteLine($"Площадь: {S}");
            Console.WriteLine($"Периметр: {P}");
        }
    }
}
