using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class MyClass : IInterface
    {
        public int Numberr { get; set; }
        public int X { get; set; }
        public MyClass() { }
        public MyClass(int number, int x)
        {
            this.Numberr = number;
            this.X = x;
        }
        public double GetPI()
        {
            return Math.PI;
        }
        public int Number()
        {
            return Numberr;
        }
        public double XSquare()
        {
            return Math.Pow(X, 2);
        }
        public double XSqrt()
        {
            return Math.Sqrt(X);
        }
        public void Output()
        {
            Console.WriteLine($"{GetPI():F2}\n{Number()}\n{XSquare()}\n{XSqrt()}");
        }
    }
}
