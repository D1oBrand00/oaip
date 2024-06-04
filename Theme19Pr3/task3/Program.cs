using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<T> t = new List<T>();
            t.Add(new T { Identifier = "JG24V", Brand ="БМВ", MaxSpeed = 200, Cost = 5000000, Discount = 6 });
            t.Add(new T { Identifier = "NFV32", Brand = "Мерседес", MaxSpeed = 160, Cost = 3753560, Discount = 10 });
            t.Add(new T { Identifier = "BND83", Brand = "Тойота", MaxSpeed = 190, Cost = 4560000, Discount = 1 });
            t.Add(new T { Identifier = "ADRT2", Brand = "Ауди", MaxSpeed = 120, Cost = 1674000, Discount = 13 });
            t.Sort();
            foreach (var elem in t)
            {
                elem.Output();
            }
            Console.ReadKey();
        }
    }
}
