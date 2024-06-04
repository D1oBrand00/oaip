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
            MyClass mc = new MyClass(3,4);
            IInterface mcc = new MyClass(4, 3);
            mcc.Output();
            Console.ReadKey();
        }
    }
}
