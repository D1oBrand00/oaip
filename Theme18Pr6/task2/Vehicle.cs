using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    abstract class Vehicle
    {
        public int Price { get; set; }
        public int MaxSpeed { get; set; }
        public int Year{ get; set; }
        public Vehicle() { }
        public Vehicle(int price, int maxspeed, int year)
        {
            this.Price = price;
            this.MaxSpeed = maxspeed;
            this.Year = year;
        }

        public abstract void Output();


    }
}
