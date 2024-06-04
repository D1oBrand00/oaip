    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Car: Vehicle
    {
        public int Power { get; set; }
        public Car(int price, int maxspeed, int year,int power) : base(price, maxspeed, year)
        {
            this.Power = power;
        }
        public override void Output()
        {
            Console.WriteLine($"Машина\nЦена: {Price}\nМаксимальная скорость: {MaxSpeed}\nГод выпуска: {Year}\nМощность автомобиля: {Power}");
        }
        public static Car Input()
        {
            Console.Write($"Введите цену: ");
            int price = int.Parse(Console.ReadLine());
            Console.Write($"Введите максимальную скорость: ");
            int maxspeed = int.Parse(Console.ReadLine());
            Console.Write($"Введите год: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write($"Введите мощность автомобиля: ");
            int maxcapacity = int.Parse(Console.ReadLine());
            return new Car(price, maxspeed, year,maxcapacity);

        }
    }
}
