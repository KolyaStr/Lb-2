using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb2._8
{
    class Invoice
    {
        private int account;
        private string customer;
        private string provider;
        private string article;
        public string Article
        {
            get { return article; }
            set { article = value; }
        }
        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        private double price;
        public Invoice(int account, string customer, string provider, double price)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
            this.price = price;

        }
        public void PriceWithNDS(double price)
        {
            Console.WriteLine($"Цена с НДС: {price * Quantity * 1.4} гривен");
        }
        public void PriceWithoutNDS(double price)
        {
            Console.WriteLine($"Цена без НДС: {price * Quantity} гривен");

        }
    }
}
