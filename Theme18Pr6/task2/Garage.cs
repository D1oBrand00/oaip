using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Garage
    {
        List<Vehicle> veh = new List<Vehicle>();
        public void AddCar(Car carrr)
        {
            veh.Add(carrr);
        }
        public void AddBicycle(Bicycle biccc)
        {
            veh.Add(biccc);
        }
        public void AddLorry(Lorry lorrr)
        {
            veh.Add(lorrr);
        }
        public void GetAllCar()
        {
            foreach (var elem in veh)
            {
                if (elem is Car)
                {
                    elem.Output();
                }

            }
        }
        public void GetAllBicycle()
        {
            foreach (var elem in veh)
            {
                if (elem is Bicycle)
                {
                    elem.Output();
                }

            }
        }
        public void GetAllLorry()
        {
            foreach (var elem in veh)
            {
                if (elem is Lorry)
                {
                    elem.Output();
                }

            }
        }
    }
}
