using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    /// <summary>
    /// Класс, описывающий туристическую фирму
    /// </summary>
    class TourFirm :IComparable<TourFirm>
    {
        /// <summary>
        /// Поле названия фирмы
        /// </summary>
        string name;
        /// <summary>
        /// Поле года создания фирмы
        /// </summary>
        int year;
        /// <summary>
        /// Поле ИНН фирмы
        /// </summary>
        string identificationNumber;
        /// <summary>
        /// Поле прибыли за текущий год фирмы
        /// </summary>
        double income;
        /// <summary>
        /// Свойства полей
        /// </summary>
        public string Name { get; set; }
        public int Year { get; set; }
        public string IdentificationNumber { get; set; }
        public double Income { get; set; }
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public TourFirm() { }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="name">название фирмы</param>
        /// <param name="year">год создания фирмы</param>
        /// <param name="identificationNumber">ИНН фирмы</param>
        /// <param name="income">доход за текущий год фирмы</param>
        public TourFirm(string name, int year, string identificationNumber, double income)
        {
            this.name = name;
            this.year = year;
            this.identificationNumber = identificationNumber;
            this.income = income;
        }
        public void Output()
        {
            Console.WriteLine($"Название фирмы: {Name}\nГод создания фирмы: {Year}\nИНН фирмы: {IdentificationNumber}\nДоход за текущий год фирмы: {Income}р\n");
        }
        /// <summary>
        /// Статический метод для ввода данных
        /// </summary>
        /// <returns></returns>
        public static TourFirm Input()
        {
            Console.WriteLine("Введите название фирмы");
            string name = Console.ReadLine();
            Console.WriteLine("Введите год создани фирмы");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ИНН фирмы");
            string identificationNumber = Console.ReadLine();
            Console.WriteLine("Введите доход за текущий год фирмы");
            double income = double.Parse(Console.ReadLine());
            return new TourFirm(name, year, identificationNumber, income);
        }
        /// <summary>
        /// Метод сравнения по прибыли
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(TourFirm obj)
        {
            return Income.CompareTo(obj.Income);
        }
    }
}
