using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Ulice:Poljanaprodaju
    {
        public bool hotel;
        private int brKuca;
        public string boja;
        private int rentjk, rentdk, renttk, rentck, renth;
        public int BrKuca 
        {
            get { return brKuca; }
            set 
            {
                if (value >= 0 && value <= 4)
                {
                    brKuca = value;
                }
                else 
                {
                    throw new Exception();
                }
            }
        }
        public int RentJK { get { return rentjk; } set { rentjk = value; } }
        public int RentDK { get { return rentdk; } set { rentdk = value; } }
        public int RentTK { get { return renttk; } set { renttk = value; } }
        public int RentCK { get { return rentck; } set { rentck = value; } }
        public int RentH { get { return renth; } set { renth = value; } }
        public Ulice() 
        {
            this.brKuca = 0;
            this.hotel = false;
            this.boja = "";
            this.hipoteka = false;
            this.rentjk = 0;
            this.rentdk = 0;
            this.renttk = 0;
            this.rentck = 0;
            this.renth = 0;
        }
        public Ulice(string np, bool ijnp,int bp, int cena, int rent, int rjk, int rdk, int rtk, int rck, int rh, bool hipoteka, string vlasnik, int brKuca, bool hotel, string boja, bool pc, int mv)
            :base(np, ijnp, bp, cena, rent, hipoteka, vlasnik, "Ulica", pc, mv)
        {
            this.brKuca = brKuca;
            if (this.brKuca < 0 || this.brKuca > 4) 
            {
                throw new Exception();
            }
            this.hotel = hotel;
            this.boja = boja;
            this.rentjk = rjk;
            this.rentdk = rdk;
            this.renttk = rtk;
            this.rentck = rck;
            this.renth = rh;
        }
    }
}
