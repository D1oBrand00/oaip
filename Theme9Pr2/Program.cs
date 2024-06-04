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
            var list = new List<string> { "Ирина", "Марина", "Настя", "Лера", "Оля", "Даша" };
            //1. Добавьте в список элементы строчными буквами;
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            list.Add(name.ToLower());
            Output(list);
            Console.WriteLine();
            //3. Преобразуйте все буквы элементов в прописные;
            Upper(list);
            Output(list);
            Console.WriteLine();
            //5. Определите текущее количество элементов коллекции;
            Console.WriteLine($"Кол-во элементов коллекции - {list.Count}\n");
            //6. Добавьте в коллекцию новый элемент в конец списка соответствующего варианта;
            list.Add(name);
            Output(list);
            Console.WriteLine();
            //8. Добавьте в коллекцию новый элемент в начале списка соответствующего варианта;
            list.Insert(0, name);
            Output(list);
            Console.WriteLine();
            //10.Удалите третий элемент коллекции;
            list.RemoveAt(3);
            Output(list);
            Console.WriteLine();
            //12 Расположите элементы в обратном порядке
            list.Reverse();
            Output(list);
            Console.ReadKey();
            
        }
        static void Upper(List<string> list)
        {
            for (int i = 0;i<list.Count;i++)
            {
                list[i] = list[i].ToUpper();
            }    
 
        }
        static void Output(List<string> list)
        {
            foreach (var elem in list)
            {
                Console.WriteLine(elem);
            }
        }
    }
}
