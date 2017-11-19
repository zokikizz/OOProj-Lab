namespace OOP___2.Lab
{
    partial class Lista_vozaca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista_vozaca));
            this.lbTime = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.btnDodajVozaca = new System.Windows.Forms.Button();
            this.imlsIcons = new System.Windows.Forms.ImageList(this.components);
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisiVozaca = new System.Windows.Forms.Button();
            this.gbListaVozaca = new System.Windows.Forms.GroupBox();
            this.dgvVozaci = new System.Windows.Forms.DataGridView();
            this.gbListaVozaca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozaci)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(12, 13);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(35, 13);
            this.lbTime.TabIndex = 0;
            this.lbTime.Text = "label1";
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(199, 8);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 28);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "Sortiraj po:";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // cbSort
            // 
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Location = new System.Drawing.Point(280, 10);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(143, 21);
            this.cbSort.TabIndex = 3;
            // 
            // btnDodajVozaca
            // 
            this.btnDodajVozaca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajVozaca.ImageKey = "Plus-icon.png";
            this.btnDodajVozaca.ImageList = this.imlsIcons;
            this.btnDodajVozaca.Location = new System.Drawing.Point(15, 249);
            this.btnDodajVozaca.Name = "btnDodajVozaca";
            this.btnDodajVozaca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDodajVozaca.Size = new System.Drawing.Size(75, 38);
            this.btnDodajVozaca.TabIndex = 4;
            this.btnDodajVozaca.Text = "Dodaj vozaca";
            this.btnDodajVozaca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDodajVozaca.UseVisualStyleBackColor = true;
            this.btnDodajVozaca.Click += new System.EventHandler(this.btnDodajVozaca_Click);
            // 
            // imlsIcons
            // 
            this.imlsIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlsIcons.ImageStream")));
            this.imlsIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imlsIcons.Images.SetKeyName(0, "Pencil-icon.png");
            this.imlsIcons.Images.SetKeyName(1, "Plus-icon.png");
            this.imlsIcons.Images.SetKeyName(2, "Science-Minus-Math-icon.png");
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIzmeni.ImageIndex = 0;
            this.btnIzmeni.ImageList = this.imlsIcons;
            this.btnIzmeni.Location = new System.Drawing.Point(96, 249);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(75, 38);
            this.btnIzmeni.TabIndex = 5;
            this.btnIzmeni.Text = "Izmeni vozaca";
            this.btnIzmeni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnObrisiVozaca
            // 
            this.btnObrisiVozaca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObrisiVozaca.ImageKey = "Science-Minus-Math-icon.png";
            this.btnObrisiVozaca.ImageList = this.imlsIcons;
            this.btnObrisiVozaca.Location = new System.Drawing.Point(348, 246);
            this.btnObrisiVozaca.Name = "btnObrisiVozaca";
            this.btnObrisiVozaca.Size = new System.Drawing.Size(75, 38);
            this.btnObrisiVozaca.TabIndex = 6;
            this.btnObrisiVozaca.Text = "Obrisi vozaca";
            this.btnObrisiVozaca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnObrisiVozaca.UseVisualStyleBackColor = true;
            this.btnObrisiVozaca.Click += new System.EventHandler(this.btnObrisiVozaca_Click);
            // 
            // gbListaVozaca
            // 
            this.gbListaVozaca.Controls.Add(this.dgvVozaci);
            this.gbListaVozaca.Location = new System.Drawing.Point(12, 37);
            this.gbListaVozaca.Name = "gbListaVozaca";
            this.gbListaVozaca.Size = new System.Drawing.Size(414, 206);
            this.gbListaVozaca.TabIndex = 7;
            this.gbListaVozaca.TabStop = false;
            this.gbListaVozaca.Text = "Lista vozaca:";
            // 
            // dgvVozaci
            // 
            this.dgvVozaci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVozaci.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvVozaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVozaci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVozaci.Location = new System.Drawing.Point(3, 16);
            this.dgvVozaci.Name = "dgvVozaci";
            this.dgvVozaci.Size = new System.Drawing.Size(408, 187);
            this.dgvVozaci.TabIndex = 0;
            // 
            // Lista_vozaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(438, 299);
            this.Controls.Add(this.gbListaVozaca);
            this.Controls.Add(this.btnObrisiVozaca);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnDodajVozaca);
            this.Controls.Add(this.cbSort);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.lbTime);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(454, 337);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(454, 337);
            this.Name = "Lista_vozaca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista vozaca";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Lista_vozaca_FormClosing);
            this.Load += new System.EventHandler(this.Lista_vozaca_Load);
            this.gbListaVozaca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozaci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.Button btnDodajVozaca;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisiVozaca;
        private System.Windows.Forms.ImageList imlsIcons;
        private System.Windows.Forms.GroupBox gbListaVozaca;
        private System.Windows.Forms.DataGridView dgvVozaci;
    }
}

