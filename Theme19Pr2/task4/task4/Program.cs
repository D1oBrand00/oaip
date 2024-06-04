using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person pers1 = new Person();
            pers1.SpeaksLoudly();
            pers1.Think();
            pers1.SpeaksQuietly();
            Console.ReadKey();
        }
    }
}
