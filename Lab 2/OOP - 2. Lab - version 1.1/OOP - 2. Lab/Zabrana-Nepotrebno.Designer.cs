namespace OOP___2.Lab
{
    partial class Zabrana
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
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnProsledi = new System.Windows.Forms.Button();
            this.dpDo = new System.Windows.Forms.DateTimePicker();
            this.dpOd = new System.Windows.Forms.DateTimePicker();
            this.cbZabrana = new System.Windows.Forms.ComboBox();
            this.lbDatumDo = new System.Windows.Forms.Label();
            this.lbDatumOd = new System.Windows.Forms.Label();
            this.lbZabrana = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(160, 140);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 15;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            // 
            // btnProsledi
            // 
            this.btnProsledi.Location = new System.Drawing.Point(54, 140);
            this.btnProsledi.Name = "btnProsledi";
            this.btnProsledi.Size = new System.Drawing.Size(75, 23);
            this.btnProsledi.TabIndex = 14;
            this.btnProsledi.Text = "Prosledi";
            this.btnProsledi.UseVisualStyleBackColor = true;
            // 
            // dpDo
            // 
            this.dpDo.CustomFormat = "dd.MM.yyyy";
            this.dpDo.Location = new System.Drawing.Point(113, 96);
            this.dpDo.Name = "dpDo";
            this.dpDo.Size = new System.Drawing.Size(121, 20);
            this.dpDo.TabIndex = 13;
            // 
            // dpOd
            // 
            this.dpOd.CustomFormat = "dd.MM.yyyy";
            this.dpOd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dpOd.Location = new System.Drawing.Point(112, 56);
            this.dpOd.Name = "dpOd";
            this.dpOd.Size = new System.Drawing.Size(121, 20);
            this.dpOd.TabIndex = 12;
            // 
            // cbZabrana
            // 
            this.cbZabrana.FormattingEnabled = true;
            this.cbZabrana.Location = new System.Drawing.Point(113, 19);
            this.cbZabrana.Name = "cbZabrana";
            this.cbZabrana.Size = new System.Drawing.Size(121, 21);
            this.cbZabrana.TabIndex = 11;
            // 
            // lbDatumDo
            // 
            this.lbDatumDo.AutoSize = true;
            this.lbDatumDo.Location = new System.Drawing.Point(51, 102);
            this.lbDatumDo.Name = "lbDatumDo";
            this.lbDatumDo.Size = new System.Drawing.Size(56, 13);
            this.lbDatumDo.TabIndex = 10;
            this.lbDatumDo.Text = "Datum do:";
            // 
            // lbDatumOd
            // 
            this.lbDatumOd.AutoSize = true;
            this.lbDatumOd.Location = new System.Drawing.Point(50, 62);
            this.lbDatumOd.Name = "lbDatumOd";
            this.lbDatumOd.Size = new System.Drawing.Size(56, 13);
            this.lbDatumOd.TabIndex = 9;
            this.lbDatumOd.Text = "Datum od:";
            // 
            // lbZabrana
            // 
            this.lbZabrana.AutoSize = true;
            this.lbZabrana.Location = new System.Drawing.Point(50, 22);
            this.lbZabrana.Name = "lbZabrana";
            this.lbZabrana.Size = new System.Drawing.Size(50, 13);
            this.lbZabrana.TabIndex = 8;
            this.lbZabrana.Text = "Zabrana:";
            // 
            // Zabrana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(285, 182);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnProsledi);
            this.Controls.Add(this.dpDo);
            this.Controls.Add(this.dpOd);
            this.Controls.Add(this.cbZabrana);
            this.Controls.Add(this.lbDatumDo);
            this.Controls.Add(this.lbDatumOd);
            this.Controls.Add(this.lbZabrana);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Zabrana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zabrana";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnProsledi;
        private System.Windows.Forms.DateTimePicker dpDo;
        private System.Windows.Forms.DateTimePicker dpOd;
        private System.Windows.Forms.ComboBox cbZabrana;
        private System.Windows.Forms.Label lbDatumDo;
        private System.Windows.Forms.Label lbDatumOd;
        private System.Windows.Forms.Label lbZabrana;
    }
}