using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class TVSet : ISwitchable
    {
        public void SwitchOn()
        {
            Console.WriteLine("ТВ включен");
        }
        public void SwitchOff()
        {
            Console.WriteLine("ТВ выключен");
        }
    }
}
