namespace OOP__1.Lab
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbPodaci = new System.Windows.Forms.GroupBox();
            this.tbAdr = new System.Windows.Forms.TextBox();
            this.btnPonisti = new System.Windows.Forms.Button();
            this.ilSlike = new System.Windows.Forms.ImageList(this.components);
            this.btnZapamti = new System.Windows.Forms.Button();
            this.dtDatRodj = new System.Windows.Forms.DateTimePicker();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.lbAdr = new System.Windows.Forms.Label();
            this.lbPrezime = new System.Windows.Forms.Label();
            this.lbDatRodj = new System.Windows.Forms.Label();
            this.lbTel = new System.Windows.Forms.Label();
            this.lbIme = new System.Windows.Forms.Label();
            this.lbListaO = new System.Windows.Forms.Label();
            this.lbListaOsoba = new System.Windows.Forms.ListBox();
            this.btnObrisiosobu = new System.Windows.Forms.Button();
            this.btnObrisilistu = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.gbPodaci.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPodaci
            // 
            this.gbPodaci.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPodaci.Controls.Add(this.tbAdr);
            this.gbPodaci.Controls.Add(this.btnPonisti);
            this.gbPodaci.Controls.Add(this.btnZapamti);
            this.gbPodaci.Controls.Add(this.dtDatRodj);
            this.gbPodaci.Controls.Add(this.tbTel);
            this.gbPodaci.Controls.Add(this.tbPrezime);
            this.gbPodaci.Controls.Add(this.tbIme);
            this.gbPodaci.Controls.Add(this.lbAdr);
            this.gbPodaci.Controls.Add(this.lbPrezime);
            this.gbPodaci.Controls.Add(this.lbDatRodj);
            this.gbPodaci.Controls.Add(this.lbTel);
            this.gbPodaci.Controls.Add(this.lbIme);
            this.gbPodaci.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPodaci.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbPodaci.Location = new System.Drawing.Point(18, 15);
            this.gbPodaci.Margin = new System.Windows.Forms.Padding(4);
            this.gbPodaci.Name = "gbPodaci";
            this.gbPodaci.Padding = new System.Windows.Forms.Padding(4);
            this.gbPodaci.Size = new System.Drawing.Size(476, 202);
            this.gbPodaci.TabIndex = 0;
            this.gbPodaci.TabStop = false;
            this.gbPodaci.Text = "Podaci o osobi:";
            // 
            // tbAdr
            // 
            this.tbAdr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAdr.Location = new System.Drawing.Point(253, 104);
            this.tbAdr.MaxLength = 50;
            this.tbAdr.Multiline = true;
            this.tbAdr.Name = "tbAdr";
            this.tbAdr.Size = new System.Drawing.Size(212, 28);
            this.tbAdr.TabIndex = 9;
            // 
            // btnPonisti
            // 
            this.btnPonisti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPonisti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPonisti.ImageIndex = 2;
            this.btnPonisti.ImageList = this.ilSlike;
            this.btnPonisti.Location = new System.Drawing.Point(253, 138);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(134, 47);
            this.btnPonisti.TabIndex = 11;
            this.btnPonisti.Text = "Ponisti";
            this.btnPonisti.UseVisualStyleBackColor = true;
            this.btnPonisti.Click += new System.EventHandler(this.btnPonisti_Click);
            // 
            // ilSlike
            // 
            this.ilSlike.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilSlike.ImageStream")));
            this.ilSlike.TransparentColor = System.Drawing.Color.Transparent;
            this.ilSlike.Images.SetKeyName(0, "data-delete-database-icon.png");
            this.ilSlike.Images.SetKeyName(1, "Edit.png");
            this.ilSlike.Images.SetKeyName(2, "Eraser-512.png");
            this.ilSlike.Images.SetKeyName(3, "Selection__cursors_delete_cursor-512.png");
            this.ilSlike.Images.SetKeyName(4, "bfa_sort-alpha-asc_flat-rounded-square-white-on-dark-gray_512x512.png");
            // 
            // btnZapamti
            // 
            this.btnZapamti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZapamti.ImageIndex = 1;
            this.btnZapamti.ImageList = this.ilSlike;
            this.btnZapamti.Location = new System.Drawing.Point(95, 138);
            this.btnZapamti.Name = "btnZapamti";
            this.btnZapamti.Size = new System.Drawing.Size(134, 47);
            this.btnZapamti.TabIndex = 10;
            this.btnZapamti.Text = "Zapamti";
            this.btnZapamti.UseVisualStyleBackColor = true;
            this.btnZapamti.Click += new System.EventHandler(this.btnZapamti_Click);
            // 
            // dtDatRodj
            // 
            this.dtDatRodj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDatRodj.CalendarFont = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDatRodj.CustomFormat = "";
            this.dtDatRodj.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDatRodj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDatRodj.Location = new System.Drawing.Point(372, 29);
            this.dtDatRodj.Name = "dtDatRodj";
            this.dtDatRodj.Size = new System.Drawing.Size(93, 22);
            this.dtDatRodj.TabIndex = 7;
            // 
            // tbTel
            // 
            this.tbTel.Location = new System.Drawing.Point(75, 107);
            this.tbTel.MaxLength = 15;
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(154, 28);
            this.tbTel.TabIndex = 5;
            this.tbTel.Leave += new System.EventHandler(this.tbTel_Leave);
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(79, 63);
            this.tbPrezime.MaxLength = 20;
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(150, 28);
            this.tbPrezime.TabIndex = 3;
            this.tbPrezime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrezime_KeyPress);
            this.tbPrezime.Leave += new System.EventHandler(this.tbPrezime_Leave);
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(79, 21);
            this.tbIme.MaxLength = 20;
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(150, 28);
            this.tbIme.TabIndex = 1;
            this.tbIme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIme_KeyPress);
            this.tbIme.Leave += new System.EventHandler(this.tbIme_Leave);
            // 
            // lbAdr
            // 
            this.lbAdr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAdr.AutoSize = true;
            this.lbAdr.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdr.Location = new System.Drawing.Point(249, 66);
            this.lbAdr.Name = "lbAdr";
            this.lbAdr.Size = new System.Drawing.Size(131, 20);
            this.lbAdr.TabIndex = 8;
            this.lbAdr.Text = "Adresa stanovanja:";
            // 
            // lbPrezime
            // 
            this.lbPrezime.AutoSize = true;
            this.lbPrezime.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrezime.Location = new System.Drawing.Point(7, 66);
            this.lbPrezime.Name = "lbPrezime";
            this.lbPrezime.Size = new System.Drawing.Size(66, 20);
            this.lbPrezime.TabIndex = 2;
            this.lbPrezime.Text = "Prezime:";
            // 
            // lbDatRodj
            // 
            this.lbDatRodj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDatRodj.AutoSize = true;
            this.lbDatRodj.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatRodj.Location = new System.Drawing.Point(249, 29);
            this.lbDatRodj.Name = "lbDatRodj";
            this.lbDatRodj.Size = new System.Drawing.Size(117, 20);
            this.lbDatRodj.TabIndex = 6;
            this.lbDatRodj.Text = "Datum rodjenja:";
            // 
            // lbTel
            // 
            this.lbTel.AutoSize = true;
            this.lbTel.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTel.Location = new System.Drawing.Point(10, 107);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(63, 20);
            this.lbTel.TabIndex = 4;
            this.lbTel.Text = "Telefon:";
            // 
            // lbIme
            // 
            this.lbIme.AutoSize = true;
            this.lbIme.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIme.Location = new System.Drawing.Point(34, 29);
            this.lbIme.Name = "lbIme";
            this.lbIme.Size = new System.Drawing.Size(39, 20);
            this.lbIme.TabIndex = 0;
            this.lbIme.Text = "Ime:";
            // 
            // lbListaO
            // 
            this.lbListaO.AutoSize = true;
            this.lbListaO.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListaO.Location = new System.Drawing.Point(184, 221);
            this.lbListaO.Name = "lbListaO";
            this.lbListaO.Size = new System.Drawing.Size(123, 27);
            this.lbListaO.TabIndex = 1;
            this.lbListaO.Text = "Lista osoba:";
            // 
            // lbListaOsoba
            // 
            this.lbListaOsoba.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbListaOsoba.FormattingEnabled = true;
            this.lbListaOsoba.ItemHeight = 16;
            this.lbListaOsoba.Location = new System.Drawing.Point(18, 253);
            this.lbListaOsoba.Name = "lbListaOsoba";
            this.lbListaOsoba.Size = new System.Drawing.Size(476, 164);
            this.lbListaOsoba.TabIndex = 2;
            this.lbListaOsoba.DoubleClick += new System.EventHandler(this.lbListaOsoba_DoubleClick);
            // 
            // btnObrisiosobu
            // 
            this.btnObrisiosobu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiosobu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObrisiosobu.ImageIndex = 3;
            this.btnObrisiosobu.ImageList = this.ilSlike;
            this.btnObrisiosobu.Location = new System.Drawing.Point(18, 423);
            this.btnObrisiosobu.Name = "btnObrisiosobu";
            this.btnObrisiosobu.Size = new System.Drawing.Size(109, 64);
            this.btnObrisiosobu.TabIndex = 3;
            this.btnObrisiosobu.Text = "Obrisi izabranu osobu";
            this.btnObrisiosobu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnObrisiosobu.UseVisualStyleBackColor = true;
            this.btnObrisiosobu.Click += new System.EventHandler(this.btnObrisiosobu_Click);
            // 
            // btnObrisilistu
            // 
            this.btnObrisilistu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisilistu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObrisilistu.ImageIndex = 0;
            this.btnObrisilistu.ImageList = this.ilSlike;
            this.btnObrisilistu.Location = new System.Drawing.Point(133, 423);
            this.btnObrisilistu.Name = "btnObrisilistu";
            this.btnObrisilistu.Size = new System.Drawing.Size(109, 64);
            this.btnObrisilistu.TabIndex = 4;
            this.btnObrisilistu.Text = "Obrisi \r\ncelu listu";
            this.btnObrisilistu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnObrisilistu.UseVisualStyleBackColor = true;
            this.btnObrisilistu.Click += new System.EventHandler(this.btnObrisilistu_Click);
            // 
            // btnSort
            // 
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSort.ImageIndex = 4;
            this.btnSort.ImageList = this.ilSlike;
            this.btnSort.Location = new System.Drawing.Point(248, 423);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(101, 64);
            this.btnSort.TabIndex = 5;
            this.btnSort.Text = "Sortiraj";
            this.btnSort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // cbSort
            // 
            this.cbSort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Location = new System.Drawing.Point(355, 443);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(139, 24);
            this.cbSort.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(510, 519);
            this.Controls.Add(this.cbSort);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnObrisilistu);
            this.Controls.Add(this.btnObrisiosobu);
            this.Controls.Add(this.lbListaOsoba);
            this.Controls.Add(this.lbListaO);
            this.Controls.Add(this.gbPodaci);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(526, 557);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(526, 557);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OOProjektovanje - 1. Lab";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.gbPodaci.ResumeLayout(false);
            this.gbPodaci.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPodaci;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Label lbAdr;
        private System.Windows.Forms.Label lbPrezime;
        private System.Windows.Forms.Label lbDatRodj;
        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.Label lbIme;
        private System.Windows.Forms.DateTimePicker dtDatRodj;
        private System.Windows.Forms.Button btnPonisti;
        private System.Windows.Forms.Button btnZapamti;
        private System.Windows.Forms.TextBox tbAdr;
        private System.Windows.Forms.ImageList ilSlike;
        private System.Windows.Forms.Label lbListaO;
        private System.Windows.Forms.ListBox lbListaOsoba;
        private System.Windows.Forms.Button btnObrisiosobu;
        private System.Windows.Forms.Button btnObrisilistu;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ComboBox cbSort;
    }
}

