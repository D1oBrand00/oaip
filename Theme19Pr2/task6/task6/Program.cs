using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Aa> g = new List<Aa>();
            g.Add(new Aa());
            foreach (var elem in g)
            {
                elem.Output();
            }
            
            Console.WriteLine();
            List<Ab> gg = new List<Ab>();
            gg.Add(new Ab());
            foreach(var elem in gg)
            {
                elem.Output2();
            }    
            
            Console.ReadKey();
        }
    }
}
