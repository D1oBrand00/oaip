using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme12Pr3
{
    /// <summary>
    /// Класс,описывающий газету
    /// </summary>
    class Газета
    {
        /// <summary>
        /// Поле название газеты
        /// </summary>
        public string nameNewspaper;
        /// <summary>
        /// Поле значения тиража газеты
        /// </summary>
        public int circulation;
        /// <summary>
        /// Поле кол-ва полос газеты
        /// </summary>
        public int newspaperStrip;
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Газета() { }
        /// <summary>
        /// Метод инициализации полей
        /// </summary>
        /// <param name="nameNewspaper">название</param>
        /// <param name="circulation">тираж</param>
        /// <param name="newspaperStrip">кол-во полос</param>
        public void Init(string nameNewspaper, int circulation, int newspaperStrip)
        {
            this.nameNewspaper = nameNewspaper;
            this.circulation = circulation;
            this.newspaperStrip = newspaperStrip;
        }
        /// <summary>
        /// Метод вывода информации о газете
        /// </summary>
        public void Info()
        {
            Console.WriteLine($"Название газеты - {nameNewspaper}\tТираж - {circulation}\tКол-во полос - {newspaperStrip}");
        }
        /// <summary>
        /// Метод изменения названия газеты
        /// </summary>
        /// <param name="newname">новое название</param>
        public void ChangeName(string newname)
        {
            this.nameNewspaper = newname;
        }
        /// <summary>
        /// Метод изменения кол-ва полос
        /// </summary>
        /// <param name="newstrip">новое значение полос</param>
        public void ChangeNumber(int newstrip)
        {
            this.newspaperStrip = newstrip;
        }
        /// <summary>
        /// Метод вывода информации о газете
        /// </summary>
        public void Info2()
        {
            Console.WriteLine($"Название газеты - {nameNewspaper}\tТираж - {circulation}\tКол-во полос - {newspaperStrip}");
        }
    }

}
