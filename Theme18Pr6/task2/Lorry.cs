using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Lorry : Vehicle
    {
        public int MaxCapacity { get; set; }
        public Lorry(int price, int maxspeed, int year, int maxcapacity) : base(price, maxspeed, year)
        {
            this.MaxCapacity = maxcapacity;
        }
        public override void Output()
        {
            Console.WriteLine($"Грузовик\nЦена: {Price}\nМаксимальная скорость: {MaxSpeed}\nГод выпуска: {Year}\nМаксимальная ёмкость: {MaxCapacity}т");
        }
        public static Lorry Input()
        {
            Console.Write($"Введите цену: ");
            int price = int.Parse(Console.ReadLine());
            Console.Write($"Введите максимальную скорость: ");
            int maxspeed = int.Parse(Console.ReadLine());
            Console.Write($"Введите год: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write($"Введите максимальную ёмкость: ");
            int maxcapacity = int.Parse(Console.ReadLine());
            return new Lorry(price, maxspeed, year, maxcapacity);

        }
    }
}
