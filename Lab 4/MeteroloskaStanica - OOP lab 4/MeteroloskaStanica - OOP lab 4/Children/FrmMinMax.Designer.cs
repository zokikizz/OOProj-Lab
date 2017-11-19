namespace MeteroloskaStanica___OOP_lab_4.Children
{
    partial class FrmMinMax
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
            this.btnChange = new System.Windows.Forms.Button();
            this.lbMin = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.Label();
            this.tbMin = new System.Windows.Forms.TextBox();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(74, 65);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 0;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // lbMin
            // 
            this.lbMin.AutoSize = true;
            this.lbMin.Location = new System.Drawing.Point(13, 13);
            this.lbMin.Name = "lbMin";
            this.lbMin.Size = new System.Drawing.Size(27, 13);
            this.lbMin.TabIndex = 1;
            this.lbMin.Text = "Min:";
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Location = new System.Drawing.Point(13, 42);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(30, 13);
            this.t.TabIndex = 2;
            this.t.Text = "Max:";
            // 
            // tbMin
            // 
            this.tbMin.Location = new System.Drawing.Point(49, 10);
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(100, 20);
            this.tbMin.TabIndex = 3;
            this.tbMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMin_KeyPress);
            // 
            // tbMax
            // 
            this.tbMax.Location = new System.Drawing.Point(49, 39);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(100, 20);
            this.tbMax.TabIndex = 4;
            // 
            // FrmMinMax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 99);
            this.Controls.Add(this.tbMax);
            this.Controls.Add(this.tbMin);
            this.Controls.Add(this.t);
            this.Controls.Add(this.lbMin);
            this.Controls.Add(this.btnChange);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMinMax";
            this.Text = "FrmMinMax";
            this.Load += new System.EventHandler(this.FrmMinMax_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label lbMin;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.TextBox tbMin;
        private System.Windows.Forms.TextBox tbMax;
    }
}