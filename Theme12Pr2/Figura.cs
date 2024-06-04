using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme12Pr2
{
    /// <summary>
    /// Класс, описывающий параметры фигуры
    /// </summary>
    class Figura
    {
        /// <summary>
        /// Поле названия фигуры
        /// </summary>
        public string nameFigura;
        /// <summary>
        /// Поле значения стороны A фигуры
        /// </summary>
        public int a;
        /// <summary>
        /// Поле значения стороны B фигуры
        /// </summary>
        public int b;
        /// <summary>
        /// Поле значения стороны C фигуры
        /// </summary>
        public int c;
        /// <summary>
        /// Поле значения стороны D фигуры
        /// </summary>
        public int d;
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Figura() { }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="nameFigura">название фигуры</param>
        /// <param name="a">сторона A</param>
        /// <param name="b">сторона B</param>
        /// <param name="c">сторона C</param>
        /// <param name="d">сторона D</param>
        public Figura (string nameFigura, int a, int b, int c, int d)
        {
            this.nameFigura = nameFigura;
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public string ShowArea()
        {
            return $"Название фигуры - {nameFigura}\nСторона А - {a} см\nСторона B - {b} см\nСторона C - {c} см\nСторона D - {d} см\nПлощадь - {a*b*c*d} кв.см";
        }
    }
}
