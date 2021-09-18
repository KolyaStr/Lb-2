using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название фигуры: ");
            string name = Console.ReadLine();
            Point point1 = new Point(1, 8);

            Point point2 = new Point(5, 4);

            Point point3 = new Point(9, 0);

            Point point4 = new Point(11, 4);

            Figure figure = new Figure(point1, point2, point3, point4);

            Console.WriteLine($"Название фигуры: {name}");
            figure.PerimeterCalculator();

        }
    }
}
