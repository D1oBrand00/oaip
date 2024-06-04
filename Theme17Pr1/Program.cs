using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme17Pr1
{
    class Program
    {

        static void Main(string[] args)
        {


            Console.Write("Введите возраст ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Введите имя ");
            string name = Console.ReadLine();
            Console.Write("Введите фамилию ");
            string surname = Console.ReadLine();
            Console.Write("Введите название компании ");
            string company = Console.ReadLine();
            Console.Write("Введите название работы ");
            string job = Console.ReadLine();
            //Person p1 = new Person(age);
            //p1.Print();
            //Console.WriteLine();
            //Person p2 = new Person(age, name, surname);
            //p2.Print();
            //Employee p3 = new Employee(age, name, surname, company, job);
            //p3.Print();
            //Person p4 = new Employee(age,name,surname,company,job);
            //p4.Print();
            List<Person> persons = new List<Person>();
            persons.Add(new Person(22, "Даниил", "П"));
            persons.Add(new Employee(age, name, surname, company, job));
            foreach(var num in persons)
            {
                num.Print();
                Console.WriteLine();
            }




            Console.ReadKey();
        }
    }
}
