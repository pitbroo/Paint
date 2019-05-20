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
    class Okrag : Elipsa
    {
        int pbPromien;

        public Okrag(int pbXp, int pbYp, int pbPromien)
           : base(pbXp, pbYp, pbPromien, pbPromien)
        {
        }

        public Okrag(int pbXp, int pbYp, int pbPromien, Color pbKolor, DashStyle pbStylLinii, int pbGruboscLinii)
            : base(pbXp, pbYp, pbPromien, pbPromien, pbKolor, pbStylLinii, pbGruboscLinii)
        {
        }

        override public void pbWykresl(Graphics pbPowierzchniaGraficzna)
        {
            Pen pbPioro = new Pen(pbKolor, pbGruboscLini);
            pbPioro.DashStyle = pbStylLinii;
            pbPowierzchniaGraficzna.DrawEllipse(pbPioro, new Rectangle(pbX - pbOsDluga/ 2, pbY - pbOsKrotka/ 2, pbOsKrotka, pbOsKrotka));
            pbWidoczny = true;
            pbPioro.Dispose();
        }

        public virtual void Wymaż(Control pbKontrolka, Graphics pbPowierzchniaGraficzna)
        {
            if (pbWidoczny)
            {
                Pen pbPioro = new Pen(pbKontrolka.BackColor, pbGruboscLini);
                pbPioro.DashStyle = pbStylLinii;
                pbPowierzchniaGraficzna.DrawEllipse(pbPioro, new Rectangle(pbX - pbOsDluga / 2, pbY - pbOsKrotka / 2, pbOsKrotka, pbOsKrotka));
                pbWidoczny = false;
                pbPioro.Dispose();
            }
        }
    }
}
