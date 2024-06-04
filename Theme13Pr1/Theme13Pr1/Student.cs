using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme13Pr1
{
    class Student
    {
        string fam;
        private int kurs;

        public string Fam
        {
            set
            {
                if (value == fam)
                {
                    Console.WriteLine("Drugoi registtr");
                }
                else
                {
                    fam = value;
                }

            }
            
            get
            {
                return fam;
            }
        }
       
        
        public int Kurs { get => kurs; set => kurs = value; }

        public Student() { }
        public Student(string fam,int kurs) 
        {
            this.Fam = fam;
           this.Kurs = kurs;
        }
        public string ShowInfo()
        {
            return $"Фамилия - {fam}\nКурс - {kurs}";
        }
    }

}
