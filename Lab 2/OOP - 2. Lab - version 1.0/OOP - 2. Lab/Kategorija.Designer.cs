namespace OOP___2.Lab
{
    partial class Kategorija
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
            this.lbKategorija = new System.Windows.Forms.Label();
            this.lbDatumOd = new System.Windows.Forms.Label();
            this.lbDatumDo = new System.Windows.Forms.Label();
            this.cbKategorija = new System.Windows.Forms.ComboBox();
            this.dpOd = new System.Windows.Forms.DateTimePicker();
            this.dpDo = new System.Windows.Forms.DateTimePicker();
            this.btnProsledi = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbKategorija
            // 
            this.lbKategorija.AutoSize = true;
            this.lbKategorija.Location = new System.Drawing.Point(46, 29);
            this.lbKategorija.Name = "lbKategorija";
            this.lbKategorija.Size = new System.Drawing.Size(57, 13);
            this.lbKategorija.TabIndex = 0;
            this.lbKategorija.Text = "Kategorija:";
            // 
            // lbDatumOd
            // 
            this.lbDatumOd.AutoSize = true;
            this.lbDatumOd.Location = new System.Drawing.Point(46, 69);
            this.lbDatumOd.Name = "lbDatumOd";
            this.lbDatumOd.Size = new System.Drawing.Size(56, 13);
            this.lbDatumOd.TabIndex = 1;
            this.lbDatumOd.Text = "Datum od:";
            // 
            // lbDatumDo
            // 
            this.lbDatumDo.AutoSize = true;
            this.lbDatumDo.Location = new System.Drawing.Point(47, 109);
            this.lbDatumDo.Name = "lbDatumDo";
            this.lbDatumDo.Size = new System.Drawing.Size(56, 13);
            this.lbDatumDo.TabIndex = 2;
            this.lbDatumDo.Text = "Datum do:";
            // 
            // cbKategorija
            // 
            this.cbKategorija.FormattingEnabled = true;
            this.cbKategorija.Location = new System.Drawing.Point(109, 26);
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Size = new System.Drawing.Size(121, 21);
            this.cbKategorija.TabIndex = 3;
            // 
            // dpOd
            // 
            this.dpOd.CustomFormat = "";
            this.dpOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpOd.Location = new System.Drawing.Point(108, 63);
            this.dpOd.Name = "dpOd";
            this.dpOd.Size = new System.Drawing.Size(121, 20);
            this.dpOd.TabIndex = 4;
            // 
            // dpDo
            // 
            this.dpDo.CustomFormat = "dd.MM.yyyy";
            this.dpDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpDo.Location = new System.Drawing.Point(109, 103);
            this.dpDo.Name = "dpDo";
            this.dpDo.Size = new System.Drawing.Size(121, 20);
            this.dpDo.TabIndex = 5;
            // 
            // btnProsledi
            // 
            this.btnProsledi.Location = new System.Drawing.Point(50, 147);
            this.btnProsledi.Name = "btnProsledi";
            this.btnProsledi.Size = new System.Drawing.Size(75, 23);
            this.btnProsledi.TabIndex = 6;
            this.btnProsledi.Text = "Prosledi";
            this.btnProsledi.UseVisualStyleBackColor = true;
            this.btnProsledi.Click += new System.EventHandler(this.btnProsledi_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(156, 147);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 7;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // Kategorija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(285, 182);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnProsledi);
            this.Controls.Add(this.dpDo);
            this.Controls.Add(this.dpOd);
            this.Controls.Add(this.cbKategorija);
            this.Controls.Add(this.lbDatumDo);
            this.Controls.Add(this.lbDatumOd);
            this.Controls.Add(this.lbKategorija);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Kategorija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategorija";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Kategorija_FormClosing);
            this.Load += new System.EventHandler(this.Kategorija_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbKategorija;
        private System.Windows.Forms.Label lbDatumOd;
        private System.Windows.Forms.Label lbDatumDo;
        private System.Windows.Forms.ComboBox cbKategorija;
        private System.Windows.Forms.DateTimePicker dpOd;
        private System.Windows.Forms.DateTimePicker dpDo;
        private System.Windows.Forms.Button btnProsledi;
        private System.Windows.Forms.Button btnZatvori;
    }
}