using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme12Pr2
{
    /// <summary>
    /// Класс, описывающий проект строение
    /// </summary>
    class Build
    {
        /// <summary>
        /// Поле названия строения
        /// </summary>
        public string name;
        /// <summary>
        /// Поле площади строения
        /// </summary>
        public int area;
        /// <summary>
        /// Поле количества жильцов 
        /// </summary>
        public int kvo;
        /// </summary>
        /// Поле количества этажей строения
        /// </summary>
        public int floor;
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Build() 
        {
            this.name = "Дача";
            this.area = 200;
            this.kvo = 5;
        }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="name">Название</param>
        /// <param name="are">Площадь</param>
        /// <param name="kvo">Количество жильцов</param>
        public Build(string name, int area, int kvo)
        {
            this.name = name;
            this.area = area;
            this.kvo = kvo;
        }
        /// <summary>
        /// Метод вывода информации о строении
        /// </summary>
        /// <returns>название, площадь, кол-во жильцов, пл на 1 жильца</returns>
        public string ShowInfo()
        {
            return $"Название строения - {name}\nПлощадь стррения - {area} кв.м\nКоличество жильцов - {kvo}\nПлощадь на одного жильца - {area/kvo}";

        }
        public Build(string name, int area, int kvo, int floor):
            this(name,area,kvo)
        {
            this.floor = floor;
        }
        /// <summary>
        /// Метод вывода информации о строении 
        /// </summary>
        /// <returns>название, площадь, кол-во жильцов,пл на 1 жильца, кол-во этажей</returns>
        public string ShowInfo2()
        {
            return $"Название строения - {name}\nПлощадь стррения - {area} кв.м\nКоличество жильцов - {kvo}\nПлощадь на одного жильца - {area / kvo}\nКоличество этажей - {floor}";

        }

    }
}
