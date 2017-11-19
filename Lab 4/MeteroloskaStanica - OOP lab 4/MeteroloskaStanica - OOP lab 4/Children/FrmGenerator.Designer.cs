namespace MeteroloskaStanica___OOP_lab_4.Children
{
    partial class FrmGenerator
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
            this.lbTemperature = new System.Windows.Forms.Label();
            this.lbPressure = new System.Windows.Forms.Label();
            this.lbAirHumidity = new System.Windows.Forms.Label();
            this.tbTemperature = new System.Windows.Forms.TextBox();
            this.tbAirHumidity = new System.Windows.Forms.TextBox();
            this.tbPressure = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnPress = new System.Windows.Forms.Button();
            this.btnairh = new System.Windows.Forms.Button();
            this.btnTemp = new System.Windows.Forms.Button();
            this.cbIgnore = new System.Windows.Forms.CheckBox();
            this.cbGeninSec = new System.Windows.Forms.CheckBox();
            this.tbSecounds = new System.Windows.Forms.TextBox();
            this.tmGen = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbTemperature
            // 
            this.lbTemperature.AutoSize = true;
            this.lbTemperature.Location = new System.Drawing.Point(37, 46);
            this.lbTemperature.Name = "lbTemperature";
            this.lbTemperature.Size = new System.Drawing.Size(70, 13);
            this.lbTemperature.TabIndex = 0;
            this.lbTemperature.Text = "Temperature:";
            // 
            // lbPressure
            // 
            this.lbPressure.AutoSize = true;
            this.lbPressure.Location = new System.Drawing.Point(56, 81);
            this.lbPressure.Name = "lbPressure";
            this.lbPressure.Size = new System.Drawing.Size(51, 13);
            this.lbPressure.TabIndex = 1;
            this.lbPressure.Text = "Pressure:";
            // 
            // lbAirHumidity
            // 
            this.lbAirHumidity.AutoSize = true;
            this.lbAirHumidity.Location = new System.Drawing.Point(45, 119);
            this.lbAirHumidity.Name = "lbAirHumidity";
            this.lbAirHumidity.Size = new System.Drawing.Size(62, 13);
            this.lbAirHumidity.TabIndex = 2;
            this.lbAirHumidity.Text = "Air Humidity";
            // 
            // tbTemperature
            // 
            this.tbTemperature.Location = new System.Drawing.Point(113, 43);
            this.tbTemperature.Name = "tbTemperature";
            this.tbTemperature.Size = new System.Drawing.Size(240, 20);
            this.tbTemperature.TabIndex = 3;
            this.tbTemperature.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTemperature_KeyPress);
            // 
            // tbAirHumidity
            // 
            this.tbAirHumidity.Location = new System.Drawing.Point(113, 116);
            this.tbAirHumidity.Name = "tbAirHumidity";
            this.tbAirHumidity.Size = new System.Drawing.Size(240, 20);
            this.tbAirHumidity.TabIndex = 4;
            this.tbAirHumidity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTemperature_KeyPress);
            // 
            // tbPressure
            // 
            this.tbPressure.Location = new System.Drawing.Point(113, 78);
            this.tbPressure.Name = "tbPressure";
            this.tbPressure.Size = new System.Drawing.Size(240, 20);
            this.tbPressure.TabIndex = 5;
            this.tbPressure.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTemperature_KeyPress);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(179, 142);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(213, 77);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnPress
            // 
            this.btnPress.Location = new System.Drawing.Point(359, 76);
            this.btnPress.Name = "btnPress";
            this.btnPress.Size = new System.Drawing.Size(33, 23);
            this.btnPress.TabIndex = 7;
            this.btnPress.Text = "*";
            this.btnPress.UseVisualStyleBackColor = true;
            this.btnPress.Click += new System.EventHandler(this.btnTemp_Click);
            // 
            // btnairh
            // 
            this.btnairh.Location = new System.Drawing.Point(359, 114);
            this.btnairh.Name = "btnairh";
            this.btnairh.Size = new System.Drawing.Size(33, 23);
            this.btnairh.TabIndex = 8;
            this.btnairh.Text = "*";
            this.btnairh.UseVisualStyleBackColor = true;
            this.btnairh.Click += new System.EventHandler(this.btnTemp_Click);
            // 
            // btnTemp
            // 
            this.btnTemp.Location = new System.Drawing.Point(359, 40);
            this.btnTemp.Name = "btnTemp";
            this.btnTemp.Size = new System.Drawing.Size(33, 23);
            this.btnTemp.TabIndex = 9;
            this.btnTemp.Text = "*";
            this.btnTemp.UseVisualStyleBackColor = true;
            this.btnTemp.Click += new System.EventHandler(this.btnTemp_Click);
            // 
            // cbIgnore
            // 
            this.cbIgnore.AutoSize = true;
            this.cbIgnore.Location = new System.Drawing.Point(13, 280);
            this.cbIgnore.Name = "cbIgnore";
            this.cbIgnore.Size = new System.Drawing.Size(94, 17);
            this.cbIgnore.TabIndex = 10;
            this.cbIgnore.Text = "Ignore bounds";
            this.cbIgnore.UseVisualStyleBackColor = true;
            // 
            // cbGeninSec
            // 
            this.cbGeninSec.AutoSize = true;
            this.cbGeninSec.Location = new System.Drawing.Point(13, 319);
            this.cbGeninSec.Name = "cbGeninSec";
            this.cbGeninSec.Size = new System.Drawing.Size(198, 17);
            this.cbGeninSec.TabIndex = 11;
            this.cbGeninSec.Text = "Generate data. Interval in secounds:";
            this.cbGeninSec.UseVisualStyleBackColor = true;
            // 
            // tbSecounds
            // 
            this.tbSecounds.Location = new System.Drawing.Point(217, 316);
            this.tbSecounds.Name = "tbSecounds";
            this.tbSecounds.Size = new System.Drawing.Size(29, 20);
            this.tbSecounds.TabIndex = 12;
            // 
            // tmGen
            // 
            this.tmGen.Interval = 1000;
            this.tmGen.Tick += new System.EventHandler(this.tmGen_Tick);
            // 
            // FrmGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 348);
            this.Controls.Add(this.tbSecounds);
            this.Controls.Add(this.cbGeninSec);
            this.Controls.Add(this.cbIgnore);
            this.Controls.Add(this.btnTemp);
            this.Controls.Add(this.btnairh);
            this.Controls.Add(this.btnPress);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbPressure);
            this.Controls.Add(this.tbAirHumidity);
            this.Controls.Add(this.tbTemperature);
            this.Controls.Add(this.lbAirHumidity);
            this.Controls.Add(this.lbPressure);
            this.Controls.Add(this.lbTemperature);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGenerator";
            this.Text = "Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGenerator_FormClosing);
            this.Load += new System.EventHandler(this.FrmGenerator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTemperature;
        private System.Windows.Forms.Label lbPressure;
        private System.Windows.Forms.Label lbAirHumidity;
        private System.Windows.Forms.TextBox tbTemperature;
        private System.Windows.Forms.TextBox tbAirHumidity;
        private System.Windows.Forms.TextBox tbPressure;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnPress;
        private System.Windows.Forms.Button btnairh;
        private System.Windows.Forms.Button btnTemp;
        private System.Windows.Forms.CheckBox cbIgnore;
        private System.Windows.Forms.CheckBox cbGeninSec;
        private System.Windows.Forms.TextBox tbSecounds;
        private System.Windows.Forms.Timer tmGen;
    }
}