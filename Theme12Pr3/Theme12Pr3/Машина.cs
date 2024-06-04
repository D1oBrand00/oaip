using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme12Pr3
{
    /// <summary>
    /// Класс, описывающий машину
    /// </summary>
    class Машина
    {
        /// <summary>
        /// Поле названия марки машины
        /// </summary>
        public string brand;
        /// <summary>
        /// Поле названия модели машины
        /// </summary>
        public string model;
        /// <summary>
        /// Поле номера машины
        /// </summary>
        public int number;
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Машина() { }
        /// <summary>
        /// Конструктор с тремя параметрами
        /// </summary>
        /// <param name="brand">марка машины</param>
        /// <param name="model">модель машины</param>
        /// <param name="number">номер машины</param>
        public Машина(string brand, string model, int number)
        {
            this.brand = brand;
            this.model = model;
            this.number = number;
        }
        /// <summary>
        /// Метод вывода информации о текущем состоянии машины
        /// </summary>
        /// <returns>модель,марка,номер машины</returns>
        public string Start()
        {
            return $"Машина {model} {brand} {number} завелась"; //Frazer Nash BMW 328
        }
        /// <summary>
        /// Метод вывода информации о текущем состоянии машины
        /// </summary>
        /// <returns>модель,марка,номер машины</returns>
        public string Stop()
        {
            return $"Машина {model} {brand} {number} остановилась"; //Frazer Nash BMW 328
        }
    }
}
