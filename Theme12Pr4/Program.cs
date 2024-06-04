using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme12Pr4
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Задание 1.
            Figures figure1 = new Figures(); //объект figure1 класса Figures, с использованием конструктора без параметров
            Console.WriteLine(figure1.ShowInfo1());
            Console.WriteLine($"{figure1.PandS1()}\n");
            Figures figure2 = new Figures("Прямоугольник", 5, 9); //объект figure2 класса Figures, с использованием конструктора с параметрами
            Console.WriteLine(figure2.ShowInfo2());
            Console.WriteLine($"{figure2.PandS2()}\n");
            Console.Write("name - ");
            string name = Console.ReadLine();
            Console.Write("side1 - ");
            int side1 = int.Parse(Console.ReadLine());
            Console.Write("side2 - ");
            int side2 = int.Parse(Console.ReadLine());
            Console.Write("side3 - ");
            int side3 = int.Parse(Console.ReadLine());
            Figures figure3 = new Figures(name, side1, side2, side3); //объект figure3 класса Figures, с использованием конструктора c параметрами, введёнными с клавиатуры
            Console.WriteLine(figure3.ShowInfo3());
            Console.WriteLine($"{figure3.PandS3()}\n");
            Figures figure4 = new Figures("Квадрат",4,4); 
            Console.WriteLine(figure4.ShowInfo1());
            Console.WriteLine($"{figure4.PandS1()}\n");
            Figures figure5 = new Figures
            {
                name = "Прямоугольник",
                side1 = 5,
                side2 = 4
            };
            Console.WriteLine(figure5.ShowInfo2());
            Console.WriteLine($"{figure5.PandS2()}\n");


            //Задание 2. Создайте проект, в котором опишите класс для решения задачи Вашего варианта
            Employee sotr = new Employee()
                string name = Sotr.ToString();
            Console.Read();

        }
    }
}
