using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Person : Talk, Thinking
    {
        public void SpeaksLoudly()
        {
            Console.WriteLine("Говорит громко - Я люблю программирование!");
        }
        public void Think()
        {
            Console.WriteLine("Думает - А C# больше всего");
        }
        public void SpeaksQuietly()
        {
            Console.WriteLine("Говорит нормально - Меньше люблю компьютерные игры");
        }
    }
}
