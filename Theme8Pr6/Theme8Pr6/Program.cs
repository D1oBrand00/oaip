using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme8Pr6
{
    class Program
    {
        //Задача 1. Массив предназначен для хранения значений ростов двенадцати человек. С помощью датчика случайных чисел заполнить массив целыми значениями, лежащими в диапазоне от 163 до 190 включительно. Вывести значения элементов с использованием цикла for. Найти средний рост
        //static int[] Input()
        //{
        //    //////Console.Write("x = ");
        //    //////byte n = byte.Parse(Console.ReadLine());
        //    Random rnd = new Random();
        //    int[] omas = new int[12];
        //    for (byte i = 0;i<omas.Length;i++)
        //    {
        //        omas[i] = rnd.Next(163, 190);
        //        //////Console.Write($"omas[{i}] = {omas[i]}");
        //        //////omas[i] = int.Parse(Console.ReadLine());
        //    }
        //    return omas;
        //}
        //static int Growth(int[]omas)
        //{
        //    int growth = 0;
        //    for (byte i = 0; i < omas.Length; i++)
        //    {
        //        growth += omas[i];
        //    }
        //    return growth;
        //}
        //static void Output(int[]omas)
        //{
        //    for (byte i = 0; i<omas.Length;i++)
        //    {
        //        Console.WriteLine($"omas[{i}] = {omas[i]}");
        //    }
        //    Console.WriteLine($"Средний рост = {Growth(omas)/12}");
        //}

        //static void Main()
        //{
        //    int[] omas = Input();
        //    Output(omas);
        //    Console.ReadKey();
        //}

        //Задача 2. Заполнить массив из восьми элементов следующими значениями с использованием явной инициализации: первый элемент массива равен 37, второй — 0, третий — 50, четвертый — 46, пятый — 34, шестой — 46, седьмой — 0, восьмой —13. Найти максимальный и минимальный элементы массива.
        //static int[] Input()
        //{
        //    int[] omas = new int[8] { 37,0,50,46,34,46,0,13};
        //    return omas;
        //}
        //static int Max(int[]omas)
        //{
        //    int max = omas[0];
        //    for (byte i = 0; i < omas.Length; i++)
        //    {
        //        if(max<omas[i])
        //        {
        //            max = omas[i]; ;
        //        }
        //    }
        //    return max;

        //}
        //static int Min(int[] omas)
        //{
        //    int min = omas[0];
        //    for (byte i = 0; i < omas.Length; i++)
        //    {
        //        if (min > omas[i])
        //        {
        //            min = omas[i];
        //        }
        //    }
        //    return min;

        //}
        //static void Output(int[] omas)
        //{
        //    for (byte i = 0; i < omas.Length; i++)
        //    {
        //        Console.WriteLine($"omas[{i}] = {omas[i]}");
        //    }
        //    Console.WriteLine($"Максимальный элемент массива = {Max(omas)}");
        //    Console.WriteLine($"Минимальный элемент массива = {Min(omas)}");
        //}
        //static void Main()
        //{
        //    int[] omas = Input();
        //    Output(omas);
        //    Console.ReadKey();
        //}
        //Задача 3. Заполнить одномерный массив с клавиатуры и вывести элементы массива на экран в обратном порядке
        //static int[] Input()
        //{
        //    Console.Write("n = ");
        //    byte n = byte.Parse(Console.ReadLine());
        //    int[] omas = new int[n];
        //    for (byte i = 0; i < omas.Length; i++)
        //    {
        //        Console.Write($"omas[{i}] = ");
        //        omas[i] = int.Parse(Console.ReadLine());
        //    }
        //    return omas;
        //}
        //static void Output(int[] omas)

        //{
        //    for (int i = omas.Length - 1; i >= 0; i--)
        //    {
        //        Console.WriteLine($"omas[{i}] = {omas[i]}");
        //    }
        //}
        //static void Main()
        //{
        //    int[] omas = Input();
        //    Output(omas);
        //    Console.ReadKey();
        //}
        //Задача 4. Заполнить одномерный массив случайным образом от -5 до 5 целыми числами. Увеличить все элементы в два раза. Вывести новые значения массива с использованием цикла foreach
        //static int[] Input()
        //{
        //    Console.Write("n = ");
        //    byte n = byte.Parse(Console.ReadLine());
        //    Random rnd = new Random();
        //    int[] omas = new int[n];
        //    for (byte i = 0; i < omas.Length; i++)
        //    {
        //        omas[i] = rnd.Next(-5, 5);
        //    }
        //    return omas;
        //}
        //static int[] Double(int[] omas)
        //{
        //    for (byte i = 0; i < omas.Length; i++)
        //    {
        //        omas[i] *= 2;
        //    }
        //    return omas;
        //}
        //static void Output(int[] omas)

        //{
        //    foreach (var elem in omas)
        //    {
        //        Console.WriteLine($"{elem}");
        //    }
        //}
        //static void Main()
        //{
        //    int[] omas = Input();
        //    Double(omas);
        //    Output(omas);
        //    Console.ReadKey();
        //}
        //Задача 5. В массиве хранятся сведения об оценках 25 учеников по химии. Определить количество неуспевающих по химии учеников
        static int[] Input()
        {
            Random rnd = new Random();
            int[] omas = new int[25];
            for (byte i = 0; i < omas.Length; i++)
            {
                omas[i] = rnd.Next(2, 5);
            }
            return omas;
        }
        static int Quantity(int[]omas)
        {
            int x = 0;
            for (byte i = 0;i<omas.Length;i++ )
            {
                if (omas[i]<= 3)
                { x++;  }    
            }    
            return x;
        }
        static void Output(int[]omas)
        {
            for (byte i = 0; i < omas.Length; i++)
            {
                Console.WriteLine($"omas[{i}] = {omas[i]}");
            }
            Console.WriteLine($"Количество неуспевающих по химии учеников = {Quantity(omas)}");
        }
        static void Main()
        {
            int[] omas = Input();
            Output(omas);
            Console.ReadKey();
        }




    }
}
