using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class Ab : A
    {
        int x = 4;
        public override double GetSqrt()
        {
            return Math.Sqrt(x);
        }
        public override double GetSquare()
        {
            return Math.Pow(x,2);
        }
        public void Output2()
        {
            Console.WriteLine($"{x}\nx^2 = {GetSquare()}\nКорень x = {GetSqrt()}");
        }
    }
}
