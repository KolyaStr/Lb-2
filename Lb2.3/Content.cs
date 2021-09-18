using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb2._3
{
    class Content
    {
        private string content;

        public string Content1
        {
            get { return content; }
            set { content = value; }
        }

        public void Shov()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Содержание: {content}");
        }
    }
}
