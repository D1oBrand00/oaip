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
            Tringle<int> tr1 = new Tringle<int>(-3, 3, 2);
            Tringle<double> tr2 = new Tringle<double>(5.5, 6.6, 7.6);
            tr1.OutPut();
            tr2.OutPut();
            Console.ReadKey();
        }
    }
}
