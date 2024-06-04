using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    abstract class A : IInterfaceA, IInterfaceB
    {
        int x = 6;
        int y = 3;
        public int Sum()
        {
            return x + y;
        }
        public int Sub()
        {
            return x - y;
        }
        public int Mult()
        {
            return x * y;
        }
        public double Div()
        {
            return x / y;
        }
        public void Output()
        {
            Console.WriteLine($"{x}\n{y}\n{x} + {y} = {Sum()}\n{x} - {y} = {Sub()}\n{x} * {y} = {Mult()}\n{x} / {y} = {Div()}");
        }
        public abstract double GetSquare();
        public abstract double GetSqrt();

    }
}
