using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme14Pr2
{
    class Pupil
    {
        static int count;

        private int mark;

        public int Mark
        {
            get { return mark; }
            set { mark = value; }
        }

        private string pupil;
        

        public string Shkolnik
        {
            get { return pupil; }
            set { pupil = value; }
        }

        public Pupil(int mark)
        {
            this.mark = mark;
            
        }

        static Pupil()
        {
            count = 0;
        }

        public int  Avergage()
        {
            return mark*
        }

        public  void GetMark()
        {
            Console.WriteLine("Двоечники");
          
        }
       


    }
}
