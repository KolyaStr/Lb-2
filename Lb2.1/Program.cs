using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb2._1
{
    
    class Program
    {
        static Address GetAddress()
        {
            Address address = new Address();
            address.Index = 14190;
            address.City = "Киев";
            address.Country = "Украина";
            address.Street = "Лобачевского";
            address.House = 23;
            address.Apartment = 1;
            return address;
        }
        static void Main(string[] args)
        {
            var address = GetAddress();
            address.Print();
        }
    }
}
