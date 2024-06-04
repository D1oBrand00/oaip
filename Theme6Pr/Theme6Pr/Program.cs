using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme6Pr
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1. Вывести на экран в столбик целые числа из интервала от 1 до n (для решения задачи использовать операторы циклов: for, while, do-while).
            //Console.Write("Введите n ");
            //int n = int.Parse(Console.ReadLine());
            //int i = 1;
            //for (i = 1; i <= n; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //while (i <= n)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //while (i <= n);

            //Задача 2. Вывести четные двузначные числа и подсчитать их количество.
            //int count = 0;
            //for (int i = 10; i <= 99; i++)
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine($"{i}\t {count}");
            //        count++;
            //    }



            //Задача 3. Составьте таблицу значений функции y = 2х2+4x-5 на отрезке [-5; 5] с шагом h = 0,2 (для решения задачи использовать операторы циклов: for, while, do-while).
            //double x = -5;
            //for (; x <= 5; x += 0.2)
            //{
            //    Console.WriteLine($"При x = {x}  y = {2 * Math.Pow(x, 2) + 4 * x - 5}");
            //}

            //Задача 4. Найти сумму чисел, кратных 5, в пределах от 0 до 1000.
            //int x = 0;
            //for (int i = 0; i <= 1000; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        x += i;
            //    }

            //}
            //Console.Write($"{x}");

            //Задача 5. Определить количество цифр заданного числа.
            Console.Write("Введите число ");
            int x = int.Parse(Console.ReadLine());
            int count = 0;
                while (x != 0)
                {
                    x /= 10;
                    count++;
                }
                Console.WriteLine($"{count}");



            Console.ReadKey();
}






}
} 


