using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class CommunityChestChance : Polje
    {
        private int brojKarte;
        public CommunityChestChance() 
        {
            this.brojKarte = 0;
        }
        public CommunityChestChance(string np, bool ijnp,int bp, string vp, int bk) 
            : base(np, ijnp, bp, vp) 
        {
            this.brojKarte = bk;
            if (this.brojKarte != 16 && this.brojKarte != 17)
            {
                throw new Exception();
            }
        }
        public int BrojKarte 
        {
            get { return brojKarte; }
            set 
            {
                if (value == 16 || value == 17)
                {
                    brojKarte = value;
                }
                else 
                {
                    throw new Exception();
                }
            }
        }
    }
}
