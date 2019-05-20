using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt2_PiotrBrodziak_49084
{
    class Kwadrat : Prostokat
    {
        public Kwadrat(int pbXp, int pbYp, int pbSzerokosc)
        : base(pbXp, pbYp, pbSzerokosc, pbSzerokosc)
        {
        }

        public Kwadrat(int pbXp, int pbYp, int pbSzerokosc, Color pbKolor, DashStyle pbStylLinii, int pbGruboscLinii)
           : base(pbXp, pbYp, pbSzerokosc, pbSzerokosc, pbKolor, pbStylLinii, pbGruboscLinii)
        {
        }
    }
}
