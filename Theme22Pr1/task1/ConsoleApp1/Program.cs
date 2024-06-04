using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Struct1 struct1 = new Struct1();
            Class1 cl2 = class1;
           

            class1.Change = "не изменено";
            struct1.Change = "не изменено";
            cl2.Change = "пппп";

            //ClassTaker(class1);
            //StruktTaker(struct1);

            Console.WriteLine($"Кл - {cl2.Change} \nКласс - {class1.Change}");

            Console.ReadKey();
        }

        static void ClassTaker(Class1 myClass)
        {
            myClass.Change = "изменено";
        }
        static void StruktTaker(Struct1 myStruct)
        {
            myStruct.Change = "изменено";
        }
    } 
}
