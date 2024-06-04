using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme12Pr2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1.
            //Build dom1 = new Build();
            //Console.WriteLine($"{dom1.ShowInfo()}\n");
            //Build dom2 = new Build("Дом 345", 50, 3);
            //Console.WriteLine($"{dom2.ShowInfo()}\n");
            //Console.Write("Введите название строения ");
            //string name = Console.ReadLine();
            //Console.Write("Введите площадь строения ");
            //int area = int.Parse(Console.ReadLine());
            //Console.Write("Введите количество жильцов ");
            //int kvo = int.Parse(Console.ReadLine());
            //Console.Write("Введите количество этажей ");
            //int floor = int.Parse(Console.ReadLine());
            //Build dom3 = new Build(name, area, kvo, floor);
            //Console.WriteLine();
            //Console.WriteLine($"{dom3.ShowInfo2()}\n");

            //Задание 2. Класс Computer. Метод Info выводит модель (IBM, Asus, Sony) и параметры компьютера (объем ОЗУ и жесткого диска)
            //Computer pc = new Computer("Asus", 8, 2);
            //Console.WriteLine($"{pc.Info()}");

            //Задание 3.  Kласс Transport. Метод ShowInfo выводит параметры транспортного средства: тип (автомобиль, мотоцикл, велосипед), цвет, скорость, масса
            //Transport car = new Transport("автомобиль", "чёрный", 55, 1);
            //Console.WriteLine($"{car.ShowInfo()}\n");

            //Задание 4.Класс Figura.Метод ShowArea выводит название(квадрат, прямоугольник) и параметры фигуры(стороны), вычисляет и выводит площадь
            Figura fig = new Figura("Квадрат", 3, 3, 3, 3);
            Console.WriteLine($"{fig.ShowArea()}\n");
            Console.Read();
        }
    }
}
