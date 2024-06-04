using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        enum Days { Sat,Sun,Mon,Tue,Wed,Thu,Fri}
        static void Main(string[] args)
        {
            foreach(Days d in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine($"{d} имеет значение {(int)d}");
            }
            Console.ReadLine();
        }
    }
}
