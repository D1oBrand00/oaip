using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme16Pr4
{
    class Program
    {
        static void Main(string[] args)
        {
            CountVisitWebSite[] count = new CountVisitWebSite[3];
            count[1] = new CountVisitWebSite("https://github.com/", "192.168.0.1", "Chrome", new DateTime(2024, 01, 25), new TimeSpan(8, 30, 40));
            count[2] = new CountVisitWebSite("https://github.com/", "192.168.0.2", "Yandex", new DateTime(2024, 01, 26), new TimeSpan(10, 0, 40));
            count[3] = new CountVisitWebSite("https://github.com/", "192.168.0.3", "FireFox", new DateTime(2024, 01, 27), new TimeSpan(12, 30, 40));




            Console.ReadKey();
        }
    }
}
