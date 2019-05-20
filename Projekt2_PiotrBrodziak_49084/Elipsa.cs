using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt2_PiotrBrodziak_49084
{
    class Elipsa : Punkt
    {
        protected int pbOsDluga, pbOsKrotka;
        public Elipsa()
        {
          
        }
        public Elipsa(int pbXp, int pbYp, int pbOsDluga, int pbOsKrotka):base(pbXp, pbYp)
        {
            this.pbOsKrotka = pbOsKrotka;
            this.pbOsDluga = pbOsDluga;
        }
        public Elipsa(int pbXp, int pbYp, int pbOsDluga, int pbOsKrotka, Color pbKolor, DashStyle pbStylLini, int pbGruboscLini)
            :base(pbXp, pbYp, pbKolor, pbStylLini, pbGruboscLini)
        {
            this.pbOsKrotka = pbOsKrotka;
            this.pbOsDluga = pbOsDluga;
        }
        //napisanie metod wirtualnych
        override public void pbWykresl(Graphics pbPowierzchniaGraficzna)
        {
                Pen pbPioro = new Pen(pbKolor, pbGruboscLini);
                pbPioro.DashStyle = pbStylLinii;
                pbPowierzchniaGraficzna.DrawEllipse(pbPioro, new Rectangle(pbX - pbOsDluga / 2, pbY - pbOsKrotka / 2, pbOsDluga, pbOsKrotka));
                pbWidoczny = true;
                pbPioro.Dispose();
        }
    
        override public void pbWymaz(Control pbKontrolka, Graphics pbPowierzchniaGraficzna)
        {
            if (pbWidoczny)
            {
                Pen pbPioro = new Pen(pbKontrolka.BackColor, pbGruboscLini);
                pbPioro.DashStyle = pbStylLinii;
                pbPowierzchniaGraficzna.DrawEllipse(pbPioro, new Rectangle(pbX - pbOsDluga / 2, pbY - pbOsKrotka / 2, pbOsDluga, pbOsKrotka));
                pbWidoczny = false;
                pbPioro.Dispose();
            }
        }
    }
}
