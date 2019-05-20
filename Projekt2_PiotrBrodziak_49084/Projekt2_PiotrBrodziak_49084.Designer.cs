namespace Projekt2_PiotrBrodziak_49084
{
    partial class Projekt2_PiotrBrodziak_49084
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbLblX = new System.Windows.Forms.Label();
            this.pbBtnStart = new System.Windows.Forms.Button();
            this.pbTxtN = new System.Windows.Forms.TextBox();
            this.pbFiguryGeomChk = new System.Windows.Forms.CheckedListBox();
            this.pbPanelLosowo = new System.Windows.Forms.Panel();
            this.pbLblWybierzLiczbęFigur = new System.Windows.Forms.Label();
            this.pbLblOpisLosowo = new System.Windows.Forms.Label();
            this.pbPanelRysowniczy = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pbtTbrGruboscLini = new System.Windows.Forms.TrackBar();
            this.pbPlblPrzygotwal = new System.Windows.Forms.Label();
            this.pbRbtRysowanieReczne = new System.Windows.Forms.RadioButton();
            this.pbRbtLinia = new System.Windows.Forms.RadioButton();
            this.pbRbtElipsa = new System.Windows.Forms.RadioButton();
            this.pbRbtKolo = new System.Windows.Forms.RadioButton();
            this.pbRbtProstokat = new System.Windows.Forms.RadioButton();
            this.pbRbtKwadrat = new System.Windows.Forms.RadioButton();
            this.pbBtnZmianaKoloru = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pbZmianaKoloruPedzla = new System.Windows.Forms.Button();
            this.pbLblZmianaGrubosciLini = new System.Windows.Forms.Label();
            this.pbWyczyscTlo = new System.Windows.Forms.Button();
            this.pbGruboscLini = new System.Windows.Forms.Label();
            this.pbLblY = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbZapiszObraz = new System.Windows.Forms.Button();
            this.pbWczytajObraz = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbPanelLosowo.SuspendLayout();
            this.pbPanelRysowniczy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtTbrGruboscLini)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLblX
            // 
            this.pbLblX.AutoSize = true;
            this.pbLblX.BackColor = System.Drawing.Color.Maroon;
            this.pbLblX.ForeColor = System.Drawing.SystemColors.Control;
            this.pbLblX.Location = new System.Drawing.Point(42, 53);
            this.pbLblX.MinimumSize = new System.Drawing.Size(40, 20);
            this.pbLblX.Name = "pbLblX";
            this.pbLblX.Size = new System.Drawing.Size(40, 20);
            this.pbLblX.TabIndex = 0;
            this.pbLblX.Text = "x: ";
            this.pbLblX.Click += new System.EventHandler(this.pbLblX_Click);
            // 
            // pbBtnStart
            // 
            this.pbBtnStart.Location = new System.Drawing.Point(3, 32);
            this.pbBtnStart.Name = "pbBtnStart";
            this.pbBtnStart.Size = new System.Drawing.Size(244, 23);
            this.pbBtnStart.TabIndex = 3;
            this.pbBtnStart.Text = "Start";
            this.pbBtnStart.UseVisualStyleBackColor = true;
            this.pbBtnStart.Click += new System.EventHandler(this.pbBtnStart_Click);
            // 
            // pbTxtN
            // 
            this.pbTxtN.Location = new System.Drawing.Point(73, 56);
            this.pbTxtN.Name = "pbTxtN";
            this.pbTxtN.Size = new System.Drawing.Size(171, 20);
            this.pbTxtN.TabIndex = 4;
            // 
            // pbFiguryGeomChk
            // 
            this.pbFiguryGeomChk.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbFiguryGeomChk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pbFiguryGeomChk.FormattingEnabled = true;
            this.pbFiguryGeomChk.Items.AddRange(new object[] {
            "Punkt",
            "Linia",
            "Elipsa",
            "Okrag",
            "Prostokat",
            "Kwadrat"});
            this.pbFiguryGeomChk.Location = new System.Drawing.Point(42, 169);
            this.pbFiguryGeomChk.Name = "pbFiguryGeomChk";
            this.pbFiguryGeomChk.Size = new System.Drawing.Size(247, 90);
            this.pbFiguryGeomChk.TabIndex = 5;
            // 
            // pbPanelLosowo
            // 
            this.pbPanelLosowo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbPanelLosowo.Controls.Add(this.pbLblWybierzLiczbęFigur);
            this.pbPanelLosowo.Controls.Add(this.pbTxtN);
            this.pbPanelLosowo.Controls.Add(this.pbBtnStart);
            this.pbPanelLosowo.Controls.Add(this.pbLblOpisLosowo);
            this.pbPanelLosowo.Location = new System.Drawing.Point(42, 76);
            this.pbPanelLosowo.Name = "pbPanelLosowo";
            this.pbPanelLosowo.Size = new System.Drawing.Size(247, 87);
            this.pbPanelLosowo.TabIndex = 6;
            // 
            // pbLblWybierzLiczbęFigur
            // 
            this.pbLblWybierzLiczbęFigur.AutoSize = true;
            this.pbLblWybierzLiczbęFigur.Location = new System.Drawing.Point(3, 58);
            this.pbLblWybierzLiczbęFigur.Name = "pbLblWybierzLiczbęFigur";
            this.pbLblWybierzLiczbęFigur.Size = new System.Drawing.Size(64, 13);
            this.pbLblWybierzLiczbęFigur.TabIndex = 7;
            this.pbLblWybierzLiczbęFigur.Text = "Liczba Figur";
            // 
            // pbLblOpisLosowo
            // 
            this.pbLblOpisLosowo.AutoSize = true;
            this.pbLblOpisLosowo.Location = new System.Drawing.Point(3, 11);
            this.pbLblOpisLosowo.Name = "pbLblOpisLosowo";
            this.pbLblOpisLosowo.Size = new System.Drawing.Size(241, 13);
            this.pbLblOpisLosowo.TabIndex = 6;
            this.pbLblOpisLosowo.Text = "Generowanie Figuty o losowym kolorze i wielkości";
            this.pbLblOpisLosowo.Click += new System.EventHandler(this.pbLblOpisLosowo_Click);
            // 
            // pbPanelRysowniczy
            // 
            this.pbPanelRysowniczy.Controls.Add(this.pictureBox1);
            this.pbPanelRysowniczy.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbPanelRysowniczy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbPanelRysowniczy.Location = new System.Drawing.Point(292, 53);
            this.pbPanelRysowniczy.Name = "pbPanelRysowniczy";
            this.pbPanelRysowniczy.Size = new System.Drawing.Size(750, 447);
            this.pbPanelRysowniczy.TabIndex = 2;
            this.pbPanelRysowniczy.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbPanelRysowniczy_MouseDown);
            this.pbPanelRysowniczy.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbPanelRysowniczy_MouseMove);
            this.pbPanelRysowniczy.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbPanelRysowniczy_MouseUp);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // pbtTbrGruboscLini
            // 
            this.pbtTbrGruboscLini.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pbtTbrGruboscLini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errorProvider1.SetIconAlignment(this.pbtTbrGruboscLini, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.pbtTbrGruboscLini.Location = new System.Drawing.Point(295, 5);
            this.pbtTbrGruboscLini.Minimum = 10;
            this.pbtTbrGruboscLini.MinimumSize = new System.Drawing.Size(0, 15);
            this.pbtTbrGruboscLini.Name = "pbtTbrGruboscLini";
            this.pbtTbrGruboscLini.Size = new System.Drawing.Size(179, 45);
            this.pbtTbrGruboscLini.TabIndex = 16;
            this.pbtTbrGruboscLini.Value = 10;
            this.pbtTbrGruboscLini.Scroll += new System.EventHandler(this.pbtTbrGruboscLini_Scroll);
            // 
            // pbPlblPrzygotwal
            // 
            this.pbPlblPrzygotwal.AutoSize = true;
            this.pbPlblPrzygotwal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pbPlblPrzygotwal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPlblPrzygotwal.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pbPlblPrzygotwal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbPlblPrzygotwal.Location = new System.Drawing.Point(42, 516);
            this.pbPlblPrzygotwal.Name = "pbPlblPrzygotwal";
            this.pbPlblPrzygotwal.Size = new System.Drawing.Size(417, 38);
            this.pbPlblPrzygotwal.TabIndex = 7;
            this.pbPlblPrzygotwal.Text = "Przygotował Piotr Brodziak 49084";
            // 
            // pbRbtRysowanieReczne
            // 
            this.pbRbtRysowanieReczne.AutoSize = true;
            this.pbRbtRysowanieReczne.Checked = true;
            this.pbRbtRysowanieReczne.Location = new System.Drawing.Point(42, 265);
            this.pbRbtRysowanieReczne.Name = "pbRbtRysowanieReczne";
            this.pbRbtRysowanieReczne.Size = new System.Drawing.Size(117, 17);
            this.pbRbtRysowanieReczne.TabIndex = 8;
            this.pbRbtRysowanieReczne.TabStop = true;
            this.pbRbtRysowanieReczne.Text = "Rysowanie Ręczne";
            this.pbRbtRysowanieReczne.UseVisualStyleBackColor = true;
            // 
            // pbRbtLinia
            // 
            this.pbRbtLinia.AutoSize = true;
            this.pbRbtLinia.Location = new System.Drawing.Point(42, 289);
            this.pbRbtLinia.Name = "pbRbtLinia";
            this.pbRbtLinia.Size = new System.Drawing.Size(47, 17);
            this.pbRbtLinia.TabIndex = 9;
            this.pbRbtLinia.Text = "Linia";
            this.pbRbtLinia.UseVisualStyleBackColor = true;
            // 
            // pbRbtElipsa
            // 
            this.pbRbtElipsa.AutoSize = true;
            this.pbRbtElipsa.Location = new System.Drawing.Point(165, 265);
            this.pbRbtElipsa.Name = "pbRbtElipsa";
            this.pbRbtElipsa.Size = new System.Drawing.Size(53, 17);
            this.pbRbtElipsa.TabIndex = 10;
            this.pbRbtElipsa.Text = "Elipsa";
            this.pbRbtElipsa.UseVisualStyleBackColor = true;
            // 
            // pbRbtKolo
            // 
            this.pbRbtKolo.AutoSize = true;
            this.pbRbtKolo.Location = new System.Drawing.Point(165, 289);
            this.pbRbtKolo.Name = "pbRbtKolo";
            this.pbRbtKolo.Size = new System.Drawing.Size(48, 17);
            this.pbRbtKolo.TabIndex = 11;
            this.pbRbtKolo.Text = "Koło";
            this.pbRbtKolo.UseVisualStyleBackColor = true;
            // 
            // pbRbtProstokat
            // 
            this.pbRbtProstokat.AutoSize = true;
            this.pbRbtProstokat.Location = new System.Drawing.Point(42, 312);
            this.pbRbtProstokat.Name = "pbRbtProstokat";
            this.pbRbtProstokat.Size = new System.Drawing.Size(70, 17);
            this.pbRbtProstokat.TabIndex = 12;
            this.pbRbtProstokat.Text = "Prostokąt";
            this.pbRbtProstokat.UseVisualStyleBackColor = true;
            // 
            // pbRbtKwadrat
            // 
            this.pbRbtKwadrat.AutoSize = true;
            this.pbRbtKwadrat.Location = new System.Drawing.Point(165, 312);
            this.pbRbtKwadrat.Name = "pbRbtKwadrat";
            this.pbRbtKwadrat.Size = new System.Drawing.Size(64, 17);
            this.pbRbtKwadrat.TabIndex = 13;
            this.pbRbtKwadrat.Text = "Kwadrat";
            this.pbRbtKwadrat.UseVisualStyleBackColor = true;
            // 
            // pbBtnZmianaKoloru
            // 
            this.pbBtnZmianaKoloru.BackColor = System.Drawing.Color.Chocolate;
            this.pbBtnZmianaKoloru.Location = new System.Drawing.Point(42, 373);
            this.pbBtnZmianaKoloru.Name = "pbBtnZmianaKoloru";
            this.pbBtnZmianaKoloru.Size = new System.Drawing.Size(200, 23);
            this.pbBtnZmianaKoloru.TabIndex = 14;
            this.pbBtnZmianaKoloru.Text = "Zmiana koloru tła";
            this.pbBtnZmianaKoloru.UseVisualStyleBackColor = false;
            this.pbBtnZmianaKoloru.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbZmianaKoloruPedzla
            // 
            this.pbZmianaKoloruPedzla.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pbZmianaKoloruPedzla.Location = new System.Drawing.Point(42, 344);
            this.pbZmianaKoloruPedzla.Name = "pbZmianaKoloruPedzla";
            this.pbZmianaKoloruPedzla.Size = new System.Drawing.Size(200, 23);
            this.pbZmianaKoloruPedzla.TabIndex = 15;
            this.pbZmianaKoloruPedzla.Text = "Zmiana Koloru Pędzla";
            this.pbZmianaKoloruPedzla.UseVisualStyleBackColor = false;
            this.pbZmianaKoloruPedzla.Click += new System.EventHandler(this.pbZmianaKoloruPedzla_Click);
            // 
            // pbLblZmianaGrubosciLini
            // 
            this.pbLblZmianaGrubosciLini.AutoSize = true;
            this.pbLblZmianaGrubosciLini.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pbLblZmianaGrubosciLini.Location = new System.Drawing.Point(329, 23);
            this.pbLblZmianaGrubosciLini.Name = "pbLblZmianaGrubosciLini";
            this.pbLblZmianaGrubosciLini.Size = new System.Drawing.Size(107, 13);
            this.pbLblZmianaGrubosciLini.TabIndex = 17;
            this.pbLblZmianaGrubosciLini.Text = "Zmiana długości Linii";
            this.pbLblZmianaGrubosciLini.Click += new System.EventHandler(this.pbLblZmianaGrubosciLini_Click);
            // 
            // pbWyczyscTlo
            // 
            this.pbWyczyscTlo.BackColor = System.Drawing.Color.Firebrick;
            this.pbWyczyscTlo.Location = new System.Drawing.Point(42, 402);
            this.pbWyczyscTlo.Name = "pbWyczyscTlo";
            this.pbWyczyscTlo.Size = new System.Drawing.Size(200, 23);
            this.pbWyczyscTlo.TabIndex = 18;
            this.pbWyczyscTlo.Text = "WyczyśćPanel Rysowniczy";
            this.pbWyczyscTlo.UseVisualStyleBackColor = false;
            this.pbWyczyscTlo.Click += new System.EventHandler(this.pbWyczyscTlo_Click);
            // 
            // pbGruboscLini
            // 
            this.pbGruboscLini.AutoSize = true;
            this.pbGruboscLini.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pbGruboscLini.Location = new System.Drawing.Point(480, 10);
            this.pbGruboscLini.MinimumSize = new System.Drawing.Size(0, 40);
            this.pbGruboscLini.Name = "pbGruboscLini";
            this.pbGruboscLini.Size = new System.Drawing.Size(35, 40);
            this.pbGruboscLini.TabIndex = 19;
            this.pbGruboscLini.Text = "label1";
            // 
            // pbLblY
            // 
            this.pbLblY.AutoSize = true;
            this.pbLblY.BackColor = System.Drawing.Color.Maroon;
            this.pbLblY.ForeColor = System.Drawing.SystemColors.Control;
            this.pbLblY.Location = new System.Drawing.Point(46, 0);
            this.pbLblY.MaximumSize = new System.Drawing.Size(40, 20);
            this.pbLblY.MinimumSize = new System.Drawing.Size(40, 20);
            this.pbLblY.Name = "pbLblY";
            this.pbLblY.Size = new System.Drawing.Size(40, 20);
            this.pbLblY.TabIndex = 1;
            this.pbLblY.Text = "y: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pbLblY);
            this.panel1.Location = new System.Drawing.Point(42, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 501);
            this.panel1.TabIndex = 20;
            // 
            // pbZapiszObraz
            // 
            this.pbZapiszObraz.Location = new System.Drawing.Point(574, 13);
            this.pbZapiszObraz.Name = "pbZapiszObraz";
            this.pbZapiszObraz.Size = new System.Drawing.Size(101, 23);
            this.pbZapiszObraz.TabIndex = 21;
            this.pbZapiszObraz.Text = "Zapisz obraz";
            this.pbZapiszObraz.UseVisualStyleBackColor = true;
            this.pbZapiszObraz.Click += new System.EventHandler(this.pbZapiszObraz_Click);
            // 
            // pbWczytajObraz
            // 
            this.pbWczytajObraz.Location = new System.Drawing.Point(681, 13);
            this.pbWczytajObraz.Name = "pbWczytajObraz";
            this.pbWczytajObraz.Size = new System.Drawing.Size(119, 23);
            this.pbWczytajObraz.TabIndex = 22;
            this.pbWczytajObraz.Text = " Wczytaj obraz";
            this.pbWczytajObraz.UseVisualStyleBackColor = true;
            this.pbWczytajObraz.Click += new System.EventHandler(this.pbWczytajObraz_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 20);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Projekt2_PiotrBrodziak_49084
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 604);
            this.Controls.Add(this.pbWczytajObraz);
            this.Controls.Add(this.pbZapiszObraz);
            this.Controls.Add(this.pbPlblPrzygotwal);
            this.Controls.Add(this.pbGruboscLini);
            this.Controls.Add(this.pbWyczyscTlo);
            this.Controls.Add(this.pbLblZmianaGrubosciLini);
            this.Controls.Add(this.pbtTbrGruboscLini);
            this.Controls.Add(this.pbZmianaKoloruPedzla);
            this.Controls.Add(this.pbBtnZmianaKoloru);
            this.Controls.Add(this.pbRbtKwadrat);
            this.Controls.Add(this.pbRbtProstokat);
            this.Controls.Add(this.pbRbtKolo);
            this.Controls.Add(this.pbRbtElipsa);
            this.Controls.Add(this.pbRbtLinia);
            this.Controls.Add(this.pbRbtRysowanieReczne);
            this.Controls.Add(this.pbPanelRysowniczy);
            this.Controls.Add(this.pbFiguryGeomChk);
            this.Controls.Add(this.pbPanelLosowo);
            this.Controls.Add(this.pbLblX);
            this.Controls.Add(this.panel1);
            this.Name = "Projekt2_PiotrBrodziak_49084";
            this.Text = "Projekt2_PiotrBrodziak_49084";
            this.pbPanelLosowo.ResumeLayout(false);
            this.pbPanelLosowo.PerformLayout();
            this.pbPanelRysowniczy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtTbrGruboscLini)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pbLblX;
        private System.Windows.Forms.Button pbBtnStart;
        private System.Windows.Forms.TextBox pbTxtN;
        private System.Windows.Forms.CheckedListBox pbFiguryGeomChk;
        private System.Windows.Forms.Panel pbPanelLosowo;
        private System.Windows.Forms.Label pbLblOpisLosowo;
        private System.Windows.Forms.Label pbLblWybierzLiczbęFigur;
        private System.Windows.Forms.Panel pbPanelRysowniczy;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label pbPlblPrzygotwal;
        private System.Windows.Forms.RadioButton pbRbtKwadrat;
        private System.Windows.Forms.RadioButton pbRbtProstokat;
        private System.Windows.Forms.RadioButton pbRbtKolo;
        private System.Windows.Forms.RadioButton pbRbtElipsa;
        private System.Windows.Forms.RadioButton pbRbtLinia;
        private System.Windows.Forms.RadioButton pbRbtRysowanieReczne;
        private System.Windows.Forms.Button pbBtnZmianaKoloru;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button pbZmianaKoloruPedzla;
        private System.Windows.Forms.TrackBar pbtTbrGruboscLini;
        private System.Windows.Forms.Label pbLblZmianaGrubosciLini;
        private System.Windows.Forms.Button pbWyczyscTlo;
        private System.Windows.Forms.Label pbGruboscLini;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label pbLblY;
        private System.Windows.Forms.Button pbWczytajObraz;
        private System.Windows.Forms.Button pbZapiszObraz;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

