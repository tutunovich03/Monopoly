using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    abstract class Polja
    {
        public string nazivPolja;
        public bool igracjenapolju;
        public Polja(string np, bool ijnp) 
        {
            this.nazivPolja = np;
            this.igracjenapolju = ijnp;
        }
        public abstract string Podaci();
    }
}
