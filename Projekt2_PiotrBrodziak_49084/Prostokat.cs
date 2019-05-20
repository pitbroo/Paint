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
    class Prostokat : Linia
    {
        public Prostokat(int pbXp, int pbYp, int pbXk, int pbYk)
          : base(pbXp, pbYp, pbXk, pbYk)
        {
        }

        public Prostokat(int pbXp, int pbYp, int pbXk, int pbYk, Color pbKolor, DashStyle pbStylLinii, int pbGruboscLinii)
            : base(pbXp, pbYp, pbXk, pbYk, pbKolor, pbStylLinii, pbGruboscLinii)
        {
        }

        // napisanie metod wirtualnych
        override public void pbWykresl(Graphics pbPowierzchniaGraficzna)
        {
            Pen pbPioro = new Pen(pbKolor, pbGruboscLini);
            pbPioro.DashStyle = pbStylLinii;
            pbPowierzchniaGraficzna.DrawRectangle(pbPioro, pbX, pbY, pbXk, pbYk);
            pbWidoczny = true;
            pbPioro.Dispose();
        }

        public virtual void Wymaż(Control pbKontrolka, Graphics pbPowierzchniaGraficzna)
        {
            if (pbWidoczny)
            {
                Pen pbPioro = new Pen(pbKontrolka.BackColor, pbGruboscLini);
                pbPioro.DashStyle = pbStylLinii;
                pbPowierzchniaGraficzna.DrawRectangle(pbPioro, pbX, pbY, pbXk, pbYk);
                pbWidoczny = false;
                pbPioro.Dispose();
            }
        }
    }
}
