using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class DerivedClass : IInterface1, IInterface2, IInterface3
    {
        public void Method1()
        {
            Console.WriteLine("Метод Method1");
        }
        public void Method2()
        {
            Console.WriteLine("Метод Method2");
        }
        public void Method3()
        {
            Console.WriteLine("Метод Method3");
        }
    }
}
