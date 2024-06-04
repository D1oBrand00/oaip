using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme14Pr2
{
    /// <summary>
    /// Нестатический класс
    /// </summary>
    class Point
    {
        /// <summary>
        /// Поле координаты x
        /// </summary>
        private double x;
        public double GetX
        {
            get { return x = GetX; }
        }
        public double SetX
        {
            set { SetX = x; }
        }

        /// <summary>
        /// Поле координаты y
        /// </summary>
        private double y;
        public double GetY
        {
            get { return y = GetY; }
        }
        public double SetY
        {
            set { SetY = y; }
        }

        /// <summary>
        /// Поле счётчика
        /// </summary>
        public static int count;

        /// <summary>
        /// Конструктор с параметрами, принимающий координаты точки
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Point(double x, double y)
        {
            this.y = y;
            this.x = x;

            if(x>0 && y > 0)
            {
                FirstField++;
            }
            if(x<0& y > 0)
            {
                SecondField++;
            }
            if (x < 0 && y < 0)
            {
                ThirdField++;
            }
            if(x>0&&y<0)
            {
                FourthField++;
            }
            count++;
        }
        /// <summary>
        /// Статический конструктор, инициализирующий count нулём
        /// </summary>
        static Point()
        {
            count = 0;
        }

        private static double FirstField, SecondField, ThirdField, FourthField;
       
        /// <summary>
        /// Метод вывода координат точки
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"x:{x}||y:{y}");
        }
        /// <summary>
        /// Метод вывода кол-ва точек в каждой коорд. плоскости и общее кол-во точек
        /// </summary>
        public static void TotalCount()
        {
            Console.WriteLine($"FirstField-{FirstField}\nSecondField-{SecondField}\nThirdField-{ThirdField}\n FourthsField-{FourthField}\nTotalCount-{count}");
        }
        


    }




}
