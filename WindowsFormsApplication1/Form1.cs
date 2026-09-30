using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Ulice[] ul = {
                          new Ulice("Mediterranen_avenue",false,2,60,2,10,30,90,160,250,false,"",0,false,"braon",false,30),
                          new Ulice("Baltic_avenue",false,4,60,4,20,60,180,320,450,false,"",0,false,"braon",false,30),
                          new Ulice("Oriental_avenue",false,7,100,6,30,90,270,400,550,false,"",0,false,"svplava",false,50),
                          new Ulice("Vermont_avenue",false,9,100,6,30,90,270,400,550,false,"",0,false,"svplava",false,50),
                          new Ulice("Connecticut_avenue",false,10,120,8,40,100,300,450,600,false,"",0,false,"svplava",false,60),
                          new Ulice("st_charles_place",false,12,140,10,50,150,450,625,750,false,"",0,false,"roze",false,70),
                          new Ulice("states_avenue",false,14,140,10,50,150,450,625,750,false,"",0,false,"roze",false,70),
                          new Ulice("virginia_avenue",false,15,160,12,60,180,500,700,900,false,"",0,false,"roze",false,80),
                          new Ulice("st_James_place",false,17,180,14,70,200,550,750,950,false,"",0,false,"narandzasta",false,90),
                          new Ulice("tenesse_avenue",false,19,180,14,70,200,550,750,950,false,"",0,false,"narandzasta",false,90),
                          new Ulice("ny_avenue",false,20,200,16,80,220,600,800,1000,false,"",0,false,"narandzasta",false,100),
                          new Ulice("kentuckey_avenue",false,22,220,18,90,250,700,875,1050,false,"",0,false,"crvena",false,110),
                          new Ulice("indiana_avenue",false,24,220,18,90,250,700,875,1050,false,"",0,false,"crvena",false,110),
                          new Ulice("illinois_avenue",false,25,240,20,100,300,750,925,1100,false,"",0,false,"crvena",false,120),
                          new Ulice("atlantic_avenue",false,27,260,22,110,330,800,975,1150,false,"",0,false,"zuta",false,130),
                          new Ulice("ventnor_avenue",false,28,260,22,110,330,800,975,1150,false,"",0,false,"zuta",false,130),
                          new Ulice("Marvin_gardens",false,30,280,24,120,360,850,1025,1200,false,"",0,false,"zuta",false,140),
                          new Ulice("pacific_avenue",false,32,300,26,130,390,900,1100,1275,false,"",0,false,"zelena",false,150),
                          new Ulice("north_carolina_avenue",false,33,300,26,130,390,900,1100,1275,false,"",0,false,"zelena",false,150),
                          new Ulice("pennsylvania_avenue",false,35,320,28,150,450,1000,1200,1400,false,"",0,false,"zelena",false,160),
                          new Ulice("park_place",false,38,350,35,175,500,1100,1300,1500,false,"",0,false,"plava",false,175),
                          new Ulice("Boardwalk",false,40,400,50,200,600,1400,1700,2000,false,"",0,false,"plava",false,200)
                      };
        Poljanaprodaju[] pnp = {
                                       new Poljanaprodaju("Reading_railroad",false,6,200,25,false,"","Railroad",false,100),
                                       new Poljanaprodaju("electric_company",false,13,150,25,false,"","Komunalije",false,75),
                                       new Poljanaprodaju("pensilvania_railroad",false,16,200,25,false,"","Railroad",false,100),
                                       new Poljanaprodaju("BandO_railroad",false,26,200,25,false,"","Railroad",false,100),
                                       new Poljanaprodaju("water_works",false,29,150,25,false,"","Komunalije",false,75),
                                       new Poljanaprodaju("short_line",false,36,200,25,false,"","Railroad",false,100)
                                   };
        UgaonaPolja[] up = {
                                   new UgaonaPolja("start",false,1,"startpolje"),
                                   new UgaonaPolja("free_parking",false,21,"freeParking"),
                                   new UgaonaPolja("Go_to_jail",false,31,"GoToJail")
                               };
        Zatvor z = new Zatvor("Jail", false, 11, false, false, true, 0);
        CommunityChestChance[] cc = {
                                            new CommunityChestChance("Comunity_Chest1",false,3,"communitychest",17),
                                            new CommunityChestChance("chance1",false,8,"chance",16),
                                            new CommunityChestChance("comunity_chest2",false,18,"communitychest",17),
                                            new CommunityChestChance("chance2",false,23,"chance",16),
                                            new CommunityChestChance("community_chest3",false,34,"communitychest",17),
                                            new CommunityChestChance("chance3",false,37,"chance",16)
                                        };
        Takse[] t = {
                          new Takse("income_tax1",false,5,200),
                          new Takse("luxury_tax",false,39,100),
                      };

        Igrac[] ig = {
                     new Igrac(2, 2, 2, 6, 5, 5, 5, 0, 0, 0, 0, false, false),
                     new Igrac(2, 2, 2, 6, 5, 5, 5, 0, 0, 0, 0, false, false)
                    };

        bool igrac1naPotezu = false, igrac2naPotezu = false, kockaBacena, kocka2Bacena, startgame = false;
        int u, u1, y = 0, brojaclicakocke = 1, brojaclicakocke2 = 1, brojprvekocke, brojdrugekocke, ukupanbroj1 = 0, ukupanbroj2 = 0, i = 2, j = 2, x = 0;
        string k, imePolja;
        bool buyProperty, dontbuyProperty, propertyBought;
        int sum = 0;
        int br = 0, brj = 0;
        bool pokaziImanjaprvog;
        bool pokaziImanjadrugog;
        int q = 0, p = 0;
        int brojacduplih1 = 0, brojacduplih2 = 0;
        int pr = 0;
        bool sansaIzvucena = false, comchestIzvucen = false;
        string[] chances = new string[] { "chance1", "chance2", "chance3", "chance4", "chance5", "chance6", "chance7", "chance8", "chance9", "chance10", "chance11", "chance12", "chance13",
            "chance14", "chance15","chance16" };
        string[] communitychests = new string[] { "cc1", "cc2", "cc3", "cc4", "cc5", "cc6", "cc7", "cc8", "cc9", "cc10", "cc11", "cc12", "cc13", "cc14", "cc15", "cc16", "cc17" };
        int brLab;
        int v = 0, f = 0, zat = 0, o = 0, pcl = 0, c = 0;
        bool db1, db2;
        int parkingNovac = 0, r = 0;
        int uput1 = 0, uput2 = 0;


        private void Kusur(int dug, int pare) 
        {
            int r = pare - dug;
            int h = 0;
            if (igrac1naPotezu) { h = 0; }
            if (igrac2naPotezu) { h = 1; }
            if (selling || mortgaging)
            {
                foreach (Ulice el in ul)
                {
                    if (el.propertyclicked)
                    {
                        if (el.vlasnik == "player1") h = 0;
                        else h = 1;
                    }
                }
                foreach (Poljanaprodaju el in pnp)
                {
                    if (el.propertyclicked)
                    {
                        if (el.vlasnik == "player1") h = 0;
                        else h = 1;
                    }
                }
            }
            ig[h].br500 += r / 500;
            r -= r / 500 * 500;
            ig[h].br100 += r / 100;
            r -= r / 100 * 100;
            ig[h].br50 += r / 50;
            r -= r / 50 * 50;
            ig[h].br20 += r / 20;
            r -= r / 20 * 20;
            ig[h].br10 += r / 10;
            r -= r / 10 * 10;
            ig[h].br5 += r / 5;
            r -= r / 5 * 5;
            ig[h].br1 += r;
        }

        private void Placanje(int dug, int pare) 
        {
            int r = pare - dug;
            int h = 0;
            if (igrac1naPotezu) { h = 1; }
            if (igrac2naPotezu) { h = 0; }
            if (selling) 
            {
                foreach (Ulice el in ul) 
                {
                    if (el.propertyclicked) 
                    {
                        if (el.vlasnik == "player1") h = 1;
                        else h = 0;
                    }
                }
                foreach (Poljanaprodaju el in pnp)
                {
                    if (el.propertyclicked)
                    {
                        if (el.vlasnik == "player1") h = 1;
                        else h = 0;
                    }
                }
            }
            ig[h].br500 -= r / 500;
            r -= r / 500 * 500;

            if (ig[h].br100 < r / 100) 
            {
                if (ig[h].br500 > 0)
                {
                    ig[h].br500--;
                    ig[h].br100 += 5;
                }
            }

            ig[h].br100 -= r / 100;
            r -= r / 100 * 100;

            if (ig[h].br50 < r / 50) 
            {
                if (ig[h].br100 > 0)
                {
                    ig[h].br100--;
                    ig[h].br50 += 2;
                }
                else if (ig[h].br500 > 0)
                {
                    ig[h].br500--;
                    ig[h].br50 += 10;
                }
            }

            ig[h].br50 -= r / 50;
            r -= r / 50 * 50;

            if (ig[h].br20 < r / 20) 
            {
                if (ig[h].br50 > 0)
                {
                    ig[h].br50--;
                    ig[h].br20 += 2;
                    ig[h].br10 += 1;
                }
                else if (ig[h].br100 > 0)
                {
                    ig[h].br100--;
                    ig[h].br20 += 5;
                }
                else if (ig[h].br500 > 0)
                {
                    ig[h].br500--;
                    ig[h].br20 += 25;
                }
            }

            ig[h].br20 -= r / 20;
            r -= r / 20 * 20;

            if (ig[h].br10 < r / 10) 
            {
                if (ig[h].br20 > 0)
                {
                    ig[h].br20--;
                    ig[h].br10 += 2;
                }
                else if (ig[h].br50 > 0)
                {
                    ig[h].br50--;
                    ig[h].br10 += 5;
                }
                else if (ig[h].br100 > 0)
                {
                    ig[h].br100--;
                    ig[h].br10 += 10;
                }
                else if (ig[h].br500 > 0)
                {
                    ig[h].br500--;
                    ig[h].br10 += 50;
                }
            }

            ig[h].br10 -= r / 10;
            r -= r / 10 * 10;

            if (ig[h].br5 < r / 5) 
            {
                if (ig[h].br10 > 0)
                {
                    ig[h].br10--;
                    ig[h].br5 += 2;
                }
                else if (ig[h].br20 > 0)
                {
                    ig[h].br20--;
                    ig[h].br5 += 4;
                }
                else if (ig[h].br50 > 0)
                {
                    ig[h].br50--;
                    ig[h].br5 += 10;
                }
                else if (ig[h].br100 > 0)
                {
                    ig[h].br100--;
                    ig[h].br5 += 20;
                }
                else if (ig[h].br500 > 0)
                {
                    ig[h].br500--;
                    ig[h].br5 += 100;
                }
            }

            ig[h].br5 -= r / 5;
            r -= r / 5 * 5;

            if (ig[h].br1 < r)
            {
                if (ig[h].br5 > 0) 
                {
                    ig[h].br5--;
                    ig[h].br1 += 5;
                }
                else if (ig[h].br10 > 0)
                {
                    ig[h].br10--;
                    ig[h].br1 += 10;
                }
                else if (ig[h].br20 > 0)
                {
                    ig[h].br20--;
                    ig[h].br1 += 20;
                }
                else if (ig[h].br50 > 0)
                {
                    ig[h].br50--;
                    ig[h].br1 += 50;
                }
                else if (ig[h].br100 > 0)
                {
                    ig[h].br100--;
                    ig[h].br1 += 100;
                }
                else if (ig[h].br500 > 0)
                {
                    ig[h].br500--;
                    ig[h].br1 += 500;
                }
            }

            ig[h].br1 -= r;
        }

        private void Upgrading(Ulice u) 
        {
            int i = 0;
            int h = 0;
            if (u.vlasnik == "player1") h = 0;
            if (u.vlasnik == "player2") h = 1;
            foreach (Ulice el in ul) 
            {
                if (el.boja == u.boja && el.vlasnik==u.vlasnik && el.BrKuca >= u.BrKuca && !u.hotel) 
                {
                    i++;
                }
            }
            if (u.boja == "braon") 
            {
                if (i == 2) 
                {
                    if (u.BrKuca == 4) { u.hotel = true; }
                    else { u.BrKuca++; }
                    ig[h].dugBanci = 50;
                    foreach (Ulice el in ul) { if (el.propertyclicked) { el.propertyclicked = false; pcl = 0; } }
                }
            }
            if (u.boja == "svplava")
            {
                if (i == 3)
                {
                    if (u.BrKuca == 4) { u.hotel = true; }
                    else { u.BrKuca++; }
                    ig[h].dugBanci = 50;
                    foreach (Ulice el in ul) { if (el.propertyclicked) { el.propertyclicked = false; pcl = 0; } }
                }
            }
            if (u.boja == "roze" || u.boja == "narandzasta")
            {
                if (i == 3)
                {
                    if (u.BrKuca == 4) { u.hotel = true; }
                    else { u.BrKuca++; }
                    ig[h].dugBanci = 100;
                    foreach (Ulice el in ul) { if (el.propertyclicked) { el.propertyclicked = false; pcl = 0; } }
                }
            }
            if (u.boja == "crvena" || u.boja == "zuta")
            {
                if (i == 3)
                {
                    if (u.BrKuca == 4) { u.hotel = true; }
                    else { u.BrKuca++; }
                    ig[h].dugBanci = 150;
                    foreach (Ulice el in ul) { if (el.propertyclicked) { el.propertyclicked = false; pcl = 0; } }
                }
            }
            if (u.boja == "zelena")
            {
                if (i == 3)
                {
                    if (u.BrKuca == 4) { u.hotel = true; }
                    else { u.BrKuca++; }
                    ig[h].dugBanci = 200;
                    foreach (Ulice el in ul) { if (el.propertyclicked) { el.propertyclicked = false; pcl = 0; } }
                }
            }
            if (u.boja == "plava")
            {
                if (i == 2)
                {
                    if (u.BrKuca == 4) { u.hotel = true; }
                    else { u.BrKuca++; }
                    ig[h].dugBanci = 200;
                    foreach (Ulice el in ul) { if (el.propertyclicked) { el.propertyclicked = false; pcl = 0; } }
                }
            }
        }

        private void Downgrade(Ulice u) 
        {
            if (u.BrKuca > 0) 
            {
                u.BrKuca--;
                foreach (Ulice el in ul) { if (el.propertyclicked) { el.propertyclicked = false; pcl = 0; } }
            }
        }

        private void GameStart(object sender, EventArgs e)
        {
            if (y == 2)
            {
                startgame = true;
            }
        }
        private void KockaKliknuta(object sender, EventArgs e)
        {
            if ((igrac1naPotezu && !ig[0].gotojail) || (igrac2naPotezu && !ig[1].gotojail) || !startgame || tryDoubles)
                kockaBacena = true;
        }
        private void kocka2Kliknuta(object sender, EventArgs e)
        {
            if ((igrac1naPotezu && !ig[0].gotojail) || (igrac2naPotezu && !ig[1].gotojail) || !startgame || tryDoubles)
                kocka2Bacena = true;
        }


        private void KrajPotezaIigraca() 
        {
            kockaBacena = false;
            kocka2Bacena = false;
            x = 0;
            igrac2naPotezu = true;
            igrac1naPotezu = false;
            buyProperty = false;
            propertyBought = false;
            dontbuyProperty = false;
            sum = 0;
            pr = 0;
            zat = 0;
            o = 0;
            Buy.Visible = false;
            DontBuy.Visible = false;
            if (sansaIzvucena) 
            {
                PomeriNiz(chances);
                sansaIzvucena = false;
            }
            if (comchestIzvucen) 
            {
                PomeriNiz(communitychests);
                comchestIzvucen = false;
            }
        }


        private void KrajPotezaIIigraca() 
        {
            kockaBacena = false;
            kocka2Bacena = false;
            x = 0;
            igrac1naPotezu = true;
            igrac2naPotezu = false;
            buyProperty = false;
            propertyBought = false;
            dontbuyProperty = false;
            sum = 0;
            pr = 0;
            zat = 0;
            o = 0;
            Buy.Visible = false;
            DontBuy.Visible = false;
            if (sansaIzvucena)
            {
                PomeriNiz(chances);
                sansaIzvucena = false;
            }
            if (comchestIzvucen)
            {
                PomeriNiz(communitychests);
                comchestIzvucen = false;
            }
        }


        private void ZavrsiPotez(object sender, EventArgs e)
        {
            if (igrac1naPotezu && kockaBacena == true && kocka2Bacena == true && ig[0].dugBanci == 0 && ig[0].dugIgracu == 0) 
            {
                if (brojacduplih1 > 0) 
                    KrajPotezaIIigraca();
                else
                    KrajPotezaIigraca();
            }
            if (ig[0].dugBanci > 0) 
            {
                Help.Visible = true;
                xButton.Visible = true;
                Help.Image = Properties.Resources.Uputstvo4;
            }
            if (ig[0].dugIgracu > 0) 
            {
                Help.Visible = true;
                xButton.Visible = true;
                Help.Image = Properties.Resources.Uputstvo3;
            }
        }
        private void Zavrsenpotez1(object sender, EventArgs e)
        {
            if (igrac2naPotezu && kockaBacena == true && kocka2Bacena == true && ig[1].dugBanci == 0 && ig[1].dugIgracu == 0)
            {
                if (brojacduplih2 > 0) 
                    KrajPotezaIigraca();
                else
                    KrajPotezaIIigraca();
            }
            if (ig[1].dugBanci > 0)
            {
                Help.Visible = true;
                xButton.Visible = true;
                Help.Image = Properties.Resources.Uputstvo4;
            }
            if (ig[1].dugIgracu > 0)
            {
                Help.Visible = true;
                xButton.Visible = true;
                Help.Image = Properties.Resources.Uputstvo3;
            }
        }

        private void DugmeKupi(object sender, EventArgs e)
        {
            if(kockaBacena && kocka2Bacena)
            buyProperty = true;
        }

        private void DugmeNeKupuj(object sender, EventArgs e)
        {
            if (DontBuy.Visible == true)
            {
                dontbuyProperty = true;
            }
        }

        private void ShowingProperties(Ulice i, string j, PictureBox k) 
        {
            if (i.vlasnik == j)
            {
                k.Visible = true;
            }
            else
                k.Visible = false;
        }

        private void ShowingPropertiesI(Poljanaprodaju i, string j, PictureBox k) 
        {
            if (i.vlasnik == j)
            {
                k.Visible = true;
            }
            else
                k.Visible = false;
        }

        private void PomeriNiz(string[] niz) 
        {
            int i;
            string pom;
            pom = niz[0];
            for (i = 0; i < niz.Length - 1; i++)
            {
                niz[i] = niz[i + 1];
            }
            niz[niz.Length - 1] = pom;
        } 

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            label1.Text = ig[0].br1.ToString();
            label2.Text = ig[0].br5.ToString();
            label3.Text = ig[0].br10.ToString();
            label4.Text = ig[0].br20.ToString();
            label5.Text = ig[0].br50.ToString();
            label17.Text = ig[0].br100.ToString();
            label18.Text = ig[0].br500.ToString();
            label6.Text = ig[1].br1.ToString();
            label7.Text = ig[1].br5.ToString();
            label8.Text = ig[1].br10.ToString();
            label9.Text = ig[1].br20.ToString();
            label10.Text = ig[1].br50.ToString();
            label19.Text = ig[1].br100.ToString();
            label20.Text = ig[1].br500.ToString();

            if (p > 0) { button2.Visible = true; }
            else { button2.Visible = false; }
            if (q > 0) { button3.Visible = true; }
            else { button3.Visible = false; }

            if (!sansaIzvucena) { Chance.Visible = false; }
            if (!comchestIzvucen) { CommunityChest.Visible = false; }

            foreach (Ulice el in ul) 
            {
                if (el.igracjenapolju && el.vlasnik == "" && kockaBacena && kocka2Bacena && 
                    ((ukupanbroj1 == el.BrojPolja - 1 && igrac1naPotezu) || (ukupanbroj2 == el.BrojPolja - 1 && igrac2naPotezu))) { Buy.Visible = true; }
                else v++;
            }
            foreach (Poljanaprodaju el in pnp)
            {
                if (el.igracjenapolju && el.vlasnik == "" && kockaBacena && kocka2Bacena && 
                    ((ukupanbroj1 == el.BrojPolja - 1 && igrac1naPotezu) || (ukupanbroj2 == el.BrojPolja - 1 && igrac2naPotezu))) { Buy.Visible = true; }
                else v++;
            }
            if (v == ul.Length + pnp.Length) 
            {
                Buy.Visible = false;
            }
            v = 0;

            if (!pokaziImanjaprvog && !pokaziImanjadrugog)
            {
                foreach (Control el in this.Controls)
                {
                    if (el is PictureBox && (string)el.Tag == "Title Deed")
                    {
                        el.Visible = false;
                    }
                }
            }

            if (igrac1naPotezu) label29.Text = "Na potezu!"; else label29.Text = "";
            if (igrac2naPotezu) label28.Text = "Na potezu!"; else label28.Text = "";

            if (brojacduplih1 > 0 || brojacduplih2 > 0)
            {
                if (!kockaBacena || !kocka2Bacena)
                {
                    label16.Visible = true;
                    label16.Text = "Dobio si dve iste na proslom bacanju, igras ponovo!";
                }
            }
            else { label16.Visible = false; }

            if (Buy.Visible && uput1 == 0) 
            {
                Help.Visible = true;
                xButton.Visible = true;
                Help.Image = Properties.Resources.Uputstvo1;
                uput1 = 1;
            }
            if (uput2 == 0) 
            {
                if (pokaziImanjaprvog || pokaziImanjadrugog) 
                {
                    Help.Visible = true;
                    xButton.Visible = true;
                    Help.Image = Properties.Resources.Uputstvo2;
                    uput2 = 1;
                }
            }

            if (pokaziImanjaprvog) 
            {
                ShowingProperties(ul[0], "player1", pictureBox16);
                ShowingProperties(ul[1], "player1", pictureBox17);
                ShowingProperties(ul[2], "player1", pictureBox18);
                ShowingProperties(ul[3], "player1", pictureBox19);
                ShowingProperties(ul[4], "player1", pictureBox20);
                ShowingProperties(ul[5], "player1", pictureBox21);
                ShowingProperties(ul[6], "player1", pictureBox22);
                ShowingProperties(ul[7], "player1", pictureBox23);
                ShowingProperties(ul[8], "player1", pictureBox24);
                ShowingProperties(ul[9], "player1", pictureBox25);
                ShowingProperties(ul[10], "player1", pictureBox26);
                ShowingProperties(ul[11], "player1", pictureBox27);
                ShowingProperties(ul[12], "player1", pictureBox28);
                ShowingProperties(ul[13], "player1", pictureBox29);
                ShowingProperties(ul[14], "player1", pictureBox30);
                ShowingProperties(ul[15], "player1", pictureBox31);
                ShowingProperties(ul[16], "player1", pictureBox32);
                ShowingProperties(ul[17], "player1", pictureBox33);
                ShowingProperties(ul[18], "player1", pictureBox34);
                ShowingProperties(ul[19], "player1", pictureBox35);
                ShowingProperties(ul[20], "player1", pictureBox36);
                ShowingProperties(ul[21], "player1", pictureBox37);
                ShowingPropertiesI(pnp[0], "player1", pictureBox38);
                ShowingPropertiesI(pnp[1], "player1", pictureBox42);
                ShowingPropertiesI(pnp[2], "player1", pictureBox39);
                ShowingPropertiesI(pnp[3], "player1", pictureBox40);
                ShowingPropertiesI(pnp[4], "player1", pictureBox43);
                ShowingPropertiesI(pnp[5], "player1", pictureBox41);
            }
            
            if (pokaziImanjadrugog)
            {
                ShowingProperties(ul[0], "player2", pictureBox16);
                ShowingProperties(ul[1], "player2", pictureBox17);
                ShowingProperties(ul[2], "player2", pictureBox18);
                ShowingProperties(ul[3], "player2", pictureBox19);
                ShowingProperties(ul[4], "player2", pictureBox20);
                ShowingProperties(ul[5], "player2", pictureBox21);
                ShowingProperties(ul[6], "player2", pictureBox22);
                ShowingProperties(ul[7], "player2", pictureBox23);
                ShowingProperties(ul[8], "player2", pictureBox24);
                ShowingProperties(ul[9], "player2", pictureBox25);
                ShowingProperties(ul[10], "player2", pictureBox26);
                ShowingProperties(ul[11], "player2", pictureBox27);
                ShowingProperties(ul[12], "player2", pictureBox28);
                ShowingProperties(ul[13], "player2", pictureBox29);
                ShowingProperties(ul[14], "player2", pictureBox30);
                ShowingProperties(ul[15], "player2", pictureBox31);
                ShowingProperties(ul[16], "player2", pictureBox32);
                ShowingProperties(ul[17], "player2", pictureBox33);
                ShowingProperties(ul[18], "player2", pictureBox34);
                ShowingProperties(ul[19], "player2", pictureBox35);
                ShowingProperties(ul[20], "player2", pictureBox36);
                ShowingProperties(ul[21], "player2", pictureBox37);
                ShowingPropertiesI(pnp[0], "player2", pictureBox38);
                ShowingPropertiesI(pnp[1], "player2", pictureBox42);
                ShowingPropertiesI(pnp[2], "player2", pictureBox39);
                ShowingPropertiesI(pnp[3], "player2", pictureBox40);
                ShowingPropertiesI(pnp[4], "player2", pictureBox43);
                ShowingPropertiesI(pnp[5], "player2", pictureBox41);
            }

            TurnCards();

            Label[] lab = new Label[] { label30, label31, label32, label33, label34, label35, label36, label37, label38, label39, label40, label41, label42, label43, 
            label44,label45,label46,label47,label48,label49,label50,label51};

            brLab = 0;

            foreach (Ulice el in ul) 
            {
                if (el.BrKuca > 0)
                {
                    lab[brLab].Visible = true;
                    if (!el.hotel)
                    {
                        lab[brLab].Text = el.BrKuca + "K";
                    }
                    if (el.hotel)
                    {
                        lab[brLab].Text = "Hotel";
                    }
                }
                else 
                {
                    lab[brLab].Visible = false;
                }
                brLab++;
            }

            if (igrac1naPotezu == false && igrac2naPotezu == false)
            {
                label11.Visible = true;
                label12.Visible = true;
                label14.Visible = true;
                if (kockaBacena == true && kocka2Bacena == true)
                {
                    if (y == 0)
                    {
                        u = brojprvekocke + brojdrugekocke;
                        kockaBacena = false;
                        kocka2Bacena = false;
                        label11.Text = " " + u;
                    }
                    if (y == 1)
                    {
                        u1 = brojprvekocke + brojdrugekocke;
                        label12.Text = " " + u1;
                    }
                    if (y < 2) y++;
                }
                if (y < 2)
                {
                    StartButton.Visible = false;
                    label13.Visible = false;
                }
                if (y == 2)
                {
                    StartButton.Visible = true;
                    if (u == u1)
                    {
                        StartButton.Text = "Ponovi";
                        label13.Visible = true;
                    }
                    else 
                    {
                        StartButton.Text = "Zapocni igru";
                        label13.Visible = false;
                    }
                    if (startgame == true)
                    {
                        if (u > u1)
                        {
                            igrac1naPotezu = true;
                            igrac2naPotezu = false;
                            kockaBacena = false;
                            kocka2Bacena = false;
                        }
                        if(u < u1)
                        {
                            igrac2naPotezu = true;
                            igrac1naPotezu = false;
                            kockaBacena = false;
                            kocka2Bacena = false;
                        }
                        if (u == u1) 
                        {
                            y = 1;
                            kockaBacena = false;
                            kocka2Bacena = false;
                            startgame = false;
                            label12.Text = " ";
                        }
                    }
                }
            }
            else 
            {
                label11.Visible = false;
                label12.Visible = false;
                label14.Visible = false;
                StartButton.Visible = false;
            }

            if (((ig[0].gotojail && igrac1naPotezu) || (ig[1].gotojail && igrac2naPotezu)) && zat==0)
            {
                button4.Visible = true;
                button5.Visible = true;
            }
            else 
            {
                button4.Visible = false;
                button5.Visible = false;
            }

            if (db1) { ig[0].dugBanci = 50; parkingNovac += 50; db1 = false; }
            if (db2) { ig[1].dugBanci = 50; parkingNovac += 50; db2 = false; }

            if (pay50) 
            {
                kockaBacena = true;
                kocka2Bacena = true;
                brojprvekocke = 0;
                brojdrugekocke = 0;
                if (igrac1naPotezu) { db1 = true; ig[0].gotojail = false; f = 0; o = 1; }
                if (igrac2naPotezu) { db2 = true; ig[1].gotojail = false; f = 0; o = 1; }
                pay50 = false;
            }


            if (kockaBacena == false) 
            {
                if ((igrac1naPotezu && !ig[0].gotojail) || (igrac2naPotezu && !ig[1].gotojail) || !startgame || tryDoubles)
                {
                    switch (brojaclicakocke)
                    {
                        case 1: kocka1.Image = Properties.Resources.Alea_1; brojprvekocke = 1; break;
                        case 2: kocka1.Image = Properties.Resources.Alea_2; brojprvekocke = 2; break;
                        case 3: kocka1.Image = Properties.Resources.Alea_3; brojprvekocke = 3; break;
                        case 4: kocka1.Image = Properties.Resources.Alea_4; brojprvekocke = 4; break;
                        case 5: kocka1.Image = Properties.Resources.Alea_5; brojprvekocke = 5; break;
                        case 6: kocka1.Image = Properties.Resources.Alea_6; brojprvekocke = 6; break;
                    }
                    brojaclicakocke++;
                    if (brojaclicakocke == 7)
                    {
                        brojaclicakocke = 1;
                    }
                }
            }
            if (kocka2Bacena == false)
            {
                if ((igrac1naPotezu && !ig[0].gotojail) || (igrac2naPotezu && !ig[1].gotojail) || !startgame || tryDoubles)
                {
                    switch (brojaclicakocke2)
                    {
                        case 1: kocka2.Image = Properties.Resources.Alea_1; brojdrugekocke = 1; break;
                        case 2: kocka2.Image = Properties.Resources.Alea_2; brojdrugekocke = 2; break;
                        case 3: kocka2.Image = Properties.Resources.Alea_3; brojdrugekocke = 3; break;
                        case 4: kocka2.Image = Properties.Resources.Alea_4; brojdrugekocke = 4; break;
                        case 5: kocka2.Image = Properties.Resources.Alea_5; brojdrugekocke = 5; break;
                        case 6: kocka2.Image = Properties.Resources.Alea_6; brojdrugekocke = 6; break;
                    }
                    brojaclicakocke2++;
                    if (brojaclicakocke2 == 7)
                    {
                        brojaclicakocke2 = 1;
                    }
                }
            }

            if (tryDoubles) 
            {
                if (kockaBacena && kocka2Bacena) 
                {
                    if (brojprvekocke == brojdrugekocke)
                    {
                        if (igrac1naPotezu) { ig[0].gotojail = false; f = 0; o = 1; }
                        if (igrac2naPotezu) { ig[1].gotojail = false; f = 0; o = 1; }
                    }
                    else { f++; }
                    brojprvekocke = 0;
                    brojdrugekocke = 0;
                    tryDoubles = false;
                }
            }

            if (f == 3) 
            {
                if (igrac1naPotezu) { db1 = true; ig[0].gotojail = false; f = 0; o = 1; }
                if (igrac2naPotezu) { db2 = true; ig[1].gotojail = false; f = 0; o = 1; }
            }

            if (brojprvekocke == brojdrugekocke && kockaBacena && kocka2Bacena)
            {
                if (igrac1naPotezu)
                {
                    if (pr == 0)
                    {
                        brojacduplih1++;
                        pr = 1;
                    }
                }
                if (igrac2naPotezu)
                {
                    if (pr == 0)
                    {
                        brojacduplih2++;
                        pr = 1;
                    }
                }
            }
            else if (brojprvekocke != brojdrugekocke && kockaBacena && kocka2Bacena)
            {
                if (igrac1naPotezu) { brojacduplih1 = 0; }
                if (igrac2naPotezu) { brojacduplih2 = 0; }
            }

            if (igrac1naPotezu==true && kockaBacena == true && kocka2Bacena == true && x == 0)
            {
                ukupanbroj1 += brojprvekocke + brojdrugekocke;
                x++;
            }
            if (igrac2naPotezu == true && kockaBacena == true && kocka2Bacena == true && x == 0)
            {
                ukupanbroj2 += brojprvekocke + brojdrugekocke;
                x++;
            }

            if (i <= ukupanbroj1 + 1 && igrac1naPotezu == true) 
            {
                foreach (Takse elm in t)
                {
                    if (elm.BrojPolja == i)
                    {
                        k = elm.nazivPolja;
                    }
                }
                foreach (CommunityChestChance elm in cc)
                {
                    if (elm.BrojPolja == i)
                    {
                        k = elm.nazivPolja;
                    }
                }
                foreach (UgaonaPolja elm in up)
                {
                    if (elm.BrojPolja == i)
                    {
                        k = elm.nazivPolja;
                    }
                }
                if (z.BrojPolja == i) { k = z.nazivPolja; }
                foreach (Poljanaprodaju elm in pnp)
                {
                    if (elm.BrojPolja == i)
                    {
                        k = elm.nazivPolja;
                    }
                }
                foreach (Ulice elm in ul)
                {
                    if (elm.BrojPolja == i)
                    {
                        k = elm.nazivPolja;
                    }
                }
                foreach (Control el in this.Controls) 
                {
                    if (el is PictureBox && (string)el.Name==k) 
                    {
                        player1.Left = el.Left + 10;
                        player1.Top = el.Top + 10;
                    }
                }
                if (i <= 40)
                {
                    i++;
                    ig[0].dugIgracu = 0;
                    ig[0].dugBanci = 0;
                    br = 0;
                }
                else if (ukupanbroj1 >= 40)
                {
                    i = 1;
                    ukupanbroj1 -= 40;
                    ig[0].dugIgracu = 0;
                    ig[0].dugBanci = 0;
                    br = 0;
                    ig[0].br100 += 2;
                }
            }
            if (j <= ukupanbroj2 + 1 && igrac2naPotezu == true)
            {
                foreach (Takse elm in t)
                {
                    if (elm.BrojPolja == j)
                    {
                        k = elm.nazivPolja;
                    }
                }
                foreach (CommunityChestChance elm in cc)
                {
                    if (elm.BrojPolja == j)
                    {
                        k = elm.nazivPolja;
                    }
                }
                foreach (UgaonaPolja elm in up)
                {
                    if (elm.BrojPolja == j)
                    {
                        k = elm.nazivPolja;
                    }
                }
                if (z.BrojPolja == j) { k = z.nazivPolja; }
                foreach (Poljanaprodaju elm in pnp)
                {
                    if (elm.BrojPolja == j)
                    {
                        k = elm.nazivPolja;
                    }
                }
                foreach (Ulice elm in ul)
                {
                    if (elm.BrojPolja == j)
                    {
                        k = elm.nazivPolja;
                    }
                }
                foreach (Control el in this.Controls)
                {
                    if (el is PictureBox && (string)el.Name == k)
                    {
                        player2.Left = el.Left + 10;
                        player2.Top = el.Top + 10;
                    }
                }
                if (j <= 40)
                {
                    j++;
                    ig[1].dugIgracu = 0;
                    ig[1].dugBanci = 0;
                    brj = 0;
                }
                else if (ukupanbroj2 >= 40)
                {
                    j = 1;
                    ukupanbroj2 -= 40;
                    ig[1].dugIgracu = 0;
                    ig[1].dugBanci = 0;
                    brj = 0;
                    ig[1].br100 += 2;
                }
            }



            foreach (Control el in this.Controls) 
            {
                if (player1.Bounds.IntersectsWith(el.Bounds) && igrac1naPotezu==true) 
                {
                    imePolja = el.Name;
                }
                if (player2.Bounds.IntersectsWith(el.Bounds) && igrac2naPotezu == true) 
                {
                    imePolja = el.Name;
                }
            }


            foreach (Poljanaprodaju el in pnp) 
            {
                if (el.vrstapoljanaprodaju == "Komunalije") 
                {
                    el.Rent = brojprvekocke + brojdrugekocke;
                }
            }

            
            /**/
            foreach (Ulice el in ul) 
            {
                if (el.nazivPolja == imePolja)
                    el.igracjenapolju = true;
                else
                    el.igracjenapolju = false;
            }
            foreach (Takse el in t)
            {
                if (el.nazivPolja == imePolja)
                    el.igracjenapolju = true;
                else
                    el.igracjenapolju = false;
            }
            foreach (Poljanaprodaju el in pnp)
            {
                if (el.nazivPolja == imePolja)
                    el.igracjenapolju = true;
                else
                    el.igracjenapolju = false;
            }
            foreach (UgaonaPolja el in up)
            {
                if (el.nazivPolja == imePolja)
                    el.igracjenapolju = true;
                else
                    el.igracjenapolju = false;
            }
            foreach (CommunityChestChance el in cc)
            {
                if (el.nazivPolja == imePolja)
                    el.igracjenapolju = true;
                else
                    el.igracjenapolju = false;
            }
            if (z.nazivPolja == imePolja)
                z.igracjenapolju = true;
            else
                z.igracjenapolju = false;
            /**/
            

            foreach (Ulice el in ul) 
            {
                if (el.igracjenapolju == true) 
                {
                    if (el.vlasnik == "" && buyProperty == true)
                    {
                        if (igrac1naPotezu == true && el.Cena < ig[0].Ukupanbudzet)
                        {
                            el.vlasnik = "player1";
                            p++;
                            ig[0].dugBanci = el.Cena;
                        }
                        if (igrac2naPotezu == true && el.Cena < ig[1].Ukupanbudzet)
                        {
                            el.vlasnik = "player2";
                            q++;
                            ig[1].dugBanci = el.Cena;
                        }
                        propertyBought = true;
                    }
                    if (propertyBought)
                    {
                        DontBuy.Visible = true;
                        if (dontbuyProperty)
                        {
                            el.vlasnik = "";
                            if (igrac1naPotezu) { p--; }
                            if (igrac2naPotezu) { q--; }
                            ig[0].dugBanci = 0;
                            ig[1].dugBanci = 0;
                            Kusur(0, sum);
                            sum = 0;
                            buyProperty = false;
                            propertyBought = false;
                            dontbuyProperty = false;
                        }
                    }
                    else
                    {
                        DontBuy.Visible = false;
                    }
                    if (igrac1naPotezu && el.vlasnik == "player2" && !el.hipoteka)
                    {
                        if (br == 0)
                        {
                            if (el.BrKuca == 0)
                            {
                                ig[0].dugIgracu = el.Rent;
                            }
                            if (el.BrKuca == 1)
                            {
                                ig[0].dugIgracu = el.RentJK;
                            }
                            if (el.BrKuca == 2)
                            {
                                ig[0].dugIgracu = el.RentDK;
                            }
                            if (el.BrKuca == 3)
                            {
                                ig[0].dugIgracu = el.RentTK;
                            }
                            if (el.BrKuca == 4)
                            {
                                ig[0].dugIgracu = el.RentCK;
                            }
                            if (el.hotel == true)
                            {
                                ig[0].dugIgracu = el.RentH;
                            }
                            br = 1;
                        }
                    }
                    /*else 
                    { 
                        ig[0].dugIgracu = 0;
                        br = 0;
                    }*/
                    if (igrac2naPotezu && el.vlasnik == "player1" && !el.hipoteka)
                    {
                        if (brj == 0)
                        {
                            if (el.BrKuca == 0)
                            {
                                ig[1].dugIgracu = el.Rent;
                            }
                            if (el.BrKuca == 1)
                            {
                                ig[1].dugIgracu = el.RentJK;
                            }
                            if (el.BrKuca == 2)
                            {
                                ig[1].dugIgracu = el.RentDK;
                            }
                            if (el.BrKuca == 3)
                            {
                                ig[1].dugIgracu = el.RentTK;
                            }
                            if (el.BrKuca == 4)
                            {
                                ig[1].dugIgracu = el.RentCK;
                            }
                            if (el.hotel == true)
                            {
                                ig[1].dugIgracu = el.RentH;
                            }
                            brj = 1;
                        }
                    }
                    /*else 
                    { 
                        ig[1].dugIgracu = 0;
                        brj = 0;
                    }*/
                }
            }

            foreach (Poljanaprodaju el in pnp)
            {
                if (el.igracjenapolju)
                {
                    if (el.vlasnik == "" && buyProperty == true)
                    {
                        if (igrac1naPotezu == true && el.Cena < ig[0].Ukupanbudzet)
                        {
                            el.vlasnik = "player1";
                            p++;
                            ig[0].dugBanci = el.Cena;
                            if (el.vrstapoljanaprodaju == "Railroad") 
                            {
                                ig[0].noofRailRoads++;
                            }
                            if (el.vrstapoljanaprodaju == "Komunalije") 
                            {
                                ig[0].noofUtilities++;
                            }
                        }
                        if (igrac2naPotezu == true && el.Cena < ig[1].Ukupanbudzet)
                        {
                            el.vlasnik = "player2";
                            q++;
                            ig[1].dugBanci = el.Cena;
                            if (el.vrstapoljanaprodaju == "Railroad")
                            {
                                ig[1].noofRailRoads++;
                            }
                            if (el.vrstapoljanaprodaju == "Komunalije")
                            {
                                ig[1].noofUtilities++;
                            }
                        }
                        propertyBought = true;
                    }
                    if (propertyBought)
                    {
                        DontBuy.Visible = true;
                        if (dontbuyProperty)
                        {
                            el.vlasnik = "";
                            if (igrac1naPotezu)
                            {
                                p--;
                                if (el.vrstapoljanaprodaju == "Railroad")
                                {
                                    ig[0].noofRailRoads--;
                                }
                                if (el.vrstapoljanaprodaju == "Komunalije") 
                                {
                                    ig[0].noofUtilities--;
                                }
                            }
                            if (igrac2naPotezu)
                            {
                                q--;
                                if (el.vrstapoljanaprodaju == "Railroad")
                                {
                                    ig[1].noofRailRoads--;
                                }
                                if (el.vrstapoljanaprodaju == "Komunalije")
                                {
                                    ig[1].noofUtilities--;
                                }
                            }
                            ig[0].dugBanci = 0;
                            ig[1].dugBanci = 0;
                            Kusur(0, sum);
                            sum = 0;
                            buyProperty = false;
                            propertyBought = false;
                            dontbuyProperty = false;
                        }
                    }
                    else
                    {
                        DontBuy.Visible = false;
                    }

                    if (igrac1naPotezu && el.vlasnik == "player2" && !el.hipoteka)
                    {
                        if (el.vrstapoljanaprodaju == "Railroad")
                        {
                            if (br == 0)
                            {
                                if (ig[1].noofRailRoads == 1)
                                {
                                    ig[0].dugIgracu = el.Rent;
                                }
                                if (ig[1].noofRailRoads == 2)
                                {
                                    ig[0].dugIgracu = el.Rent * 2;
                                }
                                if (ig[1].noofRailRoads == 3)
                                {
                                    ig[0].dugIgracu = el.Rent * 4;
                                }
                                if (ig[1].noofRailRoads == 4)
                                {
                                    ig[0].dugIgracu = el.Rent * 8;
                                }
                                br = 1;
                            }
                        }
                        if (el.vrstapoljanaprodaju == "Komunalije") 
                        {
                            if (br == 0)
                            {
                                if (ig[1].noofUtilities == 1)
                                {
                                    ig[0].dugIgracu = el.Rent * 4;
                                }
                                if (ig[1].noofUtilities == 2)
                                {
                                    ig[0].dugIgracu = el.Rent * 10;
                                }
                                br = 1;
                            }
                        }
                    }
                    if (igrac2naPotezu && el.vlasnik == "player1" && !el.hipoteka)
                    {
                        if (el.vrstapoljanaprodaju == "Railroad")
                        {
                            if (brj == 0)
                            {
                                if (ig[0].noofRailRoads == 1)
                                {
                                    ig[1].dugIgracu = el.Rent;
                                }
                                if (ig[0].noofRailRoads == 2)
                                {
                                    ig[1].dugIgracu = el.Rent * 2;
                                }
                                if (ig[0].noofRailRoads == 3)
                                {
                                    ig[1].dugIgracu = el.Rent * 4;
                                }
                                if (ig[0].noofRailRoads == 4)
                                {
                                    ig[1].dugIgracu = el.Rent * 8;
                                }
                                brj = 1;
                            }
                        }
                        if (el.vrstapoljanaprodaju == "Komunalije")
                        {
                            if (brj == 0)
                            {
                                if (ig[0].noofUtilities == 1)
                                {
                                    ig[1].dugIgracu = el.Rent * 4;
                                }
                                if (ig[0].noofUtilities == 2)
                                {
                                    ig[1].dugIgracu = el.Rent * 10;
                                }
                                brj = 1;
                            }
                        }
                    }

                }
            }
            /**/

            foreach (Takse el in t) 
            {
                if (el.igracjenapolju) 
                {
                    if ((igrac1naPotezu && ukupanbroj1 == el.BrojPolja - 1) || (igrac2naPotezu && ukupanbroj2 == el.BrojPolja - 1))
                    {
                        if (el.nazivPolja == "income_tax1")
                        {
                            if (igrac1naPotezu)
                            {
                                if (br == 0)
                                {
                                    ig[0].dugBanci = 200;
                                    parkingNovac += 200;
                                    br = 1;
                                }
                            }
                            if (igrac2naPotezu)
                            {
                                if (brj == 0)
                                {
                                    ig[1].dugBanci = 200;
                                    parkingNovac += 200;
                                    brj = 1;
                                }
                            }
                        }
                        if (el.nazivPolja == "luxury_tax")
                        {
                            if (igrac1naPotezu)
                            {
                                if (br == 0)
                                {
                                    ig[0].dugBanci = 100;
                                    parkingNovac += 100;
                                    br = 1;
                                }
                            }
                            if (igrac2naPotezu)
                            {
                                if (brj == 0)
                                {
                                    ig[1].dugBanci = 100;
                                    parkingNovac += 100;
                                    brj = 1;
                                }
                            }
                        }
                    }
                }
            }

            if (up[1].igracjenapolju)
            {
                if ((igrac1naPotezu && ukupanbroj1 == up[1].BrojPolja - 1) || (igrac2naPotezu && ukupanbroj2 == up[1].BrojPolja - 1))
                {
                    if (parkingNovac == 0 && r == 0)
                    {
                        if (igrac1naPotezu) { if (br == 0) { ig[0].br100++; br = 1; } }
                        if (igrac2naPotezu) { if (brj == 0) { ig[1].br100++; brj = 1; } }
                        r = 1;
                    }
                    else
                    {
                        Kusur(0, parkingNovac);
                        parkingNovac = 0;
                        r = 1;
                    }
                }
            }
            else r = 0;

            if (brojacduplih1 == 3) 
            {
                ig[0].gotojail = true;
                KrajPotezaIigraca();
                Help.Visible = true;
                xButton.Visible = true;
                Help.Image = Properties.Resources.Uputstvo5;
                brojacduplih1 = 0;
            }

            if (brojacduplih2 == 3) 
            {
                ig[1].gotojail = true;
                KrajPotezaIIigraca();
                Help.Visible = true;
                xButton.Visible = true;
                Help.Image = Properties.Resources.Uputstvo5;
                brojacduplih2 = 0;
            }

            if (up[2].igracjenapolju) 
            {
                if (igrac1naPotezu && ukupanbroj1 == up[2].BrojPolja - 1) 
                {
                    if (br == 0) { ig[0].gotojail = true; br = 1; KrajPotezaIigraca(); } 
                }
                if (igrac2naPotezu && ukupanbroj2 == up[2].BrojPolja - 1) 
                {
                    if (brj == 0) { ig[1].gotojail = true; brj = 1; KrajPotezaIIigraca(); } 
                }
            }

            c = 0;

            foreach (Ulice el in ul) 
            {
                if (el.propertyclicked && el.hipoteka)
                {
                    button11.Text = "Podigni hipoteku";
                    c = 1;
                }
                else if (c == 0) { button11.Text = "Hipoteka"; }
            }
            foreach (Poljanaprodaju el in pnp)
            {
                if (el.propertyclicked && el.hipoteka && c == 0)
                {
                    button11.Text = "Podigni hipoteku";
                    c = 1;
                }
                else if (c == 0) { button11.Text = "Hipoteka"; }
            }

            label15.Text = parkingNovac + "$";
            label21.Text = "Dug banci: " + ig[0].dugBanci.ToString();
            label22.Text = "Dug banci: " + ig[1].dugBanci.ToString();
            label24.Text = "Dug igracu: " + ig[0].dugIgracu.ToString();
            label25.Text = "Dug igracu: " + ig[1].dugIgracu.ToString();
            label26.Text = "Novac: " + ig[0].Ukupanbudzet.ToString();
            label27.Text = "Novac:" + ig[1].Ukupanbudzet.ToString();

            if (ig[0].gotojail)
            {
                i = 11;
                ukupanbroj1 = 10;
                player1.Left = Jail.Left + 10;
                player1.Top = Jail.Top + 10;
                brojacduplih1 = 0;
            }

            if (ig[1].gotojail)
            {
                j = 11;
                ukupanbroj2 = 10;
                player2.Left = Jail.Left + 10;
                player2.Top = Jail.Top + 10;
                brojacduplih2 = 0;
            }
            
            /*communitychest/chances*/

            foreach (CommunityChestChance el in cc) 
            {
                if (el.igracjenapolju && kockaBacena && kocka2Bacena)
                {
                    if ((ukupanbroj1 == el.BrojPolja - 1 && igrac1naPotezu) || (ukupanbroj2 == el.BrojPolja - 1 && igrac2naPotezu))
                    {
                        if (el.vrstaPolja == "chance")
                        {
                            IzvlacenjeSanse();
                            Chance.Visible = true;
                            sansaIzvucena = true;
                        }
                        if (el.vrstaPolja == "communitychest") 
                        {
                            IzvlacenjeCommunityChesta();
                            CommunityChest.Visible = true;
                            comchestIzvucen = true;
                        }
                    }
                }
            }
            
            /*communitychest/chances*/

            foreach (Igrac el in ig) 
            {
                if (el.gotojail && el.getoutofjail) 
                {
                    el.gotojail = false;
                    el.getoutofjail = false;
                }
            }

            /**/


            foreach (Ulice el in ul) 
            {
                if (el.propertyclicked) 
                {
                    pcl = 1;
                }
            }
            foreach (Poljanaprodaju el in pnp) 
            {
                if (el.propertyclicked) 
                {
                    pcl = 1;
                }
            }

            if (pcl == 1)
            {
                button6.Visible = true;
                button7.Visible = true;
                button8.Visible = true;
                button9.Visible = true;
                button11.Visible = true;
            }
            else 
            {
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
                button9.Visible = false;
                button11.Visible = false;
                textBox1.Visible = false;
                button10.Visible = false;
            }

            /**/

            if (o == 1) 
            {
                if (igrac1naPotezu) { brojacduplih1 = 0; }
                if (igrac2naPotezu) { brojacduplih2 = 0; }
            }

            if (ig[0].dugBanci > ig[0].Ukupanbudzet || ig[0].dugIgracu > ig[0].Ukupanbudzet) 
            {
                GameTimer.Stop();
                MessageBox.Show("Igrac 2 je pobedio" + Environment.NewLine + "Klikni ok da igras ponovo!");
                RestartGame();
            }
            if (ig[1].dugBanci > ig[1].Ukupanbudzet || ig[1].dugIgracu > ig[1].Ukupanbudzet)
            {
                GameTimer.Stop();
                MessageBox.Show("Igrac 1 je pobedio" + Environment.NewLine + "Klikni ok da igras ponovo!");
                RestartGame();
            }
        }

        private void RestartGame() 
        {
            Form1 noviProzor = new Form1();
            noviProzor.Show();
            this.Hide();
        }

        public void IzvlacenjeSanse() 
        {
            int x = 0;
            if (chances[0] == "chance7") 
            {
                if (igrac1naPotezu) { if (ig[0].getoutofjail) { PomeriNiz(chances); } }
                if (igrac2naPotezu) { if (ig[1].getoutofjail) { PomeriNiz(chances); } }
            }
            if (chances[0] == "chance1")
            {
                Chance.Image = Properties.Resources.chance1;
                if (igrac1naPotezu) { ukupanbroj1 = 40; }
                if (igrac2naPotezu) { ukupanbroj2 = 40; }
            }
            else if (chances[0] == "chance2")
            {
                Chance.Image = Properties.Resources.chance2;
                if (igrac1naPotezu) 
                {
                    if (ukupanbroj1 < 24) ukupanbroj1 = 24;
                    else ukupanbroj1 = 40 + 24 - 1;
                }
                if (igrac2naPotezu) 
                {
                    if (ukupanbroj2 < 24) ukupanbroj2 = 24;
                    else ukupanbroj2 = 40 + 24 - 1;
                }
            }
            else if (chances[0] == "chance3")
            {
                Chance.Image = Properties.Resources.chance3;
                if (igrac1naPotezu)
                {
                    if (ukupanbroj1 < 12) ukupanbroj1 = 12;
                    else ukupanbroj1 = 40 + 12 - 1;
                }
                if (igrac2naPotezu)
                {
                    if (ukupanbroj2 < 12) ukupanbroj2 = 12;
                    else ukupanbroj2 = 40 + 12 - 1;
                }
            }
            else if (chances[0] == "chance4")
            {
                Chance.Image = Properties.Resources.chance4;
                if (igrac1naPotezu)
                {
                    if (ukupanbroj1 < pnp[1].BrojPolja) ukupanbroj1 = pnp[1].BrojPolja - 1;
                    else if (ukupanbroj1 < pnp[4].BrojPolja) ukupanbroj1 = pnp[4].BrojPolja - 1;
                    else ukupanbroj1 = 40 + pnp[1].BrojPolja -1;
                }
                if (igrac2naPotezu)
                {
                    if (ukupanbroj2 < pnp[1].BrojPolja) ukupanbroj2 = pnp[1].BrojPolja - 1;
                    else if (ukupanbroj2 < pnp[4].BrojPolja) ukupanbroj2 = pnp[4].BrojPolja - 1;
                    else ukupanbroj2 = 40 + pnp[1].BrojPolja - 1;
                }
            }
            else if (chances[0] == "chance5")
            {
                Chance.Image = Properties.Resources.chance5;
                if (igrac1naPotezu)
                {
                    if (ukupanbroj1 < pnp[0].BrojPolja) ukupanbroj1 = pnp[0].BrojPolja - 1;
                    else if (ukupanbroj1 < pnp[2].BrojPolja) ukupanbroj1 = pnp[2].BrojPolja - 1;
                    else if (ukupanbroj1 < pnp[3].BrojPolja) ukupanbroj1 = pnp[3].BrojPolja - 1;
                    else if (ukupanbroj1 < pnp[5].BrojPolja) ukupanbroj1 = pnp[5].BrojPolja - 1;
                    else ukupanbroj1 = 40 + pnp[0].BrojPolja - 1;
                }
                if (igrac2naPotezu)
                {
                    if (ukupanbroj2 < pnp[0].BrojPolja) ukupanbroj2 = pnp[0].BrojPolja - 1;
                    else if (ukupanbroj2 < pnp[2].BrojPolja) ukupanbroj2 = pnp[2].BrojPolja - 1;
                    else if (ukupanbroj2 < pnp[3].BrojPolja) ukupanbroj2 = pnp[3].BrojPolja - 1;
                    else if (ukupanbroj2 < pnp[5].BrojPolja) ukupanbroj2 = pnp[5].BrojPolja - 1;
                    else ukupanbroj2 = 40 + pnp[0].BrojPolja - 1;
                }
            }
            else if (chances[0] == "chance6")
            {
                Chance.Image = Properties.Resources.chance6;
                if (igrac1naPotezu) { if (br == 0) { ig[0].br50++; br = 1; } }
                if (igrac2naPotezu) { if (brj == 0) { ig[1].br50++; brj = 1; } }
            }
            else if (chances[0] == "chance7")
            {
                Chance.Image = Properties.Resources.chance7;
                if (igrac1naPotezu) { ig[0].getoutofjail = true; }
                if (igrac2naPotezu) { ig[1].getoutofjail = true; }
            }
            else if (chances[0] == "chance8")
            {
                Chance.Image = Properties.Resources.chance8;
                if (igrac1naPotezu) 
                {
                    if (ukupanbroj1 == cc[1].BrojPolja - 1) 
                    {
                        i=cc[1].BrojPolja-3;
                        ukupanbroj1 = cc[1].BrojPolja - 4;
                        player1.Left = income_tax1.Left + 10;
                        player1.Top = income_tax1.Top + 10;
                    }
                    else if (ukupanbroj1 == cc[3].BrojPolja - 1)
                    {
                        i = cc[3].BrojPolja - 3;
                        ukupanbroj1 = cc[3].BrojPolja - 4;
                        player1.Left = ny_avenue.Left + 10;
                        player1.Top = ny_avenue.Top + 10;
                    }
                    else if (ukupanbroj1 == cc[5].BrojPolja - 1)
                    {
                        i = cc[5].BrojPolja - 3;
                        ukupanbroj1 = cc[5].BrojPolja - 4;
                        player1.Left = Comunity_Chest1.Left + 10;
                        player1.Top = Comunity_Chest1.Top + 10;
                    }
                }
                if (igrac2naPotezu) 
                {
                    if (ukupanbroj2 == cc[1].BrojPolja - 1)
                    {
                        j = cc[1].BrojPolja - 3;
                        ukupanbroj2 = cc[1].BrojPolja - 4;
                        player2.Left = income_tax1.Left + 10;
                        player2.Top = income_tax1.Top + 10;
                    }
                    else if (ukupanbroj2 == cc[3].BrojPolja - 1)
                    {
                        j = cc[3].BrojPolja - 3;
                        ukupanbroj2 = cc[3].BrojPolja - 4;
                        player2.Left = ny_avenue.Left + 10;
                        player2.Top = ny_avenue.Top + 10;
                    }
                    else if (ukupanbroj2 == cc[5].BrojPolja - 1)
                    {
                        j = cc[5].BrojPolja - 3;
                        ukupanbroj2 = cc[5].BrojPolja - 4;
                        player2.Left = Comunity_Chest1.Left + 10;
                        player2.Top = Comunity_Chest1.Top + 10;
                    }
                }
            }
            else if (chances[0] == "chance9")
            {
                Chance.Image = Properties.Resources.chance9;
                if (igrac1naPotezu) { ig[0].gotojail = true; KrajPotezaIigraca(); }
                if (igrac2naPotezu) { ig[1].gotojail = true; KrajPotezaIIigraca(); }
            }
            else if (chances[0] == "chance10")
            {
                Chance.Image = Properties.Resources.chance10;
                foreach (Ulice el in ul) 
                {
                    if ((igrac1naPotezu && el.vlasnik == "player1") || (igrac2naPotezu && el.vlasnik == "player2"))
                    {
                        if (!el.hotel)
                        {
                            x += 25 * el.BrKuca;
                        }
                        else
                        {
                            x += 100;
                        }
                    }
                }
                if (igrac1naPotezu) { if (br == 0) { ig[0].dugBanci = x; parkingNovac += x; br = 1; } }
                if (igrac2naPotezu) { if (brj == 0) { ig[1].dugBanci = x; parkingNovac += x; brj = 1; } }
            }
            else if (chances[0] == "chance11")
            {
                Chance.Image = Properties.Resources.chance11;
                if (igrac1naPotezu) { if (br == 0) { ig[0].dugBanci = 15; parkingNovac += 15; br = 1; } }
                if (igrac2naPotezu) { if (brj == 0) { ig[1].dugBanci = 15; parkingNovac += 15; brj = 1; } }
            }
            else if (chances[0] == "chance12")
            {
                Chance.Image = Properties.Resources.chance12;
                if (igrac1naPotezu)
                {
                    if (ukupanbroj1 < pnp[0].BrojPolja) ukupanbroj1 = pnp[0].BrojPolja - 1;
                    else ukupanbroj1 = 40 + pnp[0].BrojPolja;
                }
                if (igrac2naPotezu)
                {
                    if (ukupanbroj2 < pnp[0].BrojPolja) ukupanbroj2 = pnp[0].BrojPolja - 1;
                    else ukupanbroj2 = 40 + pnp[0].BrojPolja;
                }
            }
            else if (chances[0] == "chance13")
            {
                Chance.Image = Properties.Resources.chance13;
                if (igrac1naPotezu) { ukupanbroj1 = ul[ul.Length - 1].BrojPolja - 1; }
                if (igrac2naPotezu) { ukupanbroj2 = ul[ul.Length - 1].BrojPolja - 1; }
            }
            else if (chances[0] == "chance14")
            {
                if (igrac1naPotezu) { if (br == 0) { ig[0].dugIgracu = 50; br = 1; } }
                if (igrac2naPotezu) { if (brj == 0) { ig[1].dugIgracu = 50; brj = 1; } }
                Chance.Image = Properties.Resources.chance14;
            }
            else if (chances[0] == "chance15")
            {
                if (igrac1naPotezu) { if (br == 0) { ig[0].br50++; ig[0].br100++; br = 1; } }
                if (igrac2naPotezu) { if (brj == 0) { ig[1].br50++; ig[1].br100++; brj = 1; } }
                Chance.Image = Properties.Resources.chance15;
            }
            else if (chances[0] == "chance16")
            {
                if (igrac1naPotezu) { if (br == 0) { ig[0].br100++; br = 1; } }
                if (igrac2naPotezu) { if (brj == 0) { ig[1].br100++; brj = 1; } }
                Chance.Image = Properties.Resources.chance16;
            }
        }

        public void IzvlacenjeCommunityChesta() 
        {
            int x = 0;
            if (communitychests[0] == "cc5")
            {
                if (igrac1naPotezu) { if (ig[0].getoutofjail) { PomeriNiz(communitychests); } }
                if (igrac2naPotezu) { if (ig[1].getoutofjail) { PomeriNiz(communitychests); } }
            }
            if (communitychests[0] == "cc1")
            {
                CommunityChest.Image = Properties.Resources.cc1;
                if (igrac1naPotezu) { ukupanbroj1 = 40; }
                if (igrac2naPotezu) { ukupanbroj2 = 40; }
            }
            else if (communitychests[0] == "cc2") 
            {
                CommunityChest.Image = Properties.Resources.cc2;
                if (igrac1naPotezu) { if (br == 0) { ig[0].br100 += 2; br = 1; } }
                if (igrac2naPotezu) { if (brj == 0) { ig[1].br100 += 2; brj = 1; } }
            }
            else if (communitychests[0] == "cc3")
            {
                CommunityChest.Image = Properties.Resources.cc3;
                if (igrac1naPotezu) { if (br == 0) { ig[0].dugBanci = 50; parkingNovac += 50; br = 1; } }
                if (igrac2naPotezu) { if (brj == 0) { ig[1].dugBanci = 50; parkingNovac += 50; brj = 1; } }
            }
            else if (communitychests[0] == "cc4")
            {
                CommunityChest.Image = Properties.Resources.cc4;
                if (igrac1naPotezu) { if (br == 0) { ig[0].br10 += 4; ig[0].br5++; br = 1; } }
                if (igrac2naPotezu) { if (brj == 0) { ig[1].br10 += 4; ig[1].br5++; brj = 1; } }
            }
            else if (communitychests[0] == "cc5")
            {
                CommunityChest.Image = Properties.Resources.cc5;
                if (igrac1naPotezu) { ig[0].getoutofjail = true; }
                if (igrac2naPotezu) { ig[1].getoutofjail = true; }
            }
            else if (communitychests[0] == "cc6")
            {
                CommunityChest.Image = Properties.Resources.cc6;
                if (igrac1naPotezu) { ig[0].gotojail = true; KrajPotezaIigraca(); }
                if (igrac2naPotezu) { ig[1].gotojail = true; KrajPotezaIIigraca(); }
            }
            else if (communitychests[0] == "cc7")
            {
                CommunityChest.Image = Properties.Resources.cc7;
                if (igrac1naPotezu) { if (br == 0) { ig[0].br50++; Placanje(0, 50); br = 1; } }
                if (igrac2naPotezu) { if (brj == 0) { ig[1].br50++; Placanje(0, 50); brj = 1; } }
            }
            else if (communitychests[0] == "cc8")
            {
                CommunityChest.Image = Properties.Resources.cc8;
                if (igrac1naPotezu) { if (br == 0) { ig[0].br100++; br = 1; } }
                if (igrac2naPotezu) { if (brj == 0) { ig[1].br100++; brj = 1; } }
            }
            else if (communitychests[0] == "cc9")
            {
                CommunityChest.Image = Properties.Resources.cc9;
                if (igrac1naPotezu) { if (br == 0) { ig[0].br20++; br = 1; } }
                if (igrac2naPotezu) { if (brj == 0) { ig[1].br20++; brj = 1; } }
            }
            else if (communitychests[0] == "cc10")
            {
                CommunityChest.Image = Properties.Resources.cc10;
                if (igrac1naPotezu) { if (br == 0) { ig[0].br10++; Placanje(0, 10); br = 1; } }
                if (igrac2naPotezu) { if (brj == 0) { ig[1].br10++; Placanje(0, 10); brj = 1; } }
            }
            else if (communitychests[0] == "cc11")
            {
                CommunityChest.Image = Properties.Resources.cc11;
                if (igrac1naPotezu) { if (br == 0) { ig[0].br100++; br = 1; } }
                if (igrac2naPotezu) { if (brj == 0) { ig[1].br100++; brj = 1; } }
            }
            else if (communitychests[0] == "cc12")
            {
                CommunityChest.Image = Properties.Resources.cc12;
                if (igrac1naPotezu) { if (br == 0) { ig[0].dugBanci = 100; parkingNovac += 100; br = 1; } }
                if (igrac2naPotezu) { if (brj == 0) { ig[1].dugBanci = 100; parkingNovac += 100; brj = 1; } }
            }
            else if (communitychests[0] == "cc13")
            {
                CommunityChest.Image = Properties.Resources.cc13;
                if (igrac1naPotezu) { if (br == 0) { ig[0].dugBanci = 50; parkingNovac += 50; br = 1; } }
                if (igrac2naPotezu) { if (brj == 0) { ig[1].dugBanci = 50; parkingNovac += 50; brj = 1; } }
            }
            else if (communitychests[0] == "cc14")
            {
                CommunityChest.Image = Properties.Resources.cc14;
                if (igrac1naPotezu) { if (br == 0) { ig[0].br20++; ig[0].br5++; br = 1; } }
                if (igrac2naPotezu) { if (brj == 0) { ig[1].br20++; ig[1].br5++; brj = 1; } }
            }
            else if (communitychests[0] == "cc15")
            {
                CommunityChest.Image = Properties.Resources.cc15;
                foreach (Ulice el in ul)
                {
                    if ((igrac1naPotezu && el.vlasnik == "player1") || (igrac2naPotezu && el.vlasnik == "player2"))
                    {
                        if (!el.hotel)
                        {
                            x += 40 * el.BrKuca;
                        }
                        else
                        {
                            x += 115;
                        }
                    }
                }
                if (igrac1naPotezu) { if (br == 0) { ig[0].dugBanci = x; parkingNovac += x; br = 1; } }
                if (igrac2naPotezu) { if (brj == 0) { ig[1].dugBanci = x; parkingNovac += x; brj = 1; } }
            }
            else if (communitychests[0] == "cc16")
            {
                CommunityChest.Image = Properties.Resources.cc16;
                if (igrac1naPotezu) { if (br == 0) { ig[0].br10++; br = 1; } }
                if (igrac2naPotezu) { if (brj == 0) { ig[1].br10++; brj = 1; } }
            }
            else if (communitychests[0] == "cc17")
            {
                CommunityChest.Image = Properties.Resources.cc17;
                if (igrac1naPotezu) { if (br == 0) { ig[0].br100++; br = 1; } }
                if (igrac2naPotezu) { if (brj == 0) { ig[1].br100++; brj = 1; } }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dvadesetIClick(object sender, EventArgs e)
        {
            if (ig[0].br20 > 0 && kockaBacena && kocka2Bacena)
            {
                if (ig[0].dugBanci != 0)
                {
                    if (ig[0].dugBanci >= 20)
                    {
                        sum += 20;
                        ig[0].dugBanci -= 20;
                        ig[0].br20--;
                    }
                    else
                    {
                        Kusur(ig[0].dugBanci, 20);
                        sum += ig[0].dugBanci;
                        ig[0].br20--;
                        ig[0].dugBanci = 0;
                    }
                }
                if (ig[0].dugIgracu != 0) 
                {
                    ig[1].br20++;
                    if (ig[0].dugIgracu >= 20)
                    {
                        ig[0].dugIgracu -= 20;
                        ig[0].br20--;
                    }
                    else 
                    {
                        Kusur(ig[0].dugIgracu, 20);
                        Placanje(ig[0].dugIgracu, 20);
                        ig[0].br20--;
                        ig[0].dugIgracu = 0;
                    }
                }
            }
        }

        private void pedesetIClick(object sender, EventArgs e)
        {
            if (ig[0].br50 > 0 )
            {
                if (ig[0].dugBanci != 0)
                {
                    if (ig[0].dugBanci >= 50)
                    {
                        sum += 50;
                        ig[0].dugBanci -= 50;
                        ig[0].br50--;
                    }
                    else
                    {
                        Kusur(ig[0].dugBanci, 50);
                        sum += ig[0].dugBanci;
                        ig[0].br50--;
                        ig[0].dugBanci = 0;
                    }
                }
                if (ig[0].dugIgracu != 0)
                {
                    ig[1].br50++;
                    if (ig[0].dugIgracu >= 50)
                    {
                        ig[0].dugIgracu -= 50;
                        ig[0].br50--;
                    }
                    else
                    {
                        Kusur(ig[0].dugIgracu, 50);
                        Placanje(ig[0].dugIgracu, 50);
                        ig[0].br50--;
                        ig[0].dugIgracu = 0;
                    }
                }
            }
        }

        private void desetIClick(object sender, EventArgs e)
        {
            if (ig[0].br10 > 0 && kockaBacena && kocka2Bacena)
            {
                if (ig[0].dugBanci != 0)
                {
                    if (ig[0].dugBanci >= 10)
                    {
                        sum += 10;
                        ig[0].dugBanci -= 10;
                        ig[0].br10--;
                    }
                    else
                    {
                        Kusur(ig[0].dugBanci, 10);
                        sum += ig[0].dugBanci;
                        ig[0].br10--;
                        ig[0].dugBanci = 0;
                    }
                }
                if (ig[0].dugIgracu != 0)
                {
                    ig[1].br10++;
                    if (ig[0].dugIgracu >= 10)
                    {
                        ig[0].dugIgracu -= 10;
                        ig[0].br10--;
                    }
                    else
                    {
                        Kusur(ig[0].dugIgracu, 10);
                        Placanje(ig[0].dugIgracu, 10);
                        ig[0].br10--;
                        ig[0].dugIgracu = 0;
                    }
                }
            }
        }

        private void petIClick(object sender, EventArgs e)
        {
            if (ig[0].br5 > 0 && kockaBacena && kocka2Bacena)
            {
                if (ig[0].dugBanci != 0)
                {
                    if (ig[0].dugBanci >= 5)
                    {
                        sum += 5;
                        ig[0].dugBanci -= 5;
                        ig[0].br5--;
                    }
                    else
                    {
                        Kusur(ig[0].dugBanci, 5);
                        sum += ig[0].dugBanci;
                        ig[0].br5--;
                        ig[0].dugBanci = 0;
                    }
                }
                if (ig[0].dugIgracu != 0)
                {
                    ig[1].br5++;
                    if (ig[0].dugIgracu >= 5)
                    {
                        ig[0].dugIgracu -= 5;
                        ig[0].br5--;
                    }
                    else
                    {
                        Kusur(ig[0].dugIgracu, 5);
                        Placanje(ig[0].dugIgracu, 5);
                        ig[0].br5--;
                        ig[0].dugIgracu = 0;
                    }
                }
            }
        }

        private void jedanIClick(object sender, EventArgs e)
        {
            if (ig[0].br1 > 0 && kockaBacena && kocka2Bacena)
            {
                if (ig[0].dugBanci != 0)
                {
                    sum += 1;
                    ig[0].dugBanci -= 1;
                    ig[0].br1--;
                }
                if (ig[0].dugIgracu != 0)
                {
                    ig[1].br1++;
                    ig[0].dugIgracu -= 1;
                    ig[0].br1--;
                }
            }
        }

        private void stoIClick(object sender, EventArgs e)
        {
            if (ig[0].br100 > 0 && kockaBacena && kocka2Bacena)
            {
                if (ig[0].dugBanci != 0)
                {
                    if (ig[0].dugBanci >= 100)
                    {
                        sum += 100;
                        ig[0].dugBanci -= 100;
                        ig[0].br100--;
                    }
                    else
                    {
                        Kusur(ig[0].dugBanci, 100);
                        sum += ig[0].dugBanci;
                        ig[0].br100--;
                        ig[0].dugBanci = 0;
                    }
                }
                if (ig[0].dugIgracu != 0)
                {
                    ig[1].br100++;
                    if (ig[0].dugIgracu >= 100)
                    {
                        ig[0].dugIgracu -= 100;
                        ig[0].br100--;
                    }
                    else
                    {
                        Kusur(ig[0].dugIgracu, 100);
                        Placanje(ig[0].dugIgracu, 100);
                        ig[0].br100--;
                        ig[0].dugIgracu = 0;
                    }
                }
            }
        }

        private void petstoIClick(object sender, EventArgs e)
        {
            if (ig[0].br500 > 0 && kockaBacena && kocka2Bacena)
            {
                if (ig[0].dugBanci != 0)
                {
                    if (ig[0].dugBanci >= 500)
                    {
                        sum += 500;
                        ig[0].dugBanci -= 500;
                        ig[0].br500--;
                    }
                    else
                    {
                        Kusur(ig[0].dugBanci, 500);
                        sum += ig[0].dugBanci;
                        ig[0].br500--;
                        ig[0].dugBanci = 0;
                    }
                }
                if (ig[0].dugIgracu != 0)
                {
                    ig[1].br500++;
                    if (ig[0].dugIgracu >= 500)
                    {
                        ig[0].dugIgracu -= 500;
                        ig[0].br500--;
                    }
                    else
                    {
                        Kusur(ig[0].dugIgracu, 500);
                        Placanje(ig[0].dugIgracu, 500);
                        ig[0].br500--;
                        ig[0].dugIgracu = 0;
                    }
                }
            }
        }

        private void pedesetIIClick(object sender, EventArgs e)
        {
            if (ig[1].br50 > 0 && kockaBacena && kocka2Bacena)
            {
                if (ig[1].dugBanci != 0)
                {
                    if (ig[1].dugBanci >= 50)
                    {
                        sum += 50;
                        ig[1].dugBanci -= 50;
                        ig[1].br50--;
                    }
                    else
                    {
                        Kusur(ig[1].dugBanci, 50);
                        sum += ig[1].dugBanci;
                        ig[1].br50--;
                        ig[1].dugBanci = 0;
                    }
                }
                if (ig[1].dugIgracu != 0)
                {
                    ig[0].br50++;
                    if (ig[1].dugIgracu >= 50)
                    {
                        ig[1].dugIgracu -= 50;
                        ig[1].br50--;
                    }
                    else
                    {
                        Kusur(ig[1].dugIgracu, 50);
                        Placanje(ig[1].dugIgracu, 50);
                        ig[1].br50--;
                        ig[1].dugIgracu = 0;
                    }
                }
            }
        }

        private void dvadesetIIClick(object sender, EventArgs e)
        {
            if (ig[1].br20 > 0 && kockaBacena && kocka2Bacena)
            {
                if (ig[1].dugBanci != 0)
                {
                    if (ig[1].dugBanci >= 20)
                    {
                        sum += 20;
                        ig[1].dugBanci -= 20;
                        ig[1].br20--;
                    }
                    else
                    {
                        Kusur(ig[1].dugBanci, 20);
                        sum += ig[1].dugBanci;
                        ig[1].br20--;
                        ig[1].dugBanci = 0;
                    }
                }
                if (ig[1].dugIgracu != 0)
                {
                    ig[0].br20++;
                    if (ig[1].dugIgracu >= 20)
                    {
                        ig[1].dugIgracu -= 20;
                        ig[1].br20--;
                    }
                    else
                    {
                        Kusur(ig[1].dugIgracu, 20);
                        Placanje(ig[1].dugIgracu, 20);
                        ig[1].br20--;
                        ig[1].dugIgracu = 0;
                    }
                }
            }
        }

        private void desetIIClick(object sender, EventArgs e)
        {
            if (ig[1].br10 > 0 && kockaBacena && kocka2Bacena)
            {
                if (ig[1].dugBanci != 0)
                {
                    if (ig[1].dugBanci >= 10)
                    {
                        sum += 10;
                        ig[1].dugBanci -= 10;
                        ig[1].br10--;
                    }
                    else
                    {
                        Kusur(ig[1].dugBanci, 10);
                        sum += ig[1].dugBanci;
                        ig[1].br10--;
                        ig[1].dugBanci = 0;
                    }
                }
                if (ig[1].dugIgracu != 0)
                {
                    ig[0].br10++;
                    if (ig[1].dugIgracu >= 10)
                    {
                        ig[1].dugIgracu -= 10;
                        ig[1].br10--;
                    }
                    else
                    {
                        Kusur(ig[1].dugIgracu, 10);
                        Placanje(ig[1].dugIgracu, 10);
                        ig[1].br10--;
                        ig[1].dugIgracu = 0;
                    }
                }
            }
        }

        private void petIIClick(object sender, EventArgs e)
        {
            if (ig[1].br5 > 0 && kockaBacena && kocka2Bacena)
            {
                if (ig[1].dugBanci != 0)
                {
                    if (ig[1].dugBanci >= 5)
                    {
                        sum += 5;
                        ig[1].dugBanci -= 5;
                        ig[1].br5--;
                    }
                    else
                    {
                        Kusur(ig[1].dugBanci, 5);
                        sum += ig[1].dugBanci;
                        ig[1].br5--;
                        ig[1].dugBanci = 0;
                    }
                }
                if (ig[1].dugIgracu != 0)
                {
                    ig[0].br5++;
                    if (ig[1].dugIgracu >= 5)
                    {
                        ig[1].dugIgracu -= 5;
                        ig[1].br5--;
                    }
                    else
                    {
                        Kusur(ig[1].dugIgracu, 5);
                        Placanje(ig[1].dugIgracu, 5);
                        ig[1].br5--;
                        ig[1].dugIgracu = 0;
                    }
                }
            }
        }

        private void jedanIIClick(object sender, EventArgs e)
        {
            if (ig[1].br1 > 0 && kockaBacena && kocka2Bacena)
            {
                if (ig[1].dugBanci != 0)
                {
                    sum += 1;
                    ig[1].dugBanci -= 1;
                    ig[1].br1--;
                }
                if (ig[1].dugIgracu != 0)
                {
                    ig[0].br1++;
                    ig[1].dugIgracu -= 1;
                    ig[1].br1--;
                }
            }
        }

        private void stoIIClick(object sender, EventArgs e)
        {
            if (ig[1].br100 > 0 && kockaBacena && kocka2Bacena)
            {
                if (ig[1].dugBanci != 0)
                {
                    if (ig[1].dugBanci >= 100)
                    {
                        sum += 100;
                        ig[1].dugBanci -= 100;
                        ig[1].br100--;
                    }
                    else
                    {
                        Kusur(ig[1].dugBanci, 100);
                        sum += ig[1].dugBanci;
                        ig[1].br100--;
                        ig[1].dugBanci = 0;
                    }
                }
                if (ig[1].dugIgracu != 0)
                {
                    ig[0].br100++;
                    if (ig[1].dugIgracu >= 100)
                    {
                        ig[1].dugIgracu -= 100;
                        ig[1].br100--;
                    }
                    else
                    {
                        Kusur(ig[1].dugIgracu, 100);
                        Placanje(ig[1].dugIgracu, 100);
                        ig[1].br100--;
                        ig[1].dugIgracu = 0;
                    }
                }
            }
        }

        private void petstoIIClick(object sender, EventArgs e)
        {
            if (ig[1].br500 > 0 && kockaBacena && kocka2Bacena)
            {
                if (ig[1].dugBanci != 0)
                {
                    if (ig[1].dugBanci >= 500)
                    {
                        sum += 500;
                        ig[1].dugBanci -= 500;
                        ig[1].br500--;
                    }
                    else
                    {
                        Kusur(ig[1].dugBanci, 500);
                        sum += ig[1].dugBanci;
                        ig[1].br500--;
                        ig[1].dugBanci = 0;
                    }
                }
                if (ig[1].dugIgracu != 0)
                {
                    ig[0].br500++;
                    if (ig[1].dugIgracu >= 500)
                    {
                        ig[1].dugIgracu -= 500;
                        ig[1].br500--;
                    }
                    else
                    {
                        Kusur(ig[1].dugIgracu, 500);
                        Placanje(ig[1].dugIgracu, 500);
                        ig[1].br500--;
                        ig[1].dugIgracu = 0;
                    }
                }
            }
        }

        

        int prom = 0;
        int prom1 = 0;

        private void ShowProperties1(object sender, EventArgs e)
        {
            if (prom % 2 == 0 && p > 0)
            {
                pokaziImanjaprvog = true;
                pokaziImanjadrugog = false;
                button2.Text = "Skloni";
                button3.Text = "Imanja";
            }
            else 
            {
                pokaziImanjaprvog = false;
                button2.Text = "Imanja";
            }
            prom++;
        }

        private void ShowProperties2(object sender, EventArgs e)
        {
            if (prom1 % 2 == 0 && q > 0)
            {
                pokaziImanjadrugog = true;
                pokaziImanjaprvog = false;
                button3.Text = "Skloni";
                button2.Text = "Imanja";
            }
            else 
            {
                pokaziImanjadrugog = false;
                button3.Text = "Imanja";
            }
            prom1++;
        }

        private void UnClicking(Ulice x) 
        {
            foreach (Ulice el in ul)
            {
                if (el != x)
                {
                    el.propertyclicked = false;
                }
            }
            foreach (Poljanaprodaju el in pnp) 
            {
                el.propertyclicked = false;
            }
        }

        private void UnClickingPNP(Poljanaprodaju x) 
        {
            foreach (Poljanaprodaju el in pnp) 
            {
                if (el != x) el.propertyclicked = false;
            }
            foreach (Ulice el in ul) 
            {
                el.propertyclicked = false;
            }
        }

        private void Property1Click(object sender, EventArgs e)
        {
            if (pictureBox16.Visible) 
            {
                ul[0].propertyclicked = true;
                UnClicking(ul[0]);
            }
        }

        private void Property2Click(object sender, EventArgs e)
        {
            if (pictureBox17.Visible)
            {
                ul[1].propertyclicked = true;
                UnClicking(ul[1]);
            }
        }

        private void Property3Click(object sender, EventArgs e)
        {
            if (pictureBox18.Visible)
            {
                ul[2].propertyclicked = true;
                UnClicking(ul[2]);
            }
        }

        private void Property4Click(object sender, EventArgs e)
        {
            if (pictureBox19.Visible)
            {
                ul[3].propertyclicked = true;
                UnClicking(ul[3]);
            }
        }

        private void Property5Click(object sender, EventArgs e)
        {
            if (pictureBox20.Visible)
            {
                ul[4].propertyclicked = true;
                UnClicking(ul[4]);
            }
        }

        private void Property6Click(object sender, EventArgs e)
        {
            if (pictureBox21.Visible)
            {
                ul[5].propertyclicked = true;
                UnClicking(ul[5]);
            }
        }

        private void Property7Click(object sender, EventArgs e)
        {
            if (pictureBox22.Visible)
            {
                ul[6].propertyclicked = true;
                UnClicking(ul[6]);
            }
        }

        private void Property8Click(object sender, EventArgs e)
        {
            if (pictureBox23.Visible)
            {
                ul[7].propertyclicked = true;
                UnClicking(ul[7]);
            }
        }

        private void Property9Click(object sender, EventArgs e)
        {
            if (pictureBox24.Visible)
            {
                ul[8].propertyclicked = true;
                UnClicking(ul[8]);
            }
        }

        private void Property10Click(object sender, EventArgs e)
        {
            if (pictureBox25.Visible)
            {
                ul[9].propertyclicked = true;
                UnClicking(ul[9]);
            }
        }

        private void Property11Click(object sender, EventArgs e)
        {
            if (pictureBox26.Visible)
            {
                ul[10].propertyclicked = true;
                UnClicking(ul[10]);
            }
        }

        private void Property12Click(object sender, EventArgs e)
        {
            if (pictureBox27.Visible)
            {
                ul[11].propertyclicked = true;
                UnClicking(ul[11]);
            }
        }

        private void Property13Click(object sender, EventArgs e)
        {
            if (pictureBox28.Visible)
            {
                ul[12].propertyclicked = true;
                UnClicking(ul[12]);
            }
        }

        private void Property14Click(object sender, EventArgs e)
        {
            if (pictureBox29.Visible)
            {
                ul[13].propertyclicked = true;
                UnClicking(ul[13]);
            }
        }

        private void Property15Click(object sender, EventArgs e)
        {
            if (pictureBox30.Visible)
            {
                ul[14].propertyclicked = true;
                UnClicking(ul[14]);
            }
        }

        private void Property16Click(object sender, EventArgs e)
        {
            if (pictureBox31.Visible)
            {
                ul[15].propertyclicked = true;
                UnClicking(ul[15]);
            }
        }

        private void Property17Click(object sender, EventArgs e)
        {
            if (pictureBox32.Visible)
            {
                ul[16].propertyclicked = true;
                UnClicking(ul[16]);
            }
        }

        private void Property18Click(object sender, EventArgs e)
        {
            if (pictureBox33.Visible)
            {
                ul[17].propertyclicked = true;
                UnClicking(ul[17]);
            }
        }

        private void Property19Click(object sender, EventArgs e)
        {
            if (pictureBox34.Visible)
            {
                ul[18].propertyclicked = true;
                UnClicking(ul[18]);
            }
        }

        private void Property20Click(object sender, EventArgs e)
        {
            if (pictureBox35.Visible)
            {
                ul[19].propertyclicked = true;
                UnClicking(ul[19]);
            }
        }

        private void Property21Click(object sender, EventArgs e)
        {
            if (pictureBox36.Visible)
            {
                ul[20].propertyclicked = true;
                UnClicking(ul[20]);
            }
        }

        private void Property22Click(object sender, EventArgs e)
        {
            if (pictureBox37.Visible)
            {
                ul[21].propertyclicked = true;
                UnClicking(ul[21]);
            }
        }

        private void ReadingRailroadClick(object sender, EventArgs e)
        {
            if (pictureBox38.Visible)
            {
                pnp[0].propertyclicked = true;
                UnClickingPNP(pnp[0]);
            }
        }

        private void PennsylvaniaRailroadClick(object sender, EventArgs e)
        {
            if (pictureBox39.Visible) 
            {
                pnp[2].propertyclicked = true;
                UnClickingPNP(pnp[2]);
            }
        }

        private void BORailroadClick(object sender, EventArgs e)
        {
            if (pictureBox40.Visible)
            {
                pnp[3].propertyclicked = true;
                UnClickingPNP(pnp[3]);
            }
        }

        private void ShortLineClick(object sender, EventArgs e)
        {
            if (pictureBox41.Visible)
            {
                pnp[5].propertyclicked = true;
                UnClickingPNP(pnp[5]);
            }
        }

        private void ElCompanyClick(object sender, EventArgs e)
        {
            if (pictureBox42.Visible)
            {
                pnp[1].propertyclicked = true;
                UnClickingPNP(pnp[1]);
            }
        }

        private void WaterWorks(object sender, EventArgs e)
        {
            if (pictureBox43.Visible)
            {
                pnp[4].propertyclicked = true;
                UnClickingPNP(pnp[4]);
            }
        }

        bool tryDoubles;
        bool pay50;

        private void TryDoubles(object sender, EventArgs e)
        {
            if (ig[0].gotojail || ig[1].gotojail) 
            {
                if (f < 3)
                {
                    tryDoubles = true;
                    zat = 1;
                }
            }
        }

        private void Pay50(object sender, EventArgs e)
        {
            if ((ig[0].gotojail && igrac1naPotezu) || (ig[1].gotojail && igrac2naPotezu)) 
            {
                pay50 = true;
                zat = 1;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Visible) 
            {
                foreach (Ulice el in ul) 
                {
                    if (el.propertyclicked) 
                    {
                        Upgrading(el);
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int i;
            if (button7.Visible)
            {
                foreach (Ulice el in ul)
                {
                    if (el.propertyclicked)
                    {
                        Downgrade(el);
                        if (el.vlasnik == "player1")
                        {
                            i = 0;
                        }
                        else i = 1;
                        if (el.boja == "braon" || el.boja == "svplava")
                        {
                            ig[i].br20++;
                            ig[i].br5++;
                        }
                        if (el.boja == "roze" || el.boja == "narandzasta") 
                        {
                            ig[i].br50++;
                        }
                        if (el.boja == "crvena" || el.boja == "zuta")
                        {
                            ig[i].br50++;
                            ig[i].br20++;
                            ig[i].br5++;
                        }
                        if (el.boja == "zelena" || el.boja == "plava")
                        {
                            ig[i].br100++;
                        }
                    }
                }
            }
        }

        bool selling;
        bool mortgaging;

        private bool IsNumber(string unos)
        {
            int broj = 0;
            return int.TryParse(unos, out broj);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.Visible && ig[0].dugBanci == 0 && ig[1].dugBanci == 0)
            {
                int tbtext;
                selling = true;
                Igrac Igrackojikupuje;
                if (IsNumber(textBox1.Text))
                {
                    tbtext = Int16.Parse(textBox1.Text);
                    foreach (Ulice el in ul)
                    {
                        if (el.vlasnik == "player1") { Igrackojikupuje = ig[1]; }
                        else { Igrackojikupuje = ig[0]; }
                        if (el.propertyclicked && tbtext < Igrackojikupuje.Ukupanbudzet)
                        {
                            Placanje(0, tbtext);
                            Kusur(0, tbtext); 
                            selling = false;
                            if (el.vlasnik == "player1") { p--; q++; el.vlasnik = "player2"; }
                            else { q--; p++; el.vlasnik = "player1"; }
                            el.propertyclicked = false;
                            pcl = 0;
                        }
                    }
                    foreach (Poljanaprodaju el in pnp)
                    {
                        if (el.vlasnik == "player1") { Igrackojikupuje = ig[1]; }
                        else { Igrackojikupuje = ig[0]; }
                        if (el.propertyclicked && tbtext < Igrackojikupuje.Ukupanbudzet)
                        {
                            Placanje(0, tbtext);
                            Kusur(0, tbtext);
                            selling = false;
                            if (el.vlasnik == "player1") { p--; q++; el.vlasnik = "player2"; }
                            else { q--; p++; el.vlasnik = "player1"; }
                            el.propertyclicked = false;
                            pcl = 0;
                        }
                    }
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Visible) 
            {
                textBox1.Visible = true;
                button10.Visible = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Visible)
            {
                foreach (Ulice el in ul)
                {
                    el.propertyclicked = false;
                    pcl = 0;
                }
                foreach (Poljanaprodaju el in pnp)
                {
                    el.propertyclicked = false;
                    pcl = 0;
                }
            }
        }

        private void Mortgage() 
        {
            int i = 0, j = 0;
            foreach (Ulice el in ul) 
            {
                if (el.propertyclicked) 
                {
                    foreach (Ulice elm in ul) 
                    {
                        if (elm.boja == el.boja) 
                        {
                            i++;
                        }
                    }
                    foreach (Ulice elm in ul) 
                    {
                        if (elm.boja == el.boja && elm.BrKuca == 0) 
                        {
                            j++;
                        }
                    }
                    if (i == j)
                    {
                        el.hipoteka = true;
                        Kusur(0, el.MortgageValue);
                    }
                }
            }
            foreach (Poljanaprodaju el in pnp)
            {
                if (el.propertyclicked)
                {
                    el.hipoteka = true;
                    Kusur(0, el.MortgageValue);
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button11.Visible && ig[0].dugBanci == 0 && ig[1].dugBanci == 0)
            {
                foreach (Ulice el in ul)
                {
                    if (el.propertyclicked)
                    {
                        if (!el.hipoteka)
                        {
                            mortgaging = true;
                            Mortgage();
                            mortgaging = false;
                        }
                        else
                        {
                            el.hipoteka = false;
                            if (el.vlasnik == "player1") ig[0].dugBanci += el.MortgageValue + el.MortgageValue / 10;
                            else ig[1].dugBanci += el.MortgageValue + el.MortgageValue / 10;
                        }
                    }
                }
                foreach (Poljanaprodaju el in pnp)
                {
                    if (el.propertyclicked)
                    {
                        if (!el.hipoteka)
                        {
                            mortgaging = true;
                            Mortgage();
                            mortgaging = false;
                        }
                        else
                        {
                            el.hipoteka = false;
                            if (el.vlasnik == "player1") ig[0].dugBanci += el.MortgageValue + el.MortgageValue / 10;
                            else ig[1].dugBanci += el.MortgageValue + el.MortgageValue / 10;
                        }
                    }
                }
                foreach (Ulice el in ul)
                {
                    el.propertyclicked = false;
                    pcl = 0;
                }
                foreach (Poljanaprodaju el in pnp)
                {
                    el.propertyclicked = false;
                    pcl = 0;
                }
            }
        }

        private void TurnCards() 
        {
            if (ul[0].hipoteka) pictureBox16.Image = Properties.Resources.Hipoteka;
            else pictureBox16.Image = Properties.Resources.Untitled11;
            if (ul[1].hipoteka) pictureBox17.Image = Properties.Resources.Hipoteka;
            else pictureBox17.Image = Properties.Resources.Untitled2;
            if (ul[2].hipoteka) pictureBox18.Image = Properties.Resources.Hipoteka;
            else pictureBox18.Image = Properties.Resources.Untitled3;
            if (ul[3].hipoteka) pictureBox19.Image = Properties.Resources.Hipoteka;
            else pictureBox19.Image = Properties.Resources.Untitled4;
            if (ul[4].hipoteka) pictureBox20.Image = Properties.Resources.Hipoteka;
            else pictureBox20.Image = Properties.Resources.Untitled5;
            if (ul[5].hipoteka) pictureBox21.Image = Properties.Resources.Hipoteka;
            else pictureBox21.Image = Properties.Resources.Untitled6;
            if (ul[6].hipoteka) pictureBox22.Image = Properties.Resources.Hipoteka;
            else pictureBox22.Image = Properties.Resources.Untitled7;
            if (ul[7].hipoteka) pictureBox23.Image = Properties.Resources.Hipoteka;
            else pictureBox23.Image = Properties.Resources.Untitled8;
            if (ul[8].hipoteka) pictureBox24.Image = Properties.Resources.Hipoteka;
            else pictureBox24.Image = Properties.Resources.Untitled9;
            if (ul[9].hipoteka) pictureBox25.Image = Properties.Resources.Hipoteka;
            else pictureBox25.Image = Properties.Resources.Untitled10;
            if (ul[10].hipoteka) pictureBox26.Image = Properties.Resources.Hipoteka;
            else pictureBox26.Image = Properties.Resources.Untitled111;
            if (ul[11].hipoteka) pictureBox27.Image = Properties.Resources.Hipoteka;
            else pictureBox27.Image = Properties.Resources.Untitled12;
            if (ul[12].hipoteka) pictureBox28.Image = Properties.Resources.Hipoteka;
            else pictureBox28.Image = Properties.Resources.Untitled13;
            if (ul[13].hipoteka) pictureBox29.Image = Properties.Resources.Hipoteka;
            else pictureBox29.Image = Properties.Resources.Untitled14;
            if (ul[14].hipoteka) pictureBox30.Image = Properties.Resources.Hipoteka;
            else pictureBox30.Image = Properties.Resources.Untitled15;
            if (ul[15].hipoteka) pictureBox31.Image = Properties.Resources.Hipoteka;
            else pictureBox31.Image = Properties.Resources.Untitled16;
            if (ul[16].hipoteka) pictureBox32.Image = Properties.Resources.Hipoteka;
            else pictureBox32.Image = Properties.Resources.Untitled17;
            if (ul[17].hipoteka) pictureBox33.Image = Properties.Resources.Hipoteka;
            else pictureBox33.Image = Properties.Resources.Untitled18;
            if (ul[18].hipoteka) pictureBox34.Image = Properties.Resources.Hipoteka;
            else pictureBox34.Image = Properties.Resources.Untitled19;
            if (ul[19].hipoteka) pictureBox35.Image = Properties.Resources.Hipoteka;
            else pictureBox35.Image = Properties.Resources.Untitled20;
            if (ul[20].hipoteka) pictureBox36.Image = Properties.Resources.Hipoteka;
            else pictureBox36.Image = Properties.Resources.Untitled211;
            if (ul[21].hipoteka) pictureBox37.Image = Properties.Resources.Hipoteka;
            else pictureBox37.Image = Properties.Resources.Untitled22;
            if (pnp[0].hipoteka) pictureBox38.Image = Properties.Resources.Hipoteka;
            else pictureBox38.Image = Properties.Resources.railroad1;
            if (pnp[2].hipoteka) pictureBox39.Image = Properties.Resources.Hipoteka;
            else pictureBox39.Image = Properties.Resources.railroad2;
            if (pnp[3].hipoteka) pictureBox40.Image = Properties.Resources.Hipoteka;
            else pictureBox40.Image = Properties.Resources.railroad3;
            if (pnp[5].hipoteka) pictureBox41.Image = Properties.Resources.Hipoteka;
            else pictureBox41.Image = Properties.Resources.railroad4;
            if (pnp[1].hipoteka) pictureBox42.Image = Properties.Resources.Hipoteka;
            else pictureBox42.Image = Properties.Resources._41r75OSTsQL__AC_SY355_;
            if (pnp[4].hipoteka) pictureBox43.Image = Properties.Resources.Hipoteka;
            else pictureBox43.Image = Properties.Resources._61hl40f2U9L__SL1334_;
        }

        private void xButton_Click(object sender, EventArgs e)
        {
            Help.Visible = false;
            xButton.Visible = false;
        }

        
        


        

        

       

       




        

        

       

        

        

        

        



        

        

        

        

        

        

        

        
        

        

        

        

      
        

        

        

    }
}
