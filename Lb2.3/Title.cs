using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb2._3
{
    class Title
    {
        private string title;

        public string Title1
        {
            get { return title; }
            set { title = value; }
        }

        public void Shov()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Название книги: {title}");
        }
    }
}
