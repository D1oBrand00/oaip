using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle<double> tr1 = new Triangle<double>(5, 10, 10);
            Triangle<double> tr2 = new Triangle<double>(3, 5, 5);
            Console.WriteLine($"{tr2.Square():F2}");
            Console.ReadKey();
        }
    }
}
