using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme12Pr2
{
    /// <summary>
    /// Класс, который выводит параметры компьютера
    /// </summary>
    class Computer
    {
        /// <summary>
        /// Поле модели компьютера
        /// </summary>
        public string model;
        /// <summary>
        /// Поле значения объёма ОЗУ
        /// </summary>
        public int ram;
        /// <summary>
        /// Поле значения объёма жёсткого диска
        /// </summary>
        public int hdd;
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Computer() { }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="model">модель компьютера</param>
        /// <param name="ram">объём ОЗУ</param>
        /// <param name="hdd">объём жёсткого диска</param>
        public Computer(string model, int ram, int hdd)
        {
            this.model = model;
            this.ram = ram;
            this.hdd = hdd;
        }
        /// <summary>
        /// Метода вывода параметров компьютера
        /// </summary>
        /// <returns>модель,ОЗУ,HDD</returns>
        public string Info()
        {
            return $"Модель компьютера - {model}, объём ОЗУ - {ram} ГБ, объём жёсткого диска- {hdd} Т";
        }


    }
}
