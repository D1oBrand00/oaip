using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme11Pr1
{
    /// <summary>
    /// Класс, описывающий собаку
    /// </summary>
    class Dog
    {
        //Задание 3. Создать класс Dog с объектами Neapolitan Mastiff, Maltese, Chow Chow. Функциональность класса Dog представить полями: breed (порода), size (размер), age (возраст), color (цвет); методами: Eat() (есть), Sleep() (спать), Sit() (сидеть) и Run() (бегать).
        /// <summary>
        /// Поле названия породы собаки
        /// </summary>
        public string breed;
        /// <summary>
        /// Поле размера собаки
        /// </summary>
        public int size;
        /// <summary>
        /// Поле возраста собаки
        /// </summary>
        public int age;
        /// <summary>
        /// Поле цвета собаки
        /// </summary>
        public string color;
        /// <summary>
        /// Метод выводит информацию о том, собака ест
        /// </summary>
        /// <returns>eat</returns>
        public string Eat()
        {
            return $"cейчас ест";
        }
        /// <summary>
        /// Метод выводит информацию о том, собака спит
        /// </summary>
        /// <returns><sleep/returns>
        public string Sleep()
        {
            return $"cейчас спит";
        }
        /// <summary>
        /// Метод выводит информацию о том, собака сидит
        /// </summary>
        /// <returns>sit</returns>
        public string Sit()
        {
            return $"cейчас сидит";
        }
        /// <summary>
        /// Метод выводит информацию о том, собака бежит
        /// </summary>
        /// <returns>run</returns>
        public string Run()
        {
            return $"cейчас бежит";
        }
        /// <summary>
        /// Метод вывода информации о собаке
        /// </summary>
        /// <returns>breeed,size,age,color,eat,sleep,sit,run</returns>
        public override string ToString()
        {
            return $"Порода - {breed}\t Размер - {size} см\tВозраст - {age} лет\tЦвет - {color}\n{breed} {Eat()}\n{breed} {Sleep()}\n{breed} {Sit()}\n{breed} {Run()}";
        }
    }
}
