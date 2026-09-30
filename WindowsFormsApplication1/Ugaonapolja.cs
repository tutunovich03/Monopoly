using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class UgaonaPolja:Polje
    {
        public string vrstaUgaonogPolja;
        public UgaonaPolja() 
        {
            this.vrstaUgaonogPolja = "";
        }
        public UgaonaPolja(string np, bool ijnp, int bp, string vup) : base(np, ijnp, bp,"UgaonoPolje") 
        {
            this.vrstaUgaonogPolja = vup;
        }
    }
}
