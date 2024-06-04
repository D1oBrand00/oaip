using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme17Pr1
{
    class Magazine : Press
    {
        string quality;

        public string Quality { get => quality; set => quality = value; }
        public Magazine(int copies, string name, int price, string quality) : base(copies, name, price)
        {
            this.quality = quality;

        }
        public new double Cost()
        {
            if (quality == "высокое")
            {
                return base.Cost() + (base.Cost() * 0.1);

            }
            else if (quality == "среднее")
            {
                return base.Cost();
            }
            else if (quality == "низкое")
            {
                return base.Cost() - (base.Cost() * 0.1);
            }
            else
            { return base.Cost(); }
        }
        public new void Output()
        {
            base.Output();

            Console.WriteLine($"Качество тиража - {quality}\nНовая стоимость тиража - {Cost()}");
        }
    }
}
