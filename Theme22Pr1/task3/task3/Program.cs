using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Колличество книг");
            int n = Convert.ToInt32(Console.ReadLine());

            Book[] books = new Book[n];

            for (int i = 0; i < n;i++)
            {
                Console.Write("Название книги: ");
                string nameBooK = Console.ReadLine();
                Console.Write("Имя автора: ");
                string name = Console.ReadLine();
                Console.Write("Фамилия автора: ");
                string surname = Console.ReadLine();
                Console.Write("Отчество автора");
                string otchestvo = Console.ReadLine();
                Console.Write("Год издания книги: ");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.Write("Кол-вл страниц: ");
                int numStr = Convert.ToInt32(Console.ReadLine());
                books[i] = new Book(nameBooK,name,surname,otchestvo,year,numStr);
                Console.WriteLine();
                

            }
            Console.Clear();
            foreach ( var book in books)
            {
                book.OutPut();
                Console.WriteLine();
            }
            Console.ReadKey();

            
        }
    }
}
