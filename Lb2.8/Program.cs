using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер счета:");
            int account = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите имя клиента: ");
            string customer = Console.ReadLine();

            Console.WriteLine("Введите имя поставщика: ");
            string provider = Console.ReadLine();

            Console.WriteLine("Введите цену за единицу товара: ");
            int price = int.Parse(Console.ReadLine());
            Invoice invoice = new Invoice(account, customer, provider, price);
            Console.WriteLine("Введите количество товара: ");
            invoice.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите название товара: ");
            invoice.Article = Console.ReadLine();

            invoice.PriceWithNDS(price);
            invoice.PriceWithoutNDS(price);
        }
    }
}
