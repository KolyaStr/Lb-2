using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = 0, eur = 0, rub = 0;
            Console.WriteLine("Какуб валюту в какую вы хотите перевести?: ");
            Console.WriteLine("1. Доллары в гривны");
            Console.WriteLine("2. Евро в гривны");
            Console.WriteLine("3. Гривны в доллары и евро");
            int x = int.Parse(Console.ReadLine());
            if (x == 1)
            {
                Console.WriteLine("Введите количество долларов: ");
                usd = double.Parse(Console.ReadLine());
                eur = 0;
                rub = 0;
            }
            if (x == 2)
            {
                Console.WriteLine("Введите колличество евро: ");
                eur = double.Parse(Console.ReadLine());
                rub = 0;
                usd = 0;
            }
            if (x == 3)
            {
                Console.WriteLine("Введите колличесвто гривен: ");
                rub = double.Parse(Console.ReadLine());
                usd = 0;
                eur = 0;
            }
            Converter converter = new Converter(usd, eur, rub);
            converter.Print();
        }
    }
}
