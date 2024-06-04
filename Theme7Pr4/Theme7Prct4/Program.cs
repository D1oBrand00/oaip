using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme7Prct4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Тема 8. Практикум 4(Полозюк)";
            //Задание 1.Вариант 4 Разработать программу с использованием класса StringBuilder, которая для заданной строки s удляет все подстроки substr;
            //Console.Write("Введите предложение ");
            //StringBuilder s = new StringBuilder(Console.ReadLine());
            //s.Replace("substr", "");
            //Console.WriteLine(s);
            //Console.ReadKey();

            //
            Console.Write("Введите предложение ");
            StringBuilder s = new StringBuilder(Console.ReadLine());

            string[] words = s.ToString().Split(' ', ',', ';', '.', ':', '!', '?', ')', '(');
            for (int i = 0; i < words.Length; i++)
            {
               
            }
            Console.WriteLine();
            Console.ReadKey();
        }   
    }
}
