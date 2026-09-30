using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Takse : Polje
    {
        private int racun;
        public Takse() 
        {
            this.racun = 0;
        }
        public Takse(string np, bool ijnp, int bp, int racun) 
            : base(np, ijnp, bp,"Taksa") 
        {
                this.racun = racun;
                if (this.racun != 100 && this.racun != 200)
                {
                    throw new Exception();
                }
        }
        public int Racun 
        {
            get { return racun; }
            set 
            {
                if (value == 100 || value == 200)
                {
                    racun = value;
                }
                else 
                {
                    throw new Exception();
                }
            }
        }

    }
}
