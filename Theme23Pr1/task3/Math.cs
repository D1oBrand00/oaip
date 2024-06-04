using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Math
    {
        public double Sum(double x, double y)
        {
            return x + y;
        }
        public double Sub(double x, double y)
        {
            return x - y;
        }
        public double Mult(double x, double y)
        {
            return x * y;
        }
        public double Div(double x, double y)
        {
            return x / y;
        }
        public void OutPutSum(double x, double y)
        {
            Console.WriteLine($"{x}+{y}={Sum(x, y)}");
        }
        public void OutPutSub(double x, double y)
        {
            Console.WriteLine($"{x}-{y}={Sub(x, y)}");
        }
        public void OutPutMult(double x, double y)
        {
            Console.WriteLine($"{x}*{y}={Mult(x, y)}");
        }
        public void OutPutDiv(double x, double y)
        {
            Console.WriteLine($"{x}/{y}={Div(x, y)}");
        }
        static public double InPutX()
        {
            Console.Write($"Введите x: ");
            double x = double.Parse(Console.ReadLine());
            return x;
        }
        static public double InPutY()
        {
            Console.Write($"Введите y: ");
            double y = double.Parse(Console.ReadLine());
            return y;
        }
    }
}
