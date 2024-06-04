using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme17Pr1
{
    class Person
    {
        /// <summary>
        /// Поле возраста
        /// </summary>
        int age;
        /// <summary>
        /// Поле имени
        /// </summary>
        string name;
        /// <summary>
        /// Поле фамилии
        /// </summary>
        string surname;

        /// <summary>
        /// Свойства полей
        /// </summary>
        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Person() { }
        /// <summary>
        /// Конструктор с одним параметром
        /// </summary>
        /// <param name="age"></param>
        public Person(int age)
        {
            this.Age = age;
        }
        /// <summary>
        /// Конструктор с двумя параметрами
        /// </summary>
        /// <param name="age"></param>
        /// <param name="name"></param>
        public Person(int age, string name) :
            this(age)
        {
            this.name = name;
        }
        /// <summary>
        /// Конструктор с тремя параметрами
        /// </summary>
        /// <param name="age"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        public Person(int age, string name, string surname) :
            this(age, name)
        {

            this.surname = surname;
        }
        /// <summary>
        /// Метод вывода
        /// </summary>
        //public void Print()
        //{
        //    Console.WriteLine($"Возраст - {age}\nИмя - {name}\nФамилия - {surname}");
        //}
        virtual public void Print()
        {
            Console.WriteLine($"Возраст - {age}\nИмя - {name}\nФамилия - {surname}");
        }

    }
}
