namespace MeteroloskaStanica___OOP_lab_4.Children
{
    partial class Statistic
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
            this.lbTmp = new System.Windows.Forms.Label();
            this.lbPress = new System.Windows.Forms.Label();
            this.lbAirH = new System.Windows.Forms.Label();
            this.lbTemperature = new System.Windows.Forms.Label();
            this.lbPressure = new System.Windows.Forms.Label();
            this.lbAirHi = new System.Windows.Forms.Label();
            this.tbTemp = new System.Windows.Forms.TextBox();
            this.tbPress = new System.Windows.Forms.TextBox();
            this.tbAH = new System.Windows.Forms.TextBox();
            this.cbStat = new System.Windows.Forms.CheckBox();
            this.tbNo = new System.Windows.Forms.TextBox();
            this.lbNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTmp
            // 
            this.lbTmp.AutoSize = true;
            this.lbTmp.Location = new System.Drawing.Point(13, 13);
            this.lbTmp.Name = "lbTmp";
            this.lbTmp.Size = new System.Drawing.Size(70, 13);
            this.lbTmp.TabIndex = 0;
            this.lbTmp.Text = "Temperature:";
            // 
            // lbPress
            // 
            this.lbPress.AutoSize = true;
            this.lbPress.Location = new System.Drawing.Point(13, 38);
            this.lbPress.Name = "lbPress";
            this.lbPress.Size = new System.Drawing.Size(51, 13);
            this.lbPress.TabIndex = 1;
            this.lbPress.Text = "Pressure:";
            // 
            // lbAirH
            // 
            this.lbAirH.AutoSize = true;
            this.lbAirH.Location = new System.Drawing.Point(13, 63);
            this.lbAirH.Name = "lbAirH";
            this.lbAirH.Size = new System.Drawing.Size(33, 13);
            this.lbAirH.TabIndex = 2;
            this.lbAirH.Text = "Ari H:";
            // 
            // lbTemperature
            // 
            this.lbTemperature.AutoSize = true;
            this.lbTemperature.Location = new System.Drawing.Point(177, 13);
            this.lbTemperature.Name = "lbTemperature";
            this.lbTemperature.Size = new System.Drawing.Size(75, 13);
            this.lbTemperature.TabIndex = 4;
            this.lbTemperature.Text = "lbTemperature";
            this.lbTemperature.Visible = false;
            // 
            // lbPressure
            // 
            this.lbPressure.AutoSize = true;
            this.lbPressure.Location = new System.Drawing.Point(177, 38);
            this.lbPressure.Name = "lbPressure";
            this.lbPressure.Size = new System.Drawing.Size(56, 13);
            this.lbPressure.TabIndex = 5;
            this.lbPressure.Text = "lbPressure";
            this.lbPressure.Visible = false;
            // 
            // lbAirHi
            // 
            this.lbAirHi.AutoSize = true;
            this.lbAirHi.Location = new System.Drawing.Point(177, 63);
            this.lbAirHi.Name = "lbAirHi";
            this.lbAirHi.Size = new System.Drawing.Size(35, 13);
            this.lbAirHi.TabIndex = 6;
            this.lbAirHi.Text = "lbAirH";
            this.lbAirHi.Visible = false;
            // 
            // tbTemp
            // 
            this.tbTemp.Location = new System.Drawing.Point(88, 10);
            this.tbTemp.Name = "tbTemp";
            this.tbTemp.Size = new System.Drawing.Size(70, 20);
            this.tbTemp.TabIndex = 7;
            // 
            // tbPress
            // 
            this.tbPress.Location = new System.Drawing.Point(88, 35);
            this.tbPress.Name = "tbPress";
            this.tbPress.Size = new System.Drawing.Size(70, 20);
            this.tbPress.TabIndex = 8;
            // 
            // tbAH
            // 
            this.tbAH.Location = new System.Drawing.Point(88, 60);
            this.tbAH.Name = "tbAH";
            this.tbAH.Size = new System.Drawing.Size(70, 20);
            this.tbAH.TabIndex = 9;
            // 
            // cbStat
            // 
            this.cbStat.AutoSize = true;
            this.cbStat.Location = new System.Drawing.Point(16, 148);
            this.cbStat.Name = "cbStat";
            this.cbStat.Size = new System.Drawing.Size(128, 17);
            this.cbStat.TabIndex = 10;
            this.cbStat.Text = "Statistika za poslenja:";
            this.cbStat.UseVisualStyleBackColor = true;
            this.cbStat.CheckedChanged += new System.EventHandler(this.cbStat_CheckedChanged);
            // 
            // tbNo
            // 
            this.tbNo.Location = new System.Drawing.Point(150, 146);
            this.tbNo.Name = "tbNo";
            this.tbNo.Size = new System.Drawing.Size(43, 20);
            this.tbNo.TabIndex = 11;
            // 
            // lbNo
            // 
            this.lbNo.AutoSize = true;
            this.lbNo.Location = new System.Drawing.Point(199, 146);
            this.lbNo.Name = "lbNo";
            this.lbNo.Size = new System.Drawing.Size(29, 13);
            this.lbNo.TabIndex = 12;
            this.lbNo.Text = "lbNo";
            this.lbNo.Visible = false;
            // 
            // Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 178);
            this.Controls.Add(this.lbNo);
            this.Controls.Add(this.tbNo);
            this.Controls.Add(this.cbStat);
            this.Controls.Add(this.tbAH);
            this.Controls.Add(this.tbPress);
            this.Controls.Add(this.tbTemp);
            this.Controls.Add(this.lbAirHi);
            this.Controls.Add(this.lbPressure);
            this.Controls.Add(this.lbTemperature);
            this.Controls.Add(this.lbAirH);
            this.Controls.Add(this.lbPress);
            this.Controls.Add(this.lbTmp);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Statistic";
            this.Text = "Statistic";
            this.Load += new System.EventHandler(this.Statistic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTmp;
        private System.Windows.Forms.Label lbPress;
        private System.Windows.Forms.Label lbAirH;
        private System.Windows.Forms.Label lbTemperature;
        private System.Windows.Forms.Label lbPressure;
        private System.Windows.Forms.Label lbAirHi;
        private System.Windows.Forms.TextBox tbTemp;
        private System.Windows.Forms.TextBox tbPress;
        private System.Windows.Forms.TextBox tbAH;
        private System.Windows.Forms.CheckBox cbStat;
        private System.Windows.Forms.TextBox tbNo;
        private System.Windows.Forms.Label lbNo;
    }
}