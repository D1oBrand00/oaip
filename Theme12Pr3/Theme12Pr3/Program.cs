using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme12Pr3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1. Создать класс с указанными двумя полями (Поле 1: вещественное число, Поле 2: вещественное число) и методами:
            //Sqrt number = new Sqrt(); // объект класса с использованием конструктора без параметров и присваивания значений полям объекта
            //Console.WriteLine(number.ToString());
            //Console.WriteLine($"{number.SquqreRoot()}\n");
            //Sqrt number1 = new Sqrt(5, 5); // объект класса с использованием явной инициализацией
            //Console.WriteLine($"{number1.ToString()}");
            //Console.WriteLine($"{number1.SquqreRoot()}\n");
            //Console.Write("x - ");
            //double x = double.Parse(Console.ReadLine());
            //Console.Write("y - ");
            //double y = double.Parse(Console.ReadLine());
            //Sqrt number2 = new Sqrt(x, y); // объект класса с использованием конструктора с двумя параметрами, введенными с клавиатуры
            //Console.WriteLine($"{number2.ToString()}");
            //Console.WriteLine($"{number1.SquqreRoot()}\n");

            //Задача 2.
            //Time obj1 = new Time(); // объект класса с использованием конструктора без параметров и присваивания значений полям объекта
            //Console.WriteLine($"{obj1.ToString()}");
            //Console.WriteLine($"{obj1.ToString2()}\n");
            //Time obj2 = new Time(2,1); // объект класса с использованием явной инициализацией
            //Console.WriteLine($"{obj2.ToString()}");
            //Console.WriteLine($"{obj2.ToString2()}\n");
            //Console.Write("Hour = ");
            //int h = int.Parse(Console.ReadLine());
            //Console.Write("Min = ");
            //int m = int.Parse(Console.ReadLine());
            //Console.Write("Sec = ");
            //int s = int.Parse(Console.ReadLine());
            //Time obj3 = new Time(h,m,s); // объект класса с использованием конструктора с тремя параметрами, введенными с клавиатуры
            //Console.WriteLine($"{obj3.ToString3()}");
            //Console.WriteLine($"{obj3.ToString4()}\n");

            //Задача 3.Создать класс Triangle, разработав следующие элементы класса:
            //Triangle abc = new Triangle(5, 10, 15);
            //Console.WriteLine($"{abc.ToString()}");
            //Console.WriteLine($"{abc.ToString2()}\n");
            //Triangle abc2 = new Triangle(5);
            //Console.WriteLine($"{abc2.ToString3()}");
            //Console.WriteLine($"{abc2.ToString4()}\n");

            ///Задача 4. Машина
            //Машина car = new Машина("Frazer Nash", "BMW", 328);
            //Console.WriteLine($"{car.Start()}");
            //Console.WriteLine($"{car.Stop()}\n");
            //Машина car2 = new Машина("Ranchero", "Ford", 1970);
            //Console.WriteLine($"{car2.Start()}");
            //Console.WriteLine($"{car2.Stop()}\n");
            //Машина car3 = new Машина("Civic", "Honda", 2022);
            //Console.WriteLine($"{car3.Start()}");
            //Console.WriteLine($"{car3.Stop()}\n");

            //Задача 5. Газета.
            Газета numb1 = new Газета();
            numb1.Init("Известия", 1000000, 30);
            numb1.Info();
            Газета numb2 = new Газета();
            numb2.Init("Ведомости", 500000, 45);
            numb2.Info();
            Газета numb3 = new Газета();
            numb3.Init("Взгляд.ру", 120000, 26);
            numb3.ChangeName("Газета.ру");
            numb3.ChangeNumber(56);
            numb3.Info();
            Console.Read();
        }
    }
}
