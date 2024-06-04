using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme17Pr1
{
    class Press
    {
        int copies;
        string name;
        int price;

        public int Copies { get => copies; set => copies = value; }
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public Press() { }
        public Press(int copies, string name, int price)
        {
            this.copies = copies;
            this.name = name;
            this.price = price;
        }
        public int Cost()
        {
            int cost = copies * price;
            return cost;
        }
        public void Output()
        {
            Console.WriteLine($"Кол-во копий - {copies}\nНазвание газеты - {name}\nСтоимость одной газеты - {price} р.");
        }
    }
}
