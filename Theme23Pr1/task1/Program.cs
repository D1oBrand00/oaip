using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    enum Months { январь, февраль, март,апрель, май, июнь, июль, август, сентябрь, октябрь, ноябрь, декабрь}
    class Program
    {
        static void Main(string[] args)
        {
            foreach(Months m in Enum.GetValues(typeof(Months)))
            {
                Console.WriteLine($"{(int)m}\t{m}");
            }
            Console.ReadLine();
        }
    }
}
