using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Author author = new Author();
            Book book = new Book();
            Content content = new Content();
            Title title = new Title();
            
            Console.WriteLine("Введите автора: ");
            author.Author1 = Console.ReadLine();
            
            Console.WriteLine("Введите название книги: ");
            title.Title1 = Console.ReadLine();
           
            Console.WriteLine("Введите содержание: ");
            content.Content1 = Console.ReadLine();
            
            
            author.Shov();
            
            title.Shov();
            
            content.Shov();
        }
    }
}
