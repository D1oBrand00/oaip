using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme7Pr2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1. Дано название футбольного клуба. Определить количество символов в нем.
            //Console.Write("Введите название футбольного клуба ");
            //string clb = Console.ReadLine();
            //Console.WriteLine($"Кол-во символов - {clb.Length}");

            //Задача 2.Дано название города. Определить, четно или нет количество символов в нем.
            //Console.Write("Введите название города ");
            //string city = Console.ReadLine();
            //string st = city.Length % 2 == 0 ? "чётно" : "не чётно";
            //Console.WriteLine($"Кол-во символов - {city.Length}, {st}");

            //Задача 3. Даны две фамилии. Определить, какая из них длиннее.
            //Console.Write("Введите первую фамилию ");
            //string a = Console.ReadLine();
            //Console.Write("Введите вторую фамилию ");
            //string b = Console.ReadLine();
            //if (a.Length > b.Length)
            //{ Console.WriteLine($"Фамилия {a} длиннее"); }
            //if (b.Length > a.Length)
            //{ Console.WriteLine($"Фамилия {b} длиннее"); }

            //Задача 4. Найти самое длинное слово из пяти введенных с клавиатуры.
            //string[] words = new string[5];
            //   string st = " ";
            //   for (int i = 0; i < 5; i++)
            //   {
            //    Console.Write($"Введите {i+1} слово ");
            //      words[i] = Console.ReadLine();
            //   }
            //   foreach(string word in words)
            //   {
            //       if (word.Length > st.Length)
            //       {
            //           st = word;
            //       }
            //   }
            //Console.WriteLine($"Самое длинное слово - {st}");


            //Задача 5.Составить программу, которая запрашивает отдельно имя и отдельно фамилию, а затем выводит их как одну символьную строку.
            //Console.Write("Введите имя ");
            //  string name = Console.ReadLine();
            //Console.Write("Введите фамилию ");
            //  string surname = Console.ReadLine();
            //Console.WriteLine($"{name +  surname}") ;

            //Задача 6.Подсчитать количество букв "а"("А") в строке.
            //Console.Write("Введите слово");
            //    string word = Console.ReadLine();
            //    int s = word.Split('a', 'A').Length - 1;
            //Console.WriteLine($"Кол-во букв А - {s}");

            //Задача 7.Подсчитать количество слов в предложении, при условии, что каждое слово отделяется от другого пробелом.
            Console.Write("Введите предложение ");
            string st = Console.ReadLine();
            int word = st.Split(' ').Length;
            Console.WriteLine($"Кол-во слов - {word}");



            Console.ReadKey();




        }
    }
}
