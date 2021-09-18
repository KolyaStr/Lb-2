using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb2._7
{
    class Employee
    {
        private string name;
        private string surname;
        private double experience;
        private double taxes = 0.15;

        public double Experience
        {
            get { return experience; }
            set { experience = value; }
        }

        private string position;
        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public void Salary(double experience, string position)
        {
            double salary = 0;
            if (position == "Junior" || position == "junior")
            {
                salary = 1000 * (experience * 0.35);
                taxes = taxes * salary;
                Console.WriteLine($"Имя: {name}, Фамилия: {surname}, ваша должность: Junior, зарплата: {salary}$, налог: {taxes}$");
            }
            else if (position == "Middle" || position == "middle")
            {
                salary = 2000 * (experience * 0.35);
                taxes = taxes * salary;
                Console.WriteLine($"Ваша должность: Middle, зарплата: {salary}$, налог: {taxes}$");
            }
            else if (position == "Senior" || position == "senior")
            {
                salary = 3000 * (experience * 0.35);
                taxes = taxes * salary;
                Console.WriteLine($"Ваша должность: Senior, зарплата: {salary}$, налог: {taxes}$");
            }
            else
                Console.WriteLine("Такой должности нет!");
        }

    }
}

