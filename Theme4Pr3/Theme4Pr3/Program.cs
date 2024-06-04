using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme4Pr3
{
    class Program
    {
        static void Main(string[] args)
        {
            //19.Запросить у пользователя 1 слово, после чего вывести три столбца, каждый через промежуток в несколько символов от предыдущего, содержащие по три строки с введенным пользователем словом. Использовать 10 функции вывода.
            Console.Title = "Программа № 3 (Полозюк)";
            Console.Write("Введите слово: "); //Запрашиваю у пользователя 1 слово
            string word = Console.ReadLine();
            Console.WriteLine($"{word}"); //Вывожу на экран три столбца, содержащие 3 строки с веденным словом, каждый через промежуток
            Console.WriteLine($"{word}");
            Console.WriteLine($"{word}");
            Console.WriteLine("###");
            Console.WriteLine($"{word}");
            Console.WriteLine($"{word}");
            Console.WriteLine($"{word}");
            Console.WriteLine("###");
            Console.WriteLine($"{word}");
            Console.WriteLine($"{word}\n{word}");
            Console.ReadKey();




        }
    }
}
