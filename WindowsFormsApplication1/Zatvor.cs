using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Zatvor : UgaonaPolja
    {
        public bool kaucijaplacena, getoutofjailfreecard, outofjail;
        private int brpokusajazadoubles;
        public Zatvor() 
        {
            this.kaucijaplacena = false;
            this.getoutofjailfreecard = false;
            this.outofjail = false;
            this.brpokusajazadoubles = 0;
        }
        public Zatvor(string np, bool ijnp, int bp, bool kjp, bool goojfc, bool o, int bpzd) 
            : base(np, ijnp, bp,"Zatvor") 
        {
            this.kaucijaplacena = kjp;
            this.getoutofjailfreecard = goojfc;
            this.outofjail = o;
            this.brpokusajazadoubles = bpzd;
            if (this.brpokusajazadoubles < 0 || this.brpokusajazadoubles > 3) 
            {
                throw new Exception();
            }
        }
        public int Brojpokusajazadoubles 
        {
            get { return brpokusajazadoubles; }
            set 
            {
                if (value >= 1 && value <= 3) 
                {
                    brpokusajazadoubles = value;
                }
            }
        }
    }
}