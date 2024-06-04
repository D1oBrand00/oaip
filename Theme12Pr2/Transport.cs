using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme12Pr2
{
    /// <summary>
    /// Класс, описывающий параметры транспорта
    /// </summary>
    class Transport
    {
        /// <summary>
        /// Поле типа транспорта
        /// </summary>
        public string name;
        /// <summary>
        /// Поле цвета транспорта
        /// </summary>
        public string color;
        /// <summary>
        /// Поле значения скорости транспорта
        /// </summary>
        public int speed;
        /// <summary>
        /// Поле значения массы транспорта
        /// </summary>
        public int weight;
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Transport() { }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="name">тип транспорта</param>
        /// <param name="color">цвет транспорта</param>
        /// <param name="speed">скорость транспорта</param>
        /// <param name="weight">масса транспорта</param>
        public Transport(string name,string color, int speed, int weight)
        {
            this.name = name;
            this.color = color;
            this.speed = speed;
            this.weight = weight;
        }
        /// <summary>
        /// Метод вывода информации о транспорте
        /// </summary>
        /// <returns>тип , цвет, скорость, масса транспорта</returns>
        public string ShowInfo()
        {
            return $"Тип транспорта - {name}\nЦвет транспорта - {color}\nСкорость транспорта - {speed} км/ч\nМасса транспорта - {weight} тонна";
        }
    }
}
