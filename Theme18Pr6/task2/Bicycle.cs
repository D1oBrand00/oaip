using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Bicycle : Vehicle
    {
        public int MaxPassengers { get; set; }
        public Bicycle(int price, int maxspeed, int year, int maxpassengers) : base(price, maxspeed, year)
        {
            this.MaxPassengers = maxpassengers;
        }
        public override void Output()
        {
            Console.WriteLine($"Велосипед\nЦена: {Price}\nМаксимальная скорость: {MaxSpeed}\nГод выпуска: {Year}\nКол-во пассажиров: {MaxPassengers}");
        }
        public static Bicycle Input()
        {
            Console.Write($"Введите цену: ");
            int price = int.Parse(Console.ReadLine());
            Console.Write($"Введите максимальную скорость: ");
            int maxspeed = int.Parse(Console.ReadLine());
            Console.Write($"Введите год: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write($"Введите кол-во пассажиров: ");
            int maxpassangers = int.Parse(Console.ReadLine());
            return new Bicycle(price, maxspeed, year, maxpassangers);

        }
    }
}
