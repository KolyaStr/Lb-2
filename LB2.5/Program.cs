using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Console.WriteLine("Введите логин: ");
            user.Login = Console.ReadLine();
            Console.WriteLine("Введите имя: ");
            user.Name = Console.ReadLine();
            Console.WriteLine("Введите фамилию: ");
            user.Surname = Console.ReadLine();
            Console.WriteLine("Введите возраст: ");
            user.Age = int.Parse(Console.ReadLine());
            user.Print();
        }
    }
}
