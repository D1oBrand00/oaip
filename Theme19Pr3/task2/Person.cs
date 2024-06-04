using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{

    class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int CompareTo(Person obj)
        {
            return Name.CompareTo(obj.Name);
        }
        public void Output()
        {
            Console.WriteLine($"{Name}\t{Age}");
        }
    }
}
