using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Poljanaprodaju:Polje
    {
        private int cena, rent, mortgageValue;
        public bool hipoteka, propertyclicked;
        public string vlasnik,vrstapoljanaprodaju;
        public Poljanaprodaju() 
        {
            this.cena = 0;
            this.rent = 0;
            this.hipoteka = false;
            this.vlasnik = "";
            this.propertyclicked = false;
            this.mortgageValue = 0;
        }
        public Poljanaprodaju(string np, bool ijnp, int bp, int cena, int rent, bool hipoteka, string vlasnik, string vpnp,bool pc, int mv) 
            : base(np,ijnp, bp,"Poljenaprodaju") 
        {
            this.cena = cena;
            if (this.cena < 0)
            {
                throw new Exception();
            }
            this.rent = rent;
            if (this.rent < 0)
            {
                throw new Exception();
            }
            this.hipoteka = hipoteka;
            this.vlasnik = vlasnik;
            this.vrstapoljanaprodaju = vpnp;
            this.propertyclicked = pc;
            this.mortgageValue = mv;
        }
        public int Cena 
        {
            get { return cena; }
            set 
            {
                if (value > 0)
                {
                    cena = value;
                }
                else 
                {
                    throw new Exception();
                }
            }
        }
        public int Rent
        {
            get { return rent; }
            set { rent = value; }
        }
        public int MortgageValue 
        {
            get { return mortgageValue; }
            set { mortgageValue = value; }
        }
    }
}
