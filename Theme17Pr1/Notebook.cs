using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme17Pr1
{
    class Notebook
    {
        string name;
        int k;

        public string Name { get => name; set => name = value; }
        public int K { get => k; set => k = value; }
        public Notebook() { }
        public Notebook(string name, int k)
        {
            this.name = name;
            this.k = k;

        }
        public int Cost()
        {
            return 15 * k;
        }
        public void Output()
        {
            Console.WriteLine($"Название - {name}\nКол-во листов - {k}");
        }
    }
}
