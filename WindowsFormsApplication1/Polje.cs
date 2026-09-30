using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    abstract class Polje
    {
        public string nazivPolja,vrstaPolja;
        public bool igracjenapolju;
        private int brojPolja;
        public int BrojPolja 
        {
            get { return brojPolja; }
            set 
            {
                if (value >= 1 && value <= 40)
                {
                    brojPolja = value;
                }
                else 
                {
                    throw new Exception();
                }
            }
        }
        public Polje() 
        {
            this.nazivPolja = "";
            this.igracjenapolju = false;
            this.brojPolja = 0;
        }
        public Polje(string np, bool ijnp, int bp,string vp)
        {
            this.nazivPolja = np;
            this.igracjenapolju = ijnp;
            this.brojPolja = bp;
            if (this.brojPolja < 1 || this.brojPolja > 40) 
            {
                throw new Exception();
            }
            this.vrstaPolja = vp;
        }
    }
}
