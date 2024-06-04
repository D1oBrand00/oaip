using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        enum UserRole { Администратор = 1, Модератор, Пользователь, Гость}
        static void Main(string[] args)
        {
            Console.WriteLine("Зарегистрироваться как:\n1 - Администратор.\n2 - Модератор.\n3 - Пользовател.ь\n4 - Гость.");
            int act = int.Parse(Console.ReadLine());
            UserRole role = (UserRole)act;
            switch(role)
            {
                case UserRole.Администратор:
                    Console.Clear();
                    Console.WriteLine($"Вы зарегистрированы как администратор.");
                    break;
                case UserRole.Модератор:
                    Console.Clear();
                    Console.WriteLine($"Вы зарегистрированы как модератор.");
                    break;
                case UserRole.Пользователь:
                    Console.Clear();
                    Console.WriteLine($"Вы зарегистрированы как пользователь.");
                    break;
                case UserRole.Гость:
                    Console.Clear();
                    Console.WriteLine($"Вы зарегистрированы как гость.");
                    break;
                default:
                    Console.WriteLine("Ошибка, данные введены неправильно.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
