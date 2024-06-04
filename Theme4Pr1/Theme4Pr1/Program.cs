using System;

namespace Theme4Pr1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 Запросить 5 слов, после чего вывести дважды каждое нечетное слово и трижды каждое четное слово
            //Console.Title = "Программа 1 (Полозюк)";
            //Console.WriteLine("Ввести 5 слов");
            //Console.Write("Введите первое слово: ");
            //string word1 = Console.ReadLine();
            //Console.Write("Введите второе слово: ");
            //string word2 = Console.ReadLine();
            //Console.Write("Введите третье слово: ");
            //string word3 = Console.ReadLine();
            //Console.Write("Введите четвертое слово: ");
            //string word4 = Console.ReadLine();
            //Console.Write("Введите пятое слово: ");
            //string word5 = Console.ReadLine();
            //Console.WriteLine($"{word1}{"!"}{word1}{"!"}{word3}{"!"}{word3}{"!"}{word5}{"!"}{word5}{"!"}{word2}{"!"}{word2}{"!"}{word2}{"!"}{word4}{"!"}{word4}{"!"}{word4}");
            //Console.ReadKey();

            //2 Запросить 5 слов, после чего вывести каждое слово на новой строке, используя 3 способа вывода
            //Console.Title = "Программа 2 (Полозюк)";
            //Console.WriteLine("Ввести 5 слов");
            //Console.Write("Введите первое слово: ");
            //string word1 = Console.ReadLine();
            //Console.Write("Введите второе слово: ");
            //string word2 = Console.ReadLine();
            //Console.Write("Введите третье слово: ");
            //string word3 = Console.ReadLine();
            //Console.Write("Введите четвертое слово: ");
            //string word4 = Console.ReadLine();
            //Console.Write("Введите пятое слово: ");
            //string word5 = Console.ReadLine();
            //Console.Write($"{word1}\n");
            //Console.WriteLine($"{word2}");
            //Console.WriteLine($"{word3}\n{word4}\n{word5}");
            //Console.ReadKey();

            //3 Запросить имя пользователя, затем поздороваться с ним. Изменить цвет фона и символов, отобразить, включен ли CapsLock и NumLock, скрыть курсор
            Console.Title = "Тема 4. Компьютерный практикум 1(Полозюк)";
            Console.SetWindowSize(60, 25);
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Как тебя зовут?");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}");
            if (Console.CapsLock)
            { Console.WriteLine("CapsLock включен"); }
            else { Console.WriteLine("CapsLock выключен"); }
            if (Console.NumberLock)
            { Console.WriteLine("NumLock включен"); }
            else
            { Console.WriteLine("NumLock выключен"); }
            Console.CursorVisible = false;
            Console.ReadKey();


        }
    }
}
