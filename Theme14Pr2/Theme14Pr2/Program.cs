using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme14Pr2
{
    class Program
    {
        static void Main(string[] args)
        {
            Point[] points = new Point[5];
            for(int i=0; i < points.Length; i++)
            {
                Console.Write("x=");
                double x = double.Parse(Console.ReadLine());
                Console.Write("y=");

                double y = double.Parse(Console.ReadLine());
                Console.WriteLine();

                points[i] = new Point(x, y);
            }
            //Point p1 = new Point(56,55);
            //p1.Print();
            //Console.ReadLine();
            //Point p2 = new Point(-5, -2);
            //p2.Print();
            Point.TotalCount();
            Console.ReadKey();

        }
    }
}
