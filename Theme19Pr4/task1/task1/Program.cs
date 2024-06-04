using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создание коллекции объектов класса TourFirm
            List<TourFirm> firms = new List<TourFirm>();
            //Добавление объектов в коллекцию
            firms.Add(new TourFirm { Name = "Путеводная Звезда", Year = 2015, IdentificationNumber = "35345B", Income = 23665 });
            firms.Add(new TourFirm { Name = "ТурГармония", Year = 2019, IdentificationNumber = "45643С", Income = 26533 });
            firms.Add(new TourFirm { Name = "ЭкзотиКа", Year = 2010, IdentificationNumber = "20043J", Income = 14643 });
            firms.Add(new TourFirm { Name = "Мечта-Тур", Year = 2017, IdentificationNumber = "39755F", Income = 18536 });
            firms.Add(new TourFirm { Name = "Альфатревел", Year = 2006, IdentificationNumber = "09532A", Income = 0 });
            //Создания бесконечного цикла для добавления или просмотра объектов списка
            while (true)
            {
                Console.WriteLine($"Добавить в список фирму - 1\nНайти фирму по названию - 2\nНайти суммарную прибыль всех фирм - 3\nНайти, какая из фирм получила наибольшую прибыль и размер этой прибыли - 4\nУдалить из списка информацию об обанкротившейся фирме - 5\n" +
                    $"Отсортировать коллекцию, содержащую информацию о туристических фирмах города, поразмеру прибыли за текущий год - 6\nПросмотреть все объекты списка - 7\nЗакрыть консоль - q\n");
                string action = Console.ReadLine();
                Console.WriteLine();
                switch(action.ToLower())
                {
                    case "1":
                        firms.Add(TourFirm.Input());
                        break;
                    case "2":
                        Console.WriteLine("Введите название искомой фирмы");
                        string firm = Console.ReadLine();
                        foreach(var elem in firms)
                        {
                            if (firm.ToLower() == elem.Name.ToLower())
                            {
                                Console.WriteLine($"ИНН фирмы - {elem.IdentificationNumber}\nПрибыль за текущий год: {elem.Income}р\n");
                            }
                        }
                        break;
                    case "3":
                        double totalIncome = 0;
                        foreach(var elem in firms)
                        {
                            totalIncome += elem.Income;
                        }
                        Console.WriteLine($"Суммарная прибыль всех фирм {totalIncome}р\n");
                        break;
                    case "4":
                        double highestIncome = 0;
                        string name = null;
                        foreach(var elem in firms)
                        {
                            if (highestIncome < elem.Income)
                            {
                                highestIncome = elem.Income;
                                name = elem.Name;
                            }
                        }
                        Console.WriteLine($"Фирма с наибольшей прибылью - {name}, её прибыль - {highestIncome}р\n");
                        break;
                    case "5":
                        for(int i = 0; i< firms.Count; i++)
                        {
                            if (firms[i].Income == 0)
                            {
                                Console.WriteLine($"Фирма {firms[i].Name} обонкротилась\n");
                                firms.RemoveAt(i);
                            }
                        }
                        break;
                    case "6":
                        firms.Sort();
                      break;
                    case "7":
                        foreach (var elem in firms)
                        {
                            elem.Output();
                        }
                        break;
                    case "q":
                        return;
                        break;

                        
                }
            }
            Console.ReadKey();
        }
    }
}
