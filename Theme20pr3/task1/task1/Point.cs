using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Point<T>
    {
        T x;
        T y;
        public Point() { }
        public Point(T x, T y)
        {
            this.x = x;
            this.y = y;
        }

        public T X { get { return x; } set { x = value; } }
        public T Y { get { return x; } set { x = value; } }
        public void OutPut()
        {
            Console.Write($"x: {x}\ny: {y}\n\n");
        }
    }
}
