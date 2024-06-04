using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme18Pr1
{ 
    /// <summary>
    /// Абстрактный класс человека
    /// </summary>
    abstract class Person

    {
        /// <summary>
        /// Поле имени человека
        /// </summary>
        string name;
        /// <summary>
        /// Свойства поля name
        /// </summary>
        public string Name { get => name; set => name = value; }
        /// <summary>
        /// Абстрактный метод приветствия
        /// </summary>
        public abstract void Greeting();
    }
}
