using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb2._3
{
    class Author
    {
        private string author;

        public string Author1
        {
            get { return author; }
            set { author = value; }
        }

        public void Shov()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Автор: {author}");
        }
    }
}
