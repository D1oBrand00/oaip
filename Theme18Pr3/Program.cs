using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme18Pr3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool t = true;
            bool tt = true;
            List<Figure> fig = new List<Figure>();
            while (t)
            {
                Console.Write("Действия с фигурой:\nДобавить объект - add\nПросмотреть весь список - showall\nПросмотреть значение всех свойств объекта - show\nРедактировать объект - change\nУдалить объект - delete\n\n");
                string action = Console.ReadLine();
                switch (action.ToLower())
                {
                    case "add":
                        while(tt)
                        {
                            Console.Write($"Какую добавить фигуру(Прямоугольник,квадрат,треугольник, окружность)\nВыйти - q\n");
                            string figure = Console.ReadLine();

                            switch (figure.ToLower())
                            {
                                case "прямоугольник":
                                    fig.Add(Rectangle.Input());

                                    break;
                                case "квадрат":
                                    fig.Add(Square.Input());
                                    break;
                                case "треугольник":
                                    fig.Add(Triangle.Input());
                                    break;
                                case "окружность":
                                    fig.Add(Circle.Input());
                                    break;
                                case "q":
                                    tt = false;
                                    break;
                            }
                        }
                        tt = true;
                        break;
                    case "showall":
                        foreach (var elem in fig)
                        {
                            elem.Print();
                            Console.WriteLine();
                        }
                        break;
                    case "show":
                        while (tt)
                        {
                            Console.Write($"Просмотреть значение всех свойств объектов (Прямоугольник,квадрат,треугольник, окружность)\nВыйти - q\n");
                            string figure = Console.ReadLine();
                            Console.Write($"Номер объекта ");
                            int n = int.Parse(Console.ReadLine());
                            switch (figure.ToLower())
                            {

                                case "прямоугольник":
                                    fig[n].Print();
  
                                    
                                    break;
                                case "квадрат":
                                    fig[n].Print();
                                    break;
                                case "треугольник":
                                    fig[n].Print();
                                    break;
                                case "окружность":
                                    fig[n].Print();
                                    break;
                                case "q":
                                    tt = false;
                                    break;
                            }
                        }
                        tt = true;
                        break;
                    case "change":
                        while (tt)
                        {
                            Console.Write($"Редактировать значение любого из свойств объектов (Прямоугольник,квадрат,треугольник, окружность)\nВыйти - q\n");
                            string figure = Console.ReadLine();
                            Console.Write($"Номер объекта ");
                            int n = int.Parse(Console.ReadLine());
                            switch (figure.ToLower())
                            {

                                case "прямоугольник":
                                    fig[n] = Rectangle.Input();

                                    break;
                                case "квадрат":
                                    fig[n] = Square.Input();
                                    break;
                                case "треугольник":
                                    fig[n] = Triangle.Input();
                                    break;
                                case "окружность":
                                    fig[n] = Circle.Input();
                                    break;
                                case "q":
                                    tt = false;
                                    break;
                            }
                            
                        }
                        tt = true;
                        break;
                    case "delete":
                        while (tt)
                        {
                            Console.Write($"Удалить любой из объектов (Прямоугольник,квадрат,треугольник, окружность)\nВыйти - q\n");
                            string figure = Console.ReadLine();
                            Console.Write($"Номер объекта ");
                            int n = int.Parse(Console.ReadLine());
                            switch (figure.ToLower())
                            {

                                case "прямоугольник":
                                    fig.RemoveAt(n);

                                    break;
                                case "квадрат":
                                    fig.RemoveAt(n);
                                    break;
                                case "треугольник":
                                    fig.RemoveAt(n);
                                    break;
                                case "окружность":
                                    fig.RemoveAt(n);
                                    break;
                                case "q":
                                    tt = false;
                                    break;
                            }

                        }
                        tt = true;
                        break;
                    default:
                        t = false;
                        break;
                        


                }

            }    
            
            Console.ReadKey();


        }
    }
}
