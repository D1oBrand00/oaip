using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme18Pr1
{
    /// <summary>
    /// Класс-потомок абстрактного класса Person
    /// </summary>
    class Ukrainian : Person
    {
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Ukrainian() { }
        /// <summary>
        /// Конструктор с 1 параметром
        /// </summary>
        /// <param name="name">Имя человека</param>
        public Ukrainian(string name)
        {
            this.Name = name;
        }
        /// <summary>
        /// Переопределённый метод из класса Person
        /// </summary>
        public override void Greeting()
        {
            Console.WriteLine($"Привiт, {Name}");
        }

    }
}
