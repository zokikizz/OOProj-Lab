namespace MeteroloskaStanica___OOP_lab_4
{
    partial class FrmMain
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
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.newFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generatorFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartTempToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartPritisakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartVlaznostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFormToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(726, 24);
            this.msMenu.TabIndex = 1;
            this.msMenu.Text = "msMenu";
            // 
            // newFormToolStripMenuItem
            // 
            this.newFormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generatorFormToolStripMenuItem,
            this.chartTempToolStripMenuItem,
            this.chartPritisakToolStripMenuItem,
            this.chartVlaznostToolStripMenuItem,
            this.statistikaToolStripMenuItem});
            this.newFormToolStripMenuItem.Name = "newFormToolStripMenuItem";
            this.newFormToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.newFormToolStripMenuItem.Text = "New Form";
            // 
            // generatorFormToolStripMenuItem
            // 
            this.generatorFormToolStripMenuItem.Name = "generatorFormToolStripMenuItem";
            this.generatorFormToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.generatorFormToolStripMenuItem.Text = "Generator Form";
            this.generatorFormToolStripMenuItem.Click += new System.EventHandler(this.generatorFormToolStripMenuItem_Click);
            // 
            // chartTempToolStripMenuItem
            // 
            this.chartTempToolStripMenuItem.Name = "chartTempToolStripMenuItem";
            this.chartTempToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.chartTempToolStripMenuItem.Text = "Chart Temp";
            this.chartTempToolStripMenuItem.Click += new System.EventHandler(this.chartTempToolStripMenuItem_Click);
            // 
            // chartPritisakToolStripMenuItem
            // 
            this.chartPritisakToolStripMenuItem.Name = "chartPritisakToolStripMenuItem";
            this.chartPritisakToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.chartPritisakToolStripMenuItem.Text = "Chart Pritisak";
            this.chartPritisakToolStripMenuItem.Click += new System.EventHandler(this.chartPritisakToolStripMenuItem_Click);
            // 
            // chartVlaznostToolStripMenuItem
            // 
            this.chartVlaznostToolStripMenuItem.Name = "chartVlaznostToolStripMenuItem";
            this.chartVlaznostToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.chartVlaznostToolStripMenuItem.Text = "Chart Vlaznost";
            this.chartVlaznostToolStripMenuItem.Click += new System.EventHandler(this.chartVlaznostToolStripMenuItem_Click);
            // 
            // statistikaToolStripMenuItem
            // 
            this.statistikaToolStripMenuItem.Name = "statistikaToolStripMenuItem";
            this.statistikaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.statistikaToolStripMenuItem.Text = "Statistika";
            this.statistikaToolStripMenuItem.Click += new System.EventHandler(this.statistikaToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 388);
            this.Controls.Add(this.msMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMenu;
            this.Name = "FrmMain";
            this.Text = "Meteroloska stanica";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem newFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generatorFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartTempToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartPritisakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartVlaznostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistikaToolStripMenuItem;
    }
}

