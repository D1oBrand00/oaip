using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Book
    {
        string nameBook;
        string name;
        string surname;
        string otchestvo;
        int year;
        int numStr;

        public Book(string nameBook, string name, string surname, string otchestvo, int year, int numStr)
        {
            this.nameBook = nameBook;
            this.name = name;
            this.surname = surname;
            this.otchestvo = otchestvo;
            this.year = year;
            this.numStr = numStr;
        }

        public string NameBook { get => nameBook; set => nameBook = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Otchestvo { get => otchestvo; set => otchestvo = value; }
        public int Year { get => year; set => year = value; }
        public int NumStr { get => numStr; set => numStr = value; }

        public void OutPut()
        {
            Console.WriteLine($"Название книги - {nameBook}" +
                $"\nИмя автора - {name}" +
                $"\nФамилия автора - {surname}" +
                $"\nОтчество автора - {otchestvo}" +
                $"\nГод издания - {year}" +
                $"\nКолличество страниц - {numStr}\n");
        }
    }
}
