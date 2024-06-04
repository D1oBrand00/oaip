using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {

            Garage g = new Garage();
            g.AddCar(Car.Input());
            g.AddBicycle(Bicycle.Input());
            g.AddLorry(Lorry.Input());
            g.GetAllCar();
            g.GetAllLorry();
            Console.ReadKey();
        }
    }
}
