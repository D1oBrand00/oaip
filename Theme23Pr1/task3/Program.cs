using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        enum Mathem { Sum = 1,Sub, Mult, Div, Exit}
        static void Main(string[] args)
        {
            Math m = new Math();
            while(true)
            {
                Console.Clear();
                Console.WriteLine("Введите арифметическое действие над X и Y\n1 - Sum\n2 - Sub\n3 - Mult\n4 - Div\n\n5 - Exit");
                int act = int.Parse(Console.ReadLine());
                Mathem action = (Mathem)act;
                switch (action)
                {
                    case Mathem.Sum:
                        Console.Clear();
                        m.OutPutSum(Math.InPutX(),Math.InPutY());
                        Console.ReadLine();
                        break;
                    case Mathem.Sub:
                        Console.Clear();
                        m.OutPutSub(Math.InPutX(), Math.InPutY());
                        Console.ReadLine();
                        break;
                    case Mathem.Mult:
                        Console.Clear();
                        m.OutPutMult(Math.InPutX(), Math.InPutY());
                        Console.ReadLine();
                        break;
                    case Mathem.Div:
                        Console.Clear();
                        m.OutPutDiv(Math.InPutX(), Math.InPutY());
                        Console.ReadLine();
                        break;
                    case Mathem.Exit:
                        return;
                }
            }
            
        }
    }
}
