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
            Point<int> pint = new Point<int>(43,39);
            Point<uint> puint = new Point<uint>(10, 12);
            Point<double> pdouble = new Point<double>(23.3, 19.7);
            pint.OutPut();
            puint.OutPut();
            pdouble.OutPut();
            Console.ReadKey();
        }
    }
}
