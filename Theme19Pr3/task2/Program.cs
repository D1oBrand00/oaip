using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> pers = new List<Person>();
            pers.Add(new Person { Name = "Даниил",Age = 18});
            pers.Add(new Person { Name = "Артём", Age = 16 });
            pers.Add(new Person { Name = "Вова" , Age = 20});
            pers.Sort();
            foreach (var elem in pers)
            {
                elem.Output();
            }
            Console.ReadKey();
        }
    }
}
