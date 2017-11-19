namespace MeteroloskaStanica___OOP_lab_4.Children
{
    partial class FrmChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // chGraph
            // 
            chartArea2.Name = "ChartArea1";
            this.chGraph.ChartAreas.Add(chartArea2);
            this.chGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chGraph.Legends.Add(legend2);
            this.chGraph.Location = new System.Drawing.Point(0, 0);
            this.chGraph.Name = "chGraph";
            this.chGraph.Size = new System.Drawing.Size(397, 355);
            this.chGraph.TabIndex = 0;
            this.chGraph.Text = "chGraph";
            // 
            // FrmChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 355);
            this.Controls.Add(this.chGraph);
            this.Name = "FrmChart";
            this.Text = "FrmChart";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmChart_FormClosing);
            this.Load += new System.EventHandler(this.FrmChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chGraph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chGraph;
    }
}