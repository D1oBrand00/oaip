using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme12Pr3
{
    /// <summary>
    /// Класс с двумя вещественными числами
    /// </summary>
    class Sqrt
    {
        /// <summary>
        /// Поле значения x
        /// </summary>
        public double x;
        /// <summary>
        /// Поле значения y
        /// </summary>
        public double y;
        /// <summary>
        /// Констрктор без параметров
        /// </summary>
        public Sqrt()
        {
            x = 3;
            y = 4;
        }
        /// <summary>
        /// Конструктор с двумя параметрами
        /// </summary>
        /// <param name="x">Значение x</param>
        /// <param name="y">Значение y</param>
        public Sqrt(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        /// <summary>
        /// Метод вывода строки с информацией об объекте
        /// </summary>
        /// <returns></returns>
        public string ToString()
        {
            return $"x = {x}\ty = {y}\t";
        }
        /// <summary>
        /// Метод вывода значения корня произведения 
        /// </summary>
        /// <returns>x,y</returns>
        public string SquqreRoot()
        {
            return $"Корень произведения = { Math.Sqrt(x * y):f2}";
        }
    }

    
}
