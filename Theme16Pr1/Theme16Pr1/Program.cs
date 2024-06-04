using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme16Pr1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1. Вывести сообщение с информацией о текущей системной дате, применив несколько форматов.
            Console.WriteLine("Текущая дата:");
            DateTime dt1 = DateTime.Now;
            Console.WriteLine(dt1.ToShortDateString());
            Console.WriteLine($"{dt1:d}");
            Console.WriteLine($"{dt1.ToString("d")}");

            Console.WriteLine($"26 янв 2022 - {dt1.ToString("dd MMM yyyy")}");
            Console.WriteLine($"26 января 2022 г. - {dt1.ToLongDateString()}");
            Console.WriteLine($"Пт, 26 янв 2022{dt1.ToString("ddd, dd MMM yyyy")}");
            //Console.WriteLine($"четверг, 26 января 2022 - {dt2.ToString("dddd, dd MMMM yyyy")}");

            //Задание 2. Запросить с клавиатуры возраст человека и вывести на экран следующее сообщение: Ты родился в .... году
            Console.Write("Введите Ваш возраст: ");
            int age = int.Parse(Console.ReadLine());
            DateTime datetime = DateTime.Now.AddYears(-age);
            Console.WriteLine($"Ты родился в {datetime:yyyy} году");
            //or
            //Console.WriteLine(datetime.ToString("Ты родился в yyyy году"));

            //Задание 3. Определить возраст человека
            Console.Write("Введите год Вашего рождения: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Введите месяц Вашего рождения: ");
            int month = int.Parse(Console.ReadLine());
            DateTime datetime2 = DateTime.Now;
            Console.WriteLine($"Ваш возраст - {datetime2.AddYears(-year).AddMonths(-month):yy} лет");
            //or
            //datetime2 = DateTime.Now.AddYears(-year);
            //Console.WriteLine(datetime2.ToString("Ваш возраст - yy лет"));
            
            Console.ReadKey();




        }
    }
}
