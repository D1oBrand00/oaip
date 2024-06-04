using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    struct Notebook
    {
        string model;
        string manufacturer;
        int cost;

        public string Model { get => model; set => model = value; }
        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
        public int Cost { get => cost; set => cost = value; }
        public Notebook(string model, string manufacturer, int cost)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.cost = cost;

        }
        public void OutPut()
        {
            Console.WriteLine($"Модель - {model}\nПроизводитель - {manufacturer}\nЦена - {cost}");
        }
    }
}
