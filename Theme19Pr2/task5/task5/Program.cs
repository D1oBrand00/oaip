using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonalComputer> pc = new List<PersonalComputer>();
            pc.Add(new PersonalComputer());
            foreach( var elem in pc)
            {
                elem.SwitchOn();
                elem.SwitchOff();
            }
            Console.WriteLine();
            List<TVSet> tv = new List<TVSet>();
            tv.Add(new TVSet());
            foreach (var elem in tv)
            {
                elem.SwitchOn();
                elem.SwitchOff();
            }
            Console.ReadKey();
        }
    }
}
