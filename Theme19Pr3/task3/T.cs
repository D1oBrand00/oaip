using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class T:IComparable<T>
    {
        public string Identifier { get; set; }
        public string Brand { get; set; }
        public int MaxSpeed { get; set; }
        public double Cost { get; set; }
        public int Discount { get; set; }
        public double Dissscount()
        {
            return Cost - Cost * Discount / 100;
        }
        public int CompareTo(T obj)
        {
            return Cost.CompareTo(obj.Cost);
        }
        public void Output()
        {
            Console.WriteLine($"Идентификатор: {Identifier},Марка: {Brand},Скорость: {MaxSpeed}км/ч, Цена: {Dissscount()}, {Discount}%");
        }
    }
}
