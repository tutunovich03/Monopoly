using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Igrac
    {
        public int br500, br100, br50, br20, br10, br5, br1;
        public int dugBanci, dugIgracu;
        public int noofRailRoads,noofUtilities;
        public bool gotojail, getoutofjail;
        public Igrac() 
        {
            this.br50 = 0;
            this.br20 = 0;
            this.br10 = 0;
            this.br5 = 0;
            this.br1 = 0;
            this.dugBanci = 0;
            this.dugIgracu = 0;
            this.noofRailRoads = 0;
            this.noofUtilities = 0;
            this.gotojail = false;
            this.getoutofjail = false;
        }
        public Igrac(int br500,int br100, int br50, int br20, int br10, int br5, int br1, int db, int di, int norr, int nou, bool gotojail, bool getoutofjail) 
        {
            this.br500 = br500;
            this.br100 = br100;
            this.br50 = br50;
            this.br20 = br20;
            this.br10 = br10;
            this.br5 = br5;
            this.br1 = br1;
            this.dugBanci = db;
            this.dugIgracu = di;
            this.noofRailRoads = norr;
            this.noofUtilities = nou;
            this.gotojail = gotojail;
            this.getoutofjail = getoutofjail;
        }
        public int Ukupanbudzet 
        {
            get { return 500 * br500 + 100 * br100 + 50 * br50 + 20 * br20 + 10 * br10 + 5 * br5 + br1; }
        }
    }
}
