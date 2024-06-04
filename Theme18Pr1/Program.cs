using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme18Pr1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Russian("Даниил"));
            people.Add(new Ukrainian("Данiiл"));
            people.Add(new Moldavian("Daniil"));
            foreach (var elem in people)
            {
                elem.Greeting();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
