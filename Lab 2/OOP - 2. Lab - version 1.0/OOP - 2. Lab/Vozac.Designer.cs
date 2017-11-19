namespace OOP___2.Lab
{
    partial class Vozac
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vozac));
            this.gbOsnovni = new System.Windows.Forms.GroupBox();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.cbPol = new System.Windows.Forms.ComboBox();
            this.tbMestoIzadavanja = new System.Windows.Forms.TextBox();
            this.tbbrVozacke = new System.Windows.Forms.TextBox();
            this.dpDozDo = new System.Windows.Forms.DateTimePicker();
            this.dpDatDozOd = new System.Windows.Forms.DateTimePicker();
            this.dpDatRodj = new System.Windows.Forms.DateTimePicker();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.btnIzaberiSliku = new System.Windows.Forms.Button();
            this.lbPol = new System.Windows.Forms.Label();
            this.lbMestoIzdavanja = new System.Windows.Forms.Label();
            this.lbBrojVozacke = new System.Windows.Forms.Label();
            this.lbVaziDo = new System.Windows.Forms.Label();
            this.lbVaziOd = new System.Windows.Forms.Label();
            this.lbDatRodj = new System.Windows.Forms.Label();
            this.lbPrezime = new System.Windows.Forms.Label();
            this.lbIme = new System.Windows.Forms.Label();
            this.Kategorija = new System.Windows.Forms.GroupBox();
            this.btnObrisiKategoriju = new System.Windows.Forms.Button();
            this.imlsIcons = new System.Windows.Forms.ImageList(this.components);
            this.dgvKategorija = new System.Windows.Forms.DataGridView();
            this.btnDodajKategoriju = new System.Windows.Forms.Button();
            this.gbZabrana = new System.Windows.Forms.GroupBox();
            this.btnObrisiZabranu = new System.Windows.Forms.Button();
            this.btnDodajZabranu = new System.Windows.Forms.Button();
            this.dgvZabrana = new System.Windows.Forms.DataGridView();
            this.btnProsledi = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.gbOsnovni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.Kategorija.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategorija)).BeginInit();
            this.gbZabrana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZabrana)).BeginInit();
            this.SuspendLayout();
            // 
            // gbOsnovni
            // 
            this.gbOsnovni.Controls.Add(this.pbSlika);
            this.gbOsnovni.Controls.Add(this.cbPol);
            this.gbOsnovni.Controls.Add(this.tbMestoIzadavanja);
            this.gbOsnovni.Controls.Add(this.tbbrVozacke);
            this.gbOsnovni.Controls.Add(this.dpDozDo);
            this.gbOsnovni.Controls.Add(this.dpDatDozOd);
            this.gbOsnovni.Controls.Add(this.dpDatRodj);
            this.gbOsnovni.Controls.Add(this.tbPrezime);
            this.gbOsnovni.Controls.Add(this.tbIme);
            this.gbOsnovni.Controls.Add(this.btnIzaberiSliku);
            this.gbOsnovni.Controls.Add(this.lbPol);
            this.gbOsnovni.Controls.Add(this.lbMestoIzdavanja);
            this.gbOsnovni.Controls.Add(this.lbBrojVozacke);
            this.gbOsnovni.Controls.Add(this.lbVaziDo);
            this.gbOsnovni.Controls.Add(this.lbVaziOd);
            this.gbOsnovni.Controls.Add(this.lbDatRodj);
            this.gbOsnovni.Controls.Add(this.lbPrezime);
            this.gbOsnovni.Controls.Add(this.lbIme);
            this.gbOsnovni.Location = new System.Drawing.Point(6, 2);
            this.gbOsnovni.Name = "gbOsnovni";
            this.gbOsnovni.Size = new System.Drawing.Size(424, 280);
            this.gbOsnovni.TabIndex = 0;
            this.gbOsnovni.TabStop = false;
            this.gbOsnovni.Text = "Osnovni podaci:";
            // 
            // pbSlika
            // 
            this.pbSlika.Location = new System.Drawing.Point(284, 24);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(119, 113);
            this.pbSlika.TabIndex = 17;
            this.pbSlika.TabStop = false;
            // 
            // cbPol
            // 
            this.cbPol.FormattingEnabled = true;
            this.cbPol.Location = new System.Drawing.Point(118, 249);
            this.cbPol.Name = "cbPol";
            this.cbPol.Size = new System.Drawing.Size(133, 21);
            this.cbPol.TabIndex = 16;
            // 
            // tbMestoIzadavanja
            // 
            this.tbMestoIzadavanja.Location = new System.Drawing.Point(118, 218);
            this.tbMestoIzadavanja.Name = "tbMestoIzadavanja";
            this.tbMestoIzadavanja.Size = new System.Drawing.Size(133, 20);
            this.tbMestoIzadavanja.TabIndex = 15;
            this.tbMestoIzadavanja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIme_KeyPress);
            // 
            // tbbrVozacke
            // 
            this.tbbrVozacke.Location = new System.Drawing.Point(118, 187);
            this.tbbrVozacke.Name = "tbbrVozacke";
            this.tbbrVozacke.Size = new System.Drawing.Size(133, 20);
            this.tbbrVozacke.TabIndex = 14;
            this.tbbrVozacke.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbbrVozacke_KeyPress);
            // 
            // dpDozDo
            // 
            this.dpDozDo.CustomFormat = "dd.MM.yyyy";
            this.dpDozDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpDozDo.Location = new System.Drawing.Point(116, 157);
            this.dpDozDo.Name = "dpDozDo";
            this.dpDozDo.Size = new System.Drawing.Size(135, 20);
            this.dpDozDo.TabIndex = 13;
            // 
            // dpDatDozOd
            // 
            this.dpDatDozOd.CustomFormat = "dd.MM.yyyy";
            this.dpDatDozOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpDatDozOd.Location = new System.Drawing.Point(118, 120);
            this.dpDatDozOd.Name = "dpDatDozOd";
            this.dpDatDozOd.Size = new System.Drawing.Size(133, 20);
            this.dpDatDozOd.TabIndex = 12;
            // 
            // dpDatRodj
            // 
            this.dpDatRodj.CustomFormat = "dd.MM.yyyy";
            this.dpDatRodj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpDatRodj.Location = new System.Drawing.Point(118, 87);
            this.dpDatRodj.Name = "dpDatRodj";
            this.dpDatRodj.Size = new System.Drawing.Size(133, 20);
            this.dpDatRodj.TabIndex = 11;
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(118, 58);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(133, 20);
            this.tbPrezime.TabIndex = 10;
            this.tbPrezime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIme_KeyPress);
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(117, 25);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(134, 20);
            this.tbIme.TabIndex = 9;
            this.tbIme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIme_KeyPress);
            // 
            // btnIzaberiSliku
            // 
            this.btnIzaberiSliku.Location = new System.Drawing.Point(284, 157);
            this.btnIzaberiSliku.Name = "btnIzaberiSliku";
            this.btnIzaberiSliku.Size = new System.Drawing.Size(119, 23);
            this.btnIzaberiSliku.TabIndex = 8;
            this.btnIzaberiSliku.Text = "Dodaj sliku";
            this.btnIzaberiSliku.UseVisualStyleBackColor = true;
            this.btnIzaberiSliku.Click += new System.EventHandler(this.btnIzaberiSliku_Click);
            // 
            // lbPol
            // 
            this.lbPol.AutoSize = true;
            this.lbPol.Location = new System.Drawing.Point(85, 257);
            this.lbPol.Name = "lbPol";
            this.lbPol.Size = new System.Drawing.Size(25, 13);
            this.lbPol.TabIndex = 7;
            this.lbPol.Text = "Pol:";
            // 
            // lbMestoIzdavanja
            // 
            this.lbMestoIzdavanja.AutoSize = true;
            this.lbMestoIzdavanja.Location = new System.Drawing.Point(25, 221);
            this.lbMestoIzdavanja.Name = "lbMestoIzdavanja";
            this.lbMestoIzdavanja.Size = new System.Drawing.Size(87, 13);
            this.lbMestoIzdavanja.TabIndex = 6;
            this.lbMestoIzdavanja.Text = "Mesto izdavanja:";
            // 
            // lbBrojVozacke
            // 
            this.lbBrojVozacke.AutoSize = true;
            this.lbBrojVozacke.Location = new System.Drawing.Point(48, 190);
            this.lbBrojVozacke.Name = "lbBrojVozacke";
            this.lbBrojVozacke.Size = new System.Drawing.Size(64, 13);
            this.lbBrojVozacke.TabIndex = 5;
            this.lbBrojVozacke.Text = "Br vozacke:";
            // 
            // lbVaziDo
            // 
            this.lbVaziDo.AutoSize = true;
            this.lbVaziDo.Location = new System.Drawing.Point(88, 163);
            this.lbVaziDo.Name = "lbVaziDo";
            this.lbVaziDo.Size = new System.Drawing.Size(22, 13);
            this.lbVaziDo.TabIndex = 4;
            this.lbVaziDo.Text = "do:";
            // 
            // lbVaziOd
            // 
            this.lbVaziOd.AutoSize = true;
            this.lbVaziOd.Location = new System.Drawing.Point(9, 124);
            this.lbVaziOd.Name = "lbVaziOd";
            this.lbVaziOd.Size = new System.Drawing.Size(103, 13);
            this.lbVaziOd.TabIndex = 3;
            this.lbVaziOd.Text = "Vazenje dozvole od:";
            // 
            // lbDatRodj
            // 
            this.lbDatRodj.AutoSize = true;
            this.lbDatRodj.Location = new System.Drawing.Point(31, 93);
            this.lbDatRodj.Name = "lbDatRodj";
            this.lbDatRodj.Size = new System.Drawing.Size(81, 13);
            this.lbDatRodj.TabIndex = 2;
            this.lbDatRodj.Text = "Datum rodjenja:";
            // 
            // lbPrezime
            // 
            this.lbPrezime.AutoSize = true;
            this.lbPrezime.Location = new System.Drawing.Point(65, 61);
            this.lbPrezime.Name = "lbPrezime";
            this.lbPrezime.Size = new System.Drawing.Size(47, 13);
            this.lbPrezime.TabIndex = 1;
            this.lbPrezime.Text = "Prezime:";
            // 
            // lbIme
            // 
            this.lbIme.AutoSize = true;
            this.lbIme.Location = new System.Drawing.Point(83, 25);
            this.lbIme.Name = "lbIme";
            this.lbIme.Size = new System.Drawing.Size(27, 13);
            this.lbIme.TabIndex = 0;
            this.lbIme.Text = "Ime:";
            // 
            // Kategorija
            // 
            this.Kategorija.Controls.Add(this.btnObrisiKategoriju);
            this.Kategorija.Controls.Add(this.dgvKategorija);
            this.Kategorija.Controls.Add(this.btnDodajKategoriju);
            this.Kategorija.Location = new System.Drawing.Point(7, 288);
            this.Kategorija.Name = "Kategorija";
            this.Kategorija.Size = new System.Drawing.Size(424, 175);
            this.Kategorija.TabIndex = 1;
            this.Kategorija.TabStop = false;
            this.Kategorija.Text = "Kategorija";
            // 
            // btnObrisiKategoriju
            // 
            this.btnObrisiKategoriju.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObrisiKategoriju.ImageIndex = 1;
            this.btnObrisiKategoriju.ImageList = this.imlsIcons;
            this.btnObrisiKategoriju.Location = new System.Drawing.Point(293, 124);
            this.btnObrisiKategoriju.Name = "btnObrisiKategoriju";
            this.btnObrisiKategoriju.Size = new System.Drawing.Size(125, 45);
            this.btnObrisiKategoriju.TabIndex = 4;
            this.btnObrisiKategoriju.Text = "Obrisi kategoriju";
            this.btnObrisiKategoriju.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnObrisiKategoriju.UseVisualStyleBackColor = true;
            this.btnObrisiKategoriju.Click += new System.EventHandler(this.btnObrisiKategoriju_Click);
            // 
            // imlsIcons
            // 
            this.imlsIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlsIcons.ImageStream")));
            this.imlsIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imlsIcons.Images.SetKeyName(0, "Plus-icon.png");
            this.imlsIcons.Images.SetKeyName(1, "Science-Minus-Math-icon.png");
            // 
            // dgvKategorija
            // 
            this.dgvKategorija.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvKategorija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKategorija.Location = new System.Drawing.Point(6, 19);
            this.dgvKategorija.Name = "dgvKategorija";
            this.dgvKategorija.Size = new System.Drawing.Size(412, 99);
            this.dgvKategorija.TabIndex = 2;
            // 
            // btnDodajKategoriju
            // 
            this.btnDodajKategoriju.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajKategoriju.ImageIndex = 0;
            this.btnDodajKategoriju.ImageList = this.imlsIcons;
            this.btnDodajKategoriju.Location = new System.Drawing.Point(6, 124);
            this.btnDodajKategoriju.Name = "btnDodajKategoriju";
            this.btnDodajKategoriju.Size = new System.Drawing.Size(125, 45);
            this.btnDodajKategoriju.TabIndex = 0;
            this.btnDodajKategoriju.Text = "Dodaj kategoriju";
            this.btnDodajKategoriju.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDodajKategoriju.UseVisualStyleBackColor = true;
            this.btnDodajKategoriju.Click += new System.EventHandler(this.btnDodajKategoriju_Click);
            // 
            // gbZabrana
            // 
            this.gbZabrana.Controls.Add(this.btnObrisiZabranu);
            this.gbZabrana.Controls.Add(this.btnDodajZabranu);
            this.gbZabrana.Controls.Add(this.dgvZabrana);
            this.gbZabrana.Location = new System.Drawing.Point(6, 469);
            this.gbZabrana.Name = "gbZabrana";
            this.gbZabrana.Size = new System.Drawing.Size(424, 178);
            this.gbZabrana.TabIndex = 2;
            this.gbZabrana.TabStop = false;
            this.gbZabrana.Text = "Zabrana upravljanja:";
            // 
            // btnObrisiZabranu
            // 
            this.btnObrisiZabranu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObrisiZabranu.ImageIndex = 1;
            this.btnObrisiZabranu.ImageList = this.imlsIcons;
            this.btnObrisiZabranu.Location = new System.Drawing.Point(294, 124);
            this.btnObrisiZabranu.Name = "btnObrisiZabranu";
            this.btnObrisiZabranu.Size = new System.Drawing.Size(125, 45);
            this.btnObrisiZabranu.TabIndex = 5;
            this.btnObrisiZabranu.Text = "Obrisi zabranu";
            this.btnObrisiZabranu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnObrisiZabranu.UseVisualStyleBackColor = true;
            this.btnObrisiZabranu.Click += new System.EventHandler(this.btnObrisiZabranu_Click);
            // 
            // btnDodajZabranu
            // 
            this.btnDodajZabranu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajZabranu.ImageIndex = 0;
            this.btnDodajZabranu.ImageList = this.imlsIcons;
            this.btnDodajZabranu.Location = new System.Drawing.Point(6, 124);
            this.btnDodajZabranu.Name = "btnDodajZabranu";
            this.btnDodajZabranu.Size = new System.Drawing.Size(125, 45);
            this.btnDodajZabranu.TabIndex = 3;
            this.btnDodajZabranu.Text = "Dodaj zabranu";
            this.btnDodajZabranu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDodajZabranu.UseVisualStyleBackColor = true;
            this.btnDodajZabranu.Click += new System.EventHandler(this.btnDodajZabranu_Click);
            // 
            // dgvZabrana
            // 
            this.dgvZabrana.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvZabrana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZabrana.Location = new System.Drawing.Point(6, 19);
            this.dgvZabrana.Name = "dgvZabrana";
            this.dgvZabrana.Size = new System.Drawing.Size(412, 99);
            this.dgvZabrana.TabIndex = 3;
            // 
            // btnProsledi
            // 
            this.btnProsledi.Location = new System.Drawing.Point(142, 653);
            this.btnProsledi.Name = "btnProsledi";
            this.btnProsledi.Size = new System.Drawing.Size(75, 23);
            this.btnProsledi.TabIndex = 3;
            this.btnProsledi.Text = "Prosledi";
            this.btnProsledi.UseVisualStyleBackColor = true;
            this.btnProsledi.Click += new System.EventHandler(this.btnProsledi_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(223, 653);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 4;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // Vozac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(443, 677);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnProsledi);
            this.Controls.Add(this.gbZabrana);
            this.Controls.Add(this.Kategorija);
            this.Controls.Add(this.gbOsnovni);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Vozac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vozac";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Vozac_FormClosing);
            this.Load += new System.EventHandler(this.Vozac_Load);
            this.gbOsnovni.ResumeLayout(false);
            this.gbOsnovni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.Kategorija.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategorija)).EndInit();
            this.gbZabrana.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZabrana)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOsnovni;
        private System.Windows.Forms.TextBox tbbrVozacke;
        private System.Windows.Forms.DateTimePicker dpDozDo;
        private System.Windows.Forms.DateTimePicker dpDatDozOd;
        private System.Windows.Forms.DateTimePicker dpDatRodj;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Button btnIzaberiSliku;
        private System.Windows.Forms.Label lbPol;
        private System.Windows.Forms.Label lbMestoIzdavanja;
        private System.Windows.Forms.Label lbBrojVozacke;
        private System.Windows.Forms.Label lbVaziDo;
        private System.Windows.Forms.Label lbVaziOd;
        private System.Windows.Forms.Label lbDatRodj;
        private System.Windows.Forms.Label lbPrezime;
        private System.Windows.Forms.Label lbIme;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.ComboBox cbPol;
        private System.Windows.Forms.TextBox tbMestoIzadavanja;
        private System.Windows.Forms.GroupBox Kategorija;
        private System.Windows.Forms.Button btnObrisiKategoriju;
        private System.Windows.Forms.ImageList imlsIcons;
        private System.Windows.Forms.DataGridView dgvKategorija;
        private System.Windows.Forms.Button btnDodajKategoriju;
        private System.Windows.Forms.GroupBox gbZabrana;
        private System.Windows.Forms.Button btnObrisiZabranu;
        private System.Windows.Forms.Button btnDodajZabranu;
        private System.Windows.Forms.DataGridView dgvZabrana;
        private System.Windows.Forms.Button btnProsledi;
        private System.Windows.Forms.Button btnZatvori;
    }
}