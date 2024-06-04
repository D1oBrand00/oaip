using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme12Pr4
{
    /// <summary>
    /// Класс, описывающий доход работника
    /// </summary>
    class Employee
    {
        /// <summary>
        /// Поле имени работника
        /// </summary>
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>
        /// Поле фамилии работника
        /// </summary>
        string surname;
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        /// <summary>
        /// Поле значения минимальной зарплаты
        /// </summary>
        int p;
        public int P
        {
            get { return p; }
            set { p = value; }
        }
        int k;
        public int K
        {
            get { return k; }
            set { k = value; }
        }
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Employee() { }
        /// <summary>
        /// Конструктор с тремя параметрчми
        /// </summary>
        /// <param name="name">имя сотрудника</param>
        /// <param name="surname">фамилия сотрудника</param>
        /// <param name="profit">доход сотрудника</param>
        public Employee(string name, string surname, int profit)
        {
            this.name = name;
            this.surname = surname;
            this.p = p;
        }
        public string ToString()
        {
            return $"ФИ сотрудника - {surname} {name}\t Доход - {p*k}";
        }
    }
}
