using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb2._1
{
    class Address
    {
        private int index;

        public int Index
        {
            private get { return index; }
            set { index = value; }
        }
        private string city;

        public string City
        {
            private get { return city; }
            set { city = value; }
        }
        private string country;

        public string Country
        {
            private get { return country; }
            set { country = value; }
        }
        private string street;

        public string Street
        {
            private get { return street; }
            set { street = value; }
        }
        private int house;

        public int House
        {
            private get { return house; }
            set { house = value; }
        }
        private int apartment;

        public int Apartment
        {
            private get { return apartment; }
            set { apartment = value; }
        }

        public void Print()
        {
            Console.WriteLine($"Индекс: {Index}");
            Console.WriteLine($"Город: {City}");
            Console.WriteLine($"Страна: {Country}");
            Console.WriteLine($"Улица: {Street}");
            Console.WriteLine($"Дом: {House}");
            Console.WriteLine($"Номер квартиры: {Apartment}");
        }
    }
}
