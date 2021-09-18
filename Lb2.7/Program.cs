using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите фамилию: ");
            string surname = Console.ReadLine();

            Employee employee = new Employee(name, surname);

            Console.WriteLine("Введите стаж:");
            employee.Experience = double.Parse(Console.ReadLine());
            double experience = employee.Experience;

            Console.WriteLine("Введите одну должность из списка: Junior, Middle, Senior");
            employee.Position = Console.ReadLine();
            string position = employee.Position;

            employee.Salary(experience, position);
        }
    }
}
