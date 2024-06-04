using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme5Pr
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1.Определить, является или нет текущий год високосным? Год ввести с клавиатуры(Год является високосным, если он кратен 4)
            //Console.Write("Введите год ");
            //int year = int.Parse(Console.ReadLine());
            //if (year % 4 == 0)                                    
            //{
            //    Console.WriteLine($"{year} - високосный год");
            //}
            //else
            //{
            //    Console.WriteLine($"{year} не високосный год");
            //}

            //Задача 2. Определить, входит ли цена выбранного ноутбука в диапазон от 20 до 30 тыс. р.
            //Console.Write("Введите цену ноутбука ");
            //int cost = int.Parse(Console.ReadLine());
            //string st = cost > 20000 && cost < 30000 ? "Цена выбранного ноутбука входит в диапазон от 20 до 30 тыс. р." : "Цена выбранного ноутбука не входит в диапазон от 20 до 30 тыс. р.";
            //Console.WriteLine(st);

            //Задача 3.Написать программу, которая в зависимости от заданного балла определяет оценку учащегося согласно таблице:
            //Console.Write("Введите балл ");
            //int b = int.Parse(Console.ReadLine());
            //if (b >= 0 && b < 60)
            //{ Console.WriteLine("Оценка неудовлитворительно"); }
            //if (b >= 60 && b <= 74)
            //{ Console.WriteLine("Оценка удовлитворительно"); }
            //if (b >= 75 && b <= 89)
            //{ Console.WriteLine("Оценка хорошо"); }
            //if (b >= 90 && b <= 100)
            //{ Console.WriteLine("Оценка отлично"); }

            //Задача 4.Светофор закодирован тремя состояниями: 1 – красный, 2 – желтый, 3 – зеленый.В зависимости от состояния определить цвет светофора
            //Random rnd = new Random();
            //int a = rnd.Next(1, 3);
            //switch (a)
            //{
            //    case 1:
            //        Console.WriteLine("Цвет светофора красный");
            //        break;
            //    case 2:
            //        Console.WriteLine("Цвет светофора желтый");
            //        break;
            //    case 3:
            //        Console.WriteLine("Цвет светофора зеленый");
            //        break;
            //}

            //Задача 5.Проверка знака случайного числа и его чётности.
            //Random rnd = new Random();
            //int a = rnd.Next();
            //if (a > 0)
            //{ Console.WriteLine($"{a} положительное"); }
            //else { Console.WriteLine($"{a} отрицательное"); }
            //if (a % 2 == 0)
            //{ Console.WriteLine($"{a} четное"); }
            //else { Console.WriteLine($"{a} не четное"); }

            //Задача 6.Выбор дня недели.
            //Console.Write("Введите номер дня недели ");
            //int day = int.Parse(Console.ReadLine());

            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("Понедельник");
            //        break;
            //    case 2:
            //        Console.WriteLine("Вторник");
            //        break;
            //    case 3:
            //        Console.WriteLine("Среда");
            //        break;
            //    case 4:
            //        Console.WriteLine("Четверг");
            //        break;
            //    case 5:
            //        Console.WriteLine("Пятница");
            //        break;
            //    case 6:
            //        Console.WriteLine("Суббота");
            //        break;
            //    case 7:
            //        Console.WriteLine("Воскресенье");
            //        break;
            //}

            //Задача 7.Проверка логина и пароля, введенных с клавиатуры.
            //string user = "guest243";
            //string pass = "qwertyu5677";
            //Console.Write("Введите логин");
            //string user1 = Console.ReadLine();
            //Console.Write("Введите пароль");
            //string pass1 = Console.ReadLine();
            //if (user1 == user && pass1 == pass)
            //{
            //    Console.WriteLine("Успешный вход");
            //}
            //else { Console.WriteLine("Неправильный логин или пароль"); }

            //Задача 8. Простейший калькулятор на 4 действия.
            //Console.Write("Введите x ");
            //double x = double.Parse(Console.ReadLine());
            //Console.Write("Введите y ");
            //double y = double.Parse(Console.ReadLine());
            //Console.WriteLine($"Add = {x + y}\nDiff = {x - y}\nMult = {x * y}\nDiv = {x / y}");

            //Задача 9. Вводится возраст человека и в консольное окно выводится возрастная группа, к которой относится человек.
            Console.Write("Введите возраст человека ");
            int age = int.Parse(Console.ReadLine());

            if (age >= 16 & age <= 20)
            {
                Console.WriteLine("Юношеский возраст");
            }
            if (age > 20 & age <= 50)
            {
                Console.WriteLine("Средний возраст");
            }
            if (age > 50 & age <= 75)
            {
                Console.WriteLine("Пожилой возраст");
            }
            if (age > 75 & age <= 90)
            {
                Console.WriteLine("Старческий возраст");
            }

            Console.ReadKey();


        }
    }
}
