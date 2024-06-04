using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme11Pr1
{
    /// <summary>
    /// Класс Person, который представляет человека
    /// </summary>
    class Person
    {
        ////Задание 1. Создать класс Person с полями: имя, фамилия, возраст и методом вывода всех данных на консоль.
        /// <summary>
        /// Поле имени человека
        /// </summary>
        public string name;
        /// <summary>
        /// Поле фамилии человекв
        /// </summary>
        public string surname;
        /// <summary>
        /// Поле возраста человекв
        /// </summary>
        public int age;
        /// <summary>
        /// Метод, который выводит информацию о человке
        /// </summary>
        public void Info()
        {
            Console.WriteLine($"Имя - {name}\tФамилия - {surname}\tВозраст - {age}");
        }
        /// <summary>
        /// Метод вывода информации о человеке
        /// </summary>
        /// <returns>имя,фамилия,возраст</returns>
        //public string ToString()
        //{
        //    return $"Имя - {name}\tФамилия - {surname}\tВозраст - {age}";
        //}
        public override string ToString()
        {
            return $"Имя - {name}\tФамилия - {surname}\tВозраст - {age}";
        }
    }
}
