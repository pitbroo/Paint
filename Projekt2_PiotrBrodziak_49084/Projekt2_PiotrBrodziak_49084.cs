using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace Projekt2_PiotrBrodziak_49084
{
    public partial class Projekt2_PiotrBrodziak_49084 : Form
    {
        Graphics pbRysownica;
        Graphics pbRysownicaTymczasowa;
        Punkt[] pbTabFiguryGeom;
        int pbIndexFigur;
        static Projekt2_PiotrBrodziak_49084 pbUchwytFormularza;
        int pbMarginesFormularza = 10;
        int pbMarginesPanel = 0;
        Point pbPunkt;
        PictureBox pbPictureBox = new PictureBox();
        Pen pbPioro = new Pen(Color.Black);
        Pen pbPioroTymczasowe = new Pen(Color.Blue, 3);
        Image pbPlik;
        public Projekt2_PiotrBrodziak_49084()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.DimGray;
            this.Left = pbMarginesFormularza;
            this.Top = pbMarginesFormularza;
            this.Width = (int)(Screen.PrimaryScreen.Bounds.Width * 0.80F);
            this.Height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.80F);
            this.StartPosition = FormStartPosition.Manual;
            //  this.SetAutoSizeMode(System.Windows.Forms.AutoSizeMode.GrowAndShrink);
            // this.MaximizeBox = false;
            // this.MinimizeBox = false;
           // pbPanelRysowniczy.Location = new Point(pbBtnStart.Location.X + pbBtnStart.Width + 100, 2 * pbMarginesFormularza);
            pbPanelRysowniczy.Width = (int)(this.Width * 0.7);
            pbPanelRysowniczy.Height = (int)(this.Height * 0.7F);
            pbPanelRysowniczy.BackColor = Color.Beige;
            pbPanelRysowniczy.BorderStyle = BorderStyle.Fixed3D;
            pbRysownica = pbPanelRysowniczy.CreateGraphics();
            pbUchwytFormularza = this;
            //suwak długoścci linii
            pbtTbrGruboscLini.Minimum = 1;
            pbtTbrGruboscLini.Maximum = 10;
            pbtTbrGruboscLini.Value = 3;
            pbPioro.Width = pbtTbrGruboscLini.Value;
            pbGruboscLini.Text = "Aktualna grubość:" + pbPioro.Width;
            
        }
  
       

        private void pbBtnStart_Click(object sender, EventArgs e)
        {
            int pbN;
            if (string.IsNullOrEmpty(pbTxtN.Text.Trim()))
            {
                errorProvider1.SetError(pbTxtN, "ERROR: podaj liczbe figur geometrycznych");
                return;
            }
            else
            {
                errorProvider1.Dispose();
            }
            if (!int.TryParse(pbTxtN.Text, out pbN))
            {
                errorProvider1.SetError(pbTxtN, "ERROR: wystapil niedozwolony znak:");
                return;
            }
            else
            {
                errorProvider1.Dispose();
            }
            if (pbN <= 0)
            {
                errorProvider1.SetError(pbTxtN, "ERROR: podaj liczbe figur > 0");
                return;
            }
            else
            {
                errorProvider1.Dispose();
            }
            pbTxtN.Enabled = false;

            // utworzenie egzemplarzy figur geometrycznych
            pbTabFiguryGeom = new Punkt[pbN * pbFiguryGeomChk.CheckedItems.Count];
            pbIndexFigur = 0;

            // sprawdzenie czy wybrano figury geometrzyczne
            if (pbFiguryGeomChk.CheckedItems.Count <= 0)
            {
                errorProvider1.SetError(pbFiguryGeomChk, "ERROR: wybierz figury");
                return;
            }
            else
            {
                errorProvider1.Dispose();
            }

            // wybranie indeksow figur
            int[] pbWybraneFiguryGeom = new int[pbFiguryGeomChk.CheckedItems.Count];
            int Index = 0;
            foreach (object WybranaFigura in pbFiguryGeomChk.CheckedItems)
            {
                pbWybraneFiguryGeom[Index++] = (int)pbFiguryGeomChk.Items.IndexOf(WybranaFigura);

                // ogreslenie rozmiarow pow. graficznej
                int pbXmax = pbPanelRysowniczy.Width;
                int pbYmax = pbPanelRysowniczy.Height;

                /* deklaracaj i utw. oiektu random
                 * dla generowania liczb losowych
                 * 
                 */
                Random pbLiczbaLososwa = new Random();

                int pbXp, pbYp; // wsp. polozenia figury geom
                Color pbKolor; // kolor figury
                int pbGruboscLinii;
                DashStyle pbStylLinii;

                for (int i = 0; i < pbN; i++)
                {
                    // losowanie wsp. polozenia figury
                    pbXp = pbLiczbaLososwa.Next(pbMarginesPanel, pbXmax - pbMarginesPanel);
                    pbYp = pbLiczbaLososwa.Next(pbMarginesPanel, pbYmax - pbMarginesPanel);

                    pbKolor = Color.FromArgb(pbLiczbaLososwa.Next(0, 255),
                                           pbLiczbaLososwa.Next(0, 255),
                                           pbLiczbaLososwa.Next(0, 255));
                    switch (pbLiczbaLososwa.Next(1, 6))
                    {
                        case 1: pbStylLinii = DashStyle.Dash; break;
                        case 2: pbStylLinii = DashStyle.DashDot; break;
                        case 3: pbStylLinii = DashStyle.DashDotDot; break;
                        case 4: pbStylLinii = DashStyle.Dot; break;
                        case 5: pbStylLinii = DashStyle.Solid; break;
                        default: pbStylLinii = DashStyle.Solid; break;
                    }

                    // losowanie grubosci linii
                    pbGruboscLinii = pbLiczbaLososwa.Next(1, 10);
                    // wybranie losowo figury z tablicy
                    int pbNrFigGeom = pbWybraneFiguryGeom[pbLiczbaLososwa.Next(0, pbWybraneFiguryGeom.Length)];
                    // utworzenie egzemplarza
                    switch (pbNrFigGeom)
                    {
                        case 0: // Punkt
                            pbTabFiguryGeom[pbIndexFigur] = new Punkt(pbXp, pbYp);
                            pbTabFiguryGeom[pbIndexFigur].pbFormatujFG(pbKolor, pbStylLinii, pbGruboscLinii);
                            pbTabFiguryGeom[pbIndexFigur].pbWykresl(pbRysownica);
                            pbIndexFigur++;
                            break;

                        case 1: // Linia
                            int xk = pbLiczbaLososwa.Next(pbMarginesPanel, pbXmax - pbMarginesPanel);
                            int yk = pbLiczbaLososwa.Next(pbMarginesPanel, pbYmax - pbMarginesPanel);
                            pbTabFiguryGeom[pbIndexFigur] = new Linia(pbXp, pbYp, xk, yk);
                            pbTabFiguryGeom[pbIndexFigur].pbFormatujFG(pbKolor, pbStylLinii, pbGruboscLinii);
                            pbTabFiguryGeom[pbIndexFigur].pbWykresl(pbRysownica);
                            pbIndexFigur++;
                            break;

                        case 2: // Elipsa
                            int pbOsDluga = pbLiczbaLososwa.Next(pbMarginesPanel, pbXmax - pbMarginesPanel);
                            int pbOsKrotka = pbLiczbaLososwa.Next(pbMarginesPanel, pbYmax - pbMarginesPanel);
                            pbTabFiguryGeom[pbIndexFigur] = new Elipsa(pbXp, pbYp, pbOsDluga, pbOsKrotka);
                            pbTabFiguryGeom[pbIndexFigur].pbFormatujFG(pbKolor, pbStylLinii, pbGruboscLinii);
                            pbTabFiguryGeom[pbIndexFigur].pbWykresl(pbRysownica);
                            pbIndexFigur++;
                            break;

                            case 3: // Okrąg
                            int promień = pbLiczbaLososwa.Next(pbMarginesPanel, pbXmax - pbMarginesPanel);
                            pbTabFiguryGeom[pbIndexFigur] = new Okrag(pbXp, pbYp, promień);
                            pbTabFiguryGeom[pbIndexFigur].pbFormatujFG(pbKolor, pbStylLinii, pbGruboscLinii);
                            pbTabFiguryGeom[pbIndexFigur].pbWykresl(pbRysownica);
                            pbIndexFigur++;
                            break;

                        case 4: // Prostokąt
                            xk = pbLiczbaLososwa.Next(pbMarginesPanel, pbXmax - pbMarginesPanel);
                            yk = pbLiczbaLososwa.Next(pbMarginesPanel, pbYmax - pbMarginesPanel);
                            pbTabFiguryGeom[pbIndexFigur] = new Prostokat(pbXp, pbYp, xk, yk);
                            pbTabFiguryGeom[pbIndexFigur].pbFormatujFG(pbKolor, pbStylLinii, pbGruboscLinii);
                            pbTabFiguryGeom[pbIndexFigur].pbWykresl(pbRysownica);
                            pbIndexFigur++;
                            break;

                        case 5: // Kwadrat
                            int szerokosc = pbLiczbaLososwa.Next(pbMarginesPanel, pbYmax - pbMarginesPanel);
                            pbTabFiguryGeom[pbIndexFigur] = new Kwadrat(pbXp, pbYp, szerokosc);
                            pbTabFiguryGeom[pbIndexFigur].pbFormatujFG(pbKolor, pbStylLinii, pbGruboscLinii);
                            pbTabFiguryGeom[pbIndexFigur].pbWykresl(pbRysownica);
                            pbIndexFigur++;
                            break;

                        default:
                            errorProvider1.SetError(pbBtnStart, "Figura o numerze " + pbNrFigGeom + " nie istnieje");
                            return;
                    }
                } // for

                pbBtnStart.Enabled = true;
            }
        }

        private void pbLblOpisLosowo_Click(object sender, EventArgs e)
        {

        }

        private void pbLblX_Click(object sender, EventArgs e)
        {

        }
        //Obsługa myszy
        private void pbPanelRysowniczy_MouseDown(object sender, MouseEventArgs e)
        {
            //wyświetlanie aktualnego położenia myszy
            pbLblX.Text = e.Location.X.ToString();
            pbLblY.Text = e.Location.Y.ToString();

            if (e.Button == MouseButtons.Left)
            {
                pbPunkt = e.Location;
            }
        }
        private void pbPanelRysowniczy_MouseUp(object sender, MouseEventArgs e)
        {
            //wyświetlanie aktualnego położenia myszy
            pbLblX.Text = e.Location.X.ToString();
            pbLblY.Text = e.Location.Y.ToString();

            int pbLewyGoryNaroznikX =
               (pbPunkt.X > e.Location.X) ? e.Location.X : pbPunkt.X;
            int pbLewyGoryNaroznikY =
               (pbPunkt.Y > e.Location.Y) ? e.Location.Y : pbPunkt.Y;
            int pbSzerokosc = Math.Abs(pbPunkt.X - e.Location.X);
            int pbWysokosc = Math.Abs(pbPunkt.Y - e.Location.Y);

            if (e.Button == MouseButtons.Left)
            {
                if (pbRbtRysowanieReczne.Checked)
                {
                    pbRysownica.DrawLine(pbPioro, pbPunkt, e.Location);
                }
                else
                {
                    if (pbRbtLinia.Checked)
                    {
                        pbRysownica.DrawLine(pbPioro, pbPunkt, e.Location);
                    }
                    if (pbRbtProstokat.Checked)
                    {
                        pbRysownica.DrawRectangle(pbPioro, pbLewyGoryNaroznikX,pbLewyGoryNaroznikY, pbSzerokosc, pbWysokosc);
                    }
                    if (pbRbtElipsa.Checked)
                    {
                        pbRysownica.DrawEllipse(pbPioro, pbLewyGoryNaroznikX, pbLewyGoryNaroznikY, pbSzerokosc, pbWysokosc);
                    }
                    if (pbRbtKolo.Checked)
                    {
                        pbRysownica.DrawEllipse(pbPioro, pbLewyGoryNaroznikX, pbLewyGoryNaroznikY, pbSzerokosc, pbSzerokosc);
                    }                   
                    if (pbRbtKwadrat.Checked)
                    {
                        pbRysownica.DrawRectangle(pbPioro, pbLewyGoryNaroznikX, pbLewyGoryNaroznikY, pbSzerokosc, pbSzerokosc);
                    }
                }
                
            }
            pbPictureBox.Refresh();
        }

        private void pbPanelRysowniczy_MouseMove(object sender, MouseEventArgs e)
        {
            //wyświetlanie aktualnego położenia myszy
            pbLblX.Text = e.Location.X.ToString();
            pbLblY.Text = e.Location.Y.ToString();

            int pbLewyGoryNaroznikX =
               (pbPunkt.X > e.Location.X) ? e.Location.X : pbPunkt.X;
            int pbLewyGoryNaroznikY =
               (pbPunkt.Y > e.Location.Y) ? e.Location.Y : pbPunkt.Y;
            int pbSzerokosc = Math.Abs(pbPunkt.X - e.Location.X);
            int pbWysokosc = Math.Abs(pbPunkt.Y - e.Location.Y);

            if (e.Button == MouseButtons.Left)
            {
                pbRysownicaTymczasowa = pbPictureBox.CreateGraphics();

                if (pbRbtRysowanieReczne.Checked)
                {
                    pbRysownica.DrawLine(pbPioro, pbPunkt, e.Location);
                    pbPunkt = e.Location;
                    pbPictureBox.Refresh();
                }
                else
                {
                    if (pbRbtLinia.Checked)
                    {
                        pbRysownica.DrawLine(pbPioroTymczasowe, pbPunkt.X, pbPunkt.Y, e.Location.Y, e.Location.Y);


                    }
                    if (pbRbtProstokat.Checked)
                    {
                        pbRysownicaTymczasowa.DrawRectangle(pbPioroTymczasowe, new Rectangle( pbLewyGoryNaroznikX, pbLewyGoryNaroznikY, pbSzerokosc, pbWysokosc));
                    }
                    if (pbRbtElipsa.Checked)
                    {
                        pbRysownicaTymczasowa.DrawEllipse(pbPioroTymczasowe, new Rectangle(pbLewyGoryNaroznikX, pbLewyGoryNaroznikY, pbSzerokosc, pbWysokosc));
                    }
                    if (pbRbtKolo.Checked)
                    {

                    }
                    if (pbRbtKwadrat.Checked)
                    {

                    }
                }
                pbPictureBox.Refresh();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                pbPanelRysowniczy.BackColor = colorDialog1.Color;
            }
        }

        private void pbZmianaKoloruPedzla_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                pbPioro.Color = colorDialog1.Color;
            }
            
        }

        private void pbLblZmianaGrubosciLini_Click(object sender, EventArgs e)
        {

        }

        private void pbtTbrGruboscLini_Scroll(object sender, EventArgs e)
        {
            pbPioro.Width = pbtTbrGruboscLini.Value;
            pbGruboscLini.Text = "Aktualna grubość:"+pbPioro.Width;
        }

        private void pbWyczyscTlo_Click(object sender, EventArgs e)
        {
            pbRysownica.Clear(pbPanelRysowniczy.BackColor);
        }

        private void Projekt2_PiotrBrodziak_49084_Load(object sender, EventArgs e)
        {

        }
        //zapisywanie i odczyt obrazu
        private void pbWczytajObraz_Click(object sender, EventArgs e)
        {
            OpenFileDialog pbOpen = new OpenFileDialog();
            pbOpen.Filter = "Image Files(*.jpg;*.jprg;*.gif; *.bmp;)|*.jpg;*.jprg;*.gif; *.bmp;";
            if (pbOpen.ShowDialog() == DialogResult.OK)
            {
                //  pbPlik = Image.FromFile(pbF.FileName);
                pictureBox1.Image = new Bitmap(pbOpen.FileName);
            }
        }

        private void pbZapiszObraz_Click(object sender, EventArgs e)
        {
            SaveFileDialog pbSave = new SaveFileDialog();
            
            pbSave.Filter = "Image Files(*.jpg; *.jprg; *.gif; *.bmp;)| *.jpg; *.jprg; *.gif; *.bmp; ";
            if (pbSave.ShowDialog()==DialogResult.OK)
            {
                
                //Bitmap bmp = new Bitmap(pbSave.FileName);
                //bmp.Save(DialogResult.ToString);
            }
        }
    }
}
