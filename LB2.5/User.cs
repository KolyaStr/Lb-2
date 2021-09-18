using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2._5
{
    class User
    {
        private string login;

        public string Login
        {
            get
            {
                if (login == null)
                    return "Поле пустое!";
                return login;
            }
            set { login = value; }
        }


        private string name;

        public string Name
        {
            get
            { if (name == null)
                    return "Поле пустое!";
               return name;
            }
            set { name = value; }
        }


        private string surname;

        public string Surname
        {
            get
            {
                if (surname == null)
                    return "Поле пустое!";
                return surname;
            }
            set { surname = value; }
        }


        private int age;

        public int Age
        {
            get {return age;}
            set { age = value; }
        }

        public readonly DateTime date;
        public User()
        {
            date = DateTime.Now;
        }

        public User(string login, string name, string surname, int age)
        {
            this.Login = login;
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            date = DateTime.Now;
        }
        public void Print()
        {
            Console.WriteLine("Ваша анкета: ");
            Console.WriteLine($"Логин: {login}");
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Фамилия:{surname}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Время заполнения анкеты: {date}");
            
        }
    }
}
