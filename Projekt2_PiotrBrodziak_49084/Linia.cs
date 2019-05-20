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
    class Linia : Punkt
    {

        protected int pbXk, pbYk;
        public Linia()
        {
        }
        public Linia(int pbXp, int pbYp, int pbXk, int pbYk)
         : base(pbXp, pbYp)
        {
            this.pbXk = pbXk;
            this.pbYk = pbYk;
        }
        public Linia(int pbXp, int pbYp, int pbXk, int pbYk, Color pbKolor, DashStyle pbStylLinii, int pbGruboscLinii)
            : base(pbXp, pbYp, pbKolor, pbStylLinii, pbGruboscLinii)
        {
            this.pbXk = pbXk;
            this.pbYk = pbYk;
        }
        //Napisanie metod wirtualnych
        override public void pbWykresl(Graphics pbPowierzchniaGraficzna)
        {
            Pen pbPioro = new Pen(pbKolor, pbGruboscLini);
            pbPioro.DashStyle = pbStylLinii;
            pbPowierzchniaGraficzna.DrawLine(pbPioro, pbX, pbY, pbXk, pbYk);
            pbWidoczny = true;
            pbPioro.Dispose();
        }

        public virtual void pbWymaz(Control Kontrolka, Graphics pbPowierzchniaGraficzna)
        {
            if (pbWidoczny)
            {
                Pen pbPioro = new Pen(Kontrolka.BackColor, pbGruboscLini);
                pbPioro.DashStyle = pbStylLinii;
                pbPowierzchniaGraficzna.DrawLine(pbPioro, pbX, pbY, pbXk, pbYk);
                pbWidoczny = false;
                pbPioro.Dispose();
            }
        }
    }
}
