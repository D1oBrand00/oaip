using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme12Pr3
{
    /// <summary>
    /// Класс, описывающий треугольник
    /// </summary>
    class Triangle
    {
        /// <summary>
        /// Поле значения a
        /// </summary>
        public double a;
        /// <summary>
        /// Поле значения b
        /// </summary>
        public double b;
        /// <summary>
        /// Поле значения c
        /// </summary>
        public double c;
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Triangle() { }
        /// <summary>
        /// Конструктор с тремя параметрами
        /// </summary>
        /// <param name="a">Значениеa</param>
        /// <param name="b">Значениеb</param>
        /// <param name="c">Значениеc</param>
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        /// <summary>
        /// Метод вывода информации о длинах сторон
        /// </summary>
        /// <returns>a,b,c</returns>
        public string ToString()
        {
            return $"Длина a = {a}\tДлина b = {b}\tДлина c = {c}";
        }
        /// <summary>
        /// Метод вывода информации о периметре
        /// </summary>
        /// <returns>a,b,c</returns>
        public string ToString2()
        {
            return $"Периметр треугольникв = {a + b + c}";
        }
        /// <summary>
        /// Конструктор с одним параметром
        /// </summary>
        /// <param name="a">Значение a</param>
        public Triangle(double a):
            this(a,a,a)
        {}
        /// <summary>
        /// Метод вывода информации о длинах сторон
        /// </summary>
        /// <returns>a,b,c</returns>
        public string ToString3()
        {
            return $"Длина a = {a}\tДлина b = {b}\tДлина c = {c}";
        }
        /// <summary>
        /// Метод вывода информации о периметре
        /// </summary>
        /// <returns>a,b,c</returns>
        public string ToString4()
        {
            return $"Периметр треугольника = {a + b + c}";
        }


    }
}
