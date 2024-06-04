using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Triangle<T>
    {
        T a;
        T b;
        T c;
        public T A { get { return a; } set { dynamic x = b; dynamic y = c; dynamic z = 0; ; a = a < x + y ? value : z; } }
        public T B { get { return b; } set { dynamic x = a; dynamic y = c; dynamic z = 0; b = b < x + y ? value : z; } }
        public T C { get { return c; } set { dynamic x = b; dynamic y = a; dynamic z = 0; c = c < x + y ? value : z; } }
        public Triangle(T a, T b, T c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public T Per()
        {
            dynamic x = a;
            dynamic y = b;
            dynamic z = c;
            return x + y + z;
        }
        public T Square()
        {
           
                dynamic p = Per();
                p /= 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
           

        }
    }
        


    
}
