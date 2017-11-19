namespace MineSweeper
{
    partial class frmCostumGame
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
            this.tbi = new System.Windows.Forms.TextBox();
            this.tbj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbmine = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbi
            // 
            this.tbi.Location = new System.Drawing.Point(70, 20);
            this.tbi.MaxLength = 12;
            this.tbi.Name = "tbi";
            this.tbi.Size = new System.Drawing.Size(41, 20);
            this.tbi.TabIndex = 0;
            this.tbi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbi_KeyPress);
            // 
            // tbj
            // 
            this.tbj.Location = new System.Drawing.Point(135, 20);
            this.tbj.MaxLength = 12;
            this.tbj.Name = "tbj";
            this.tbj.Size = new System.Drawing.Size(41, 20);
            this.tbj.TabIndex = 1;
            this.tbj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbi_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fild:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mine:";
            // 
            // tbmine
            // 
            this.tbmine.Location = new System.Drawing.Point(70, 61);
            this.tbmine.Name = "tbmine";
            this.tbmine.Size = new System.Drawing.Size(41, 20);
            this.tbmine.TabIndex = 5;
            this.tbmine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbi_KeyPress);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(120, 59);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(56, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.tbi);
            this.panel1.Controls.Add(this.tbmine);
            this.panel1.Controls.Add(this.tbj);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 101);
            this.panel1.TabIndex = 7;
            // 
            // frmCostumGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 101);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCostumGame";
            this.Text = "CostumGame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCostumGame_FormClosing);
            this.Load += new System.EventHandler(this.frmCostumGame_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbi;
        private System.Windows.Forms.TextBox tbj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbmine;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panel1;
    }
}