using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Tringle<T>
    {
        T a;
        T b;
        T c;
        public T A
        {
            get { return a; }
            set {  dynamic bb = b; dynamic cc = c; dynamic z = 0; a = value < z ? z : value; }
        }
        public T B
        {
            get { return b; }
            set { dynamic aa = a;  dynamic cc = c; dynamic z = 0; b = value < z  ? z : value; }
        }
        public T C
        {
            get { return c; }
            set { dynamic aa = a; dynamic bb = b; dynamic z = 0; c = value < z ? z : value; }
        }
        public Tringle(T a, T b, T c)
        {
            
            this.A = a;
            this.B = b;
            this.C = c;
        }
        public void OutPut()
        {
            Console.Write($"Треугольник\na: {a}\nb: {b}\nc: {c}\nSquare: {Square():F2}\n\n");
        }
        public dynamic Square()
        {

                dynamic aa = A;
                dynamic bb = B;
                dynamic cc = C;
                dynamic p = (aa + bb + cc) / 2;
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c)); 

            
            
        }
    }
}
