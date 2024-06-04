using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme12Pr3
{
    /// <summary>
    /// Класс, описывающий время
    /// </summary>
    class Time
    {
        /// <summary>
        /// Поле значения чаов
        /// </summary>
        public int hour;
        /// <summary>
        /// Поле значения минут
        /// </summary>
        public int min;
        /// <summary>
        /// Поле значения секунд
        /// </summary>
        public int sec;
        /// <summary>
        /// Констрктор без параметров
        /// </summary>
        public Time()
        {
            hour = 1;
            min = 1;
        }
        /// <summary>
        /// Конструктор с двумя параметрами
        /// </summary>
        /// <param name="hour">час</param>
        /// <param name="min">минуты</param>
        public Time(int hour, int min)
        {
            this.hour = hour;
            this.min = min;
        }
        /// <summary>
        /// Метод вывода строки с информацией о времени
        /// </summary>
        /// <returns>часы,минуты</returns>
        public string ToString()
        {
            return $"Кол-во часов - {hour}\tКол-во минут - {min}";
        }
        /// <summary>
        /// Метод вывода общего кол-ва минут
        /// </summary>
        /// <returns>часы,минуты</returns>
        public string ToString2()
        {
            return $"Общее кол-во минут - {hour * 60 + min}";
        }
        /// <summary>
        /// Конструктор с треями параметрами
        /// </summary>
        /// <param name="hour">час</param>
        /// <param name="min">минуты</param>
        /// <param name="sec">секунды</param>
        public Time(int hour, int min, int sec):
            this(hour, min)
        {
            this.sec = sec;
        }
        /// <summary>
        /// Метод вывода строки с информацией о времени
        /// </summary>
        /// <returns>час,минуты,секунды</returns>
        public string ToString3()
        {
            return $"Кол-во часов - {hour}\tКол-во минут - {min}\tКол-во секунд - {sec}";
        }
        /// <summary>
        /// Метод вывода общего кол-ви секунд
        /// </summary>
        /// <returns>час,минуты,секунды</returns>
        public string ToString4()
        {
            return $"Общее кол-во секунд - {hour * 60 * 60 + min * 60 + sec}";
        }
        


    }
}
