using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace Projekt2_PiotrBrodziak_49084
{
    class Punkt
    {
        const int pbPromienPunktu = 5;
        int pbrozumiarPunktu;

        protected int pbX;
        protected int pbY;
        protected Color pbKolor;
        protected bool pbWidoczny;
        protected DashStyle pbStylLinii;
        protected int pbGruboscLini;
        //deklaracja konstruktów klasy punkt
        public Punkt()
        {
            pbX = 0; pbY = 0;
            pbrozumiarPunktu = 2 * pbPromienPunktu;
            pbKolor = Color.Black;
            pbStylLinii = DashStyle.Solid;
            pbGruboscLini = 1;
            pbWidoczny = false;
        }
        public Punkt(int X, int Y)
        {
            pbX = X;
            pbY = Y;
            pbrozumiarPunktu = 2 * pbPromienPunktu;
            pbKolor = Color.Black;
            pbStylLinii = DashStyle.Solid;
            pbGruboscLini = 1;
            pbWidoczny = false;
        }
        public Punkt(int X, int Y, Color kolor)
        {
            pbX = X;
            pbY = Y;
            pbrozumiarPunktu = 2 * pbPromienPunktu;
            pbKolor = kolor;
            pbStylLinii = DashStyle.Solid;
            pbGruboscLini = 1;
            pbWidoczny = false;
        }
        public Punkt(int X, int Y, Color kolor, DashStyle StylLinii, int GrubośćLinii)
        {
            pbX = X;
            pbY = Y;
            pbrozumiarPunktu = 2 * pbPromienPunktu;
            pbKolor = kolor;
            pbStylLinii = StylLinii;
            pbGruboscLini = GrubośćLinii;
            pbWidoczny = false; ;
        }
        //deklaracja metod klasy punkt
        //"setery"
        private void pbUstawXY(int pbX, int pbY)
        {
            this.pbX = pbX;
            this.pbY = pbY;
        }

        private void UstawXY(Point pbNowaLokalizacja)
        {
            pbX = pbNowaLokalizacja.X;
            pbY = pbNowaLokalizacja.Y;
        }
        //pozostałe motody klasy Punkt
        public void PrzesunDoNowegoXY(Control pbKontrolka, Graphics pbPowierzchniaGraficzna, int pbX, int pbY)
        {

        }
        public void pbFormatujFG(Color pbKolor, DashStyle pbStylLini, int pbGruboscLini)
        {
            this.pbKolor = pbKolor;
            this.pbStylLinii = pbStylLini;
            this.pbGruboscLini = pbGruboscLini;
        }
        public virtual void pbWykresl(Graphics pbPowierzchniaGraficzna)
        {
            SolidBrush pbPedzel = new SolidBrush(pbKolor);
            pbPowierzchniaGraficzna.FillEllipse(pbPedzel, pbX-pbrozumiarPunktu / 2,
                pbY - pbrozumiarPunktu/2, pbrozumiarPunktu, pbrozumiarPunktu);
            pbWidoczny = true;
            pbPedzel.Dispose();
        }
        public virtual void pbWymaz(Control pbKontrolka, Graphics pbPowierzchniaGraficzna)
        {
            if (pbWidoczny)
            {
                SolidBrush pbPedzel = new SolidBrush(pbKontrolka.BackColor);
                pbPowierzchniaGraficzna.FillEllipse(pbPedzel, pbX - pbrozumiarPunktu / 2,
                    pbY - pbrozumiarPunktu / 2, pbrozumiarPunktu, pbrozumiarPunktu);
                pbWidoczny = false;
                pbPedzel.Dispose();
            }
        }

    }



     
}
