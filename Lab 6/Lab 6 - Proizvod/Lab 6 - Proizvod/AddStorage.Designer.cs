namespace Lab_6___Proizvod
{
    partial class AddStorage
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbCode = new System.Windows.Forms.Label();
            this.lbCapacityInPieces = new System.Windows.Forms.Label();
            this.lbCapcityInWeight = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.tbCapacityInPieces = new System.Windows.Forms.TextBox();
            this.tbCapacityInWeight = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(13, 13);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(38, 13);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name:";
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Location = new System.Drawing.Point(12, 43);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(35, 13);
            this.lbCode.TabIndex = 1;
            this.lbCode.Text = "Code:";
            // 
            // lbCapacityInPieces
            // 
            this.lbCapacityInPieces.AutoSize = true;
            this.lbCapacityInPieces.Location = new System.Drawing.Point(12, 73);
            this.lbCapacityInPieces.Name = "lbCapacityInPieces";
            this.lbCapacityInPieces.Size = new System.Drawing.Size(96, 13);
            this.lbCapacityInPieces.TabIndex = 2;
            this.lbCapacityInPieces.Text = "Capacity in pieces:";
            // 
            // lbCapcityInWeight
            // 
            this.lbCapcityInWeight.AutoSize = true;
            this.lbCapcityInWeight.Location = new System.Drawing.Point(13, 101);
            this.lbCapcityInWeight.Name = "lbCapcityInWeight";
            this.lbCapcityInWeight.Size = new System.Drawing.Size(90, 13);
            this.lbCapcityInWeight.TabIndex = 3;
            this.lbCapcityInWeight.Text = "Capcity in weight:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(53, 10);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(185, 20);
            this.tbName.TabIndex = 4;
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.tbName.Leave += new System.EventHandler(this.tbName_Leave);
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(53, 40);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(185, 20);
            this.tbCode.TabIndex = 5;
            // 
            // tbCapacityInPieces
            // 
            this.tbCapacityInPieces.Location = new System.Drawing.Point(108, 70);
            this.tbCapacityInPieces.Name = "tbCapacityInPieces";
            this.tbCapacityInPieces.Size = new System.Drawing.Size(130, 20);
            this.tbCapacityInPieces.TabIndex = 6;
            this.tbCapacityInPieces.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCapacityInPieces_KeyPress);
            this.tbCapacityInPieces.Leave += new System.EventHandler(this.tbName_Leave);
            // 
            // tbCapacityInWeight
            // 
            this.tbCapacityInWeight.Location = new System.Drawing.Point(108, 98);
            this.tbCapacityInWeight.Name = "tbCapacityInWeight";
            this.tbCapacityInWeight.Size = new System.Drawing.Size(130, 20);
            this.tbCapacityInWeight.TabIndex = 7;
            this.tbCapacityInWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCapacityInWeight_KeyPress);
            this.tbCapacityInWeight.Leave += new System.EventHandler(this.tbName_Leave);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(146, 124);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(92, 23);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // AddStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 157);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbCapacityInWeight);
            this.Controls.Add(this.tbCapacityInPieces);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbCapcityInWeight);
            this.Controls.Add(this.lbCapacityInPieces);
            this.Controls.Add(this.lbCode);
            this.Controls.Add(this.lbName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(270, 195);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(270, 195);
            this.Name = "AddStorage";
            this.Text = "New Storage";
            this.Load += new System.EventHandler(this.AddStorage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.Label lbCapacityInPieces;
        private System.Windows.Forms.Label lbCapcityInWeight;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.TextBox tbCapacityInPieces;
        private System.Windows.Forms.TextBox tbCapacityInWeight;
        private System.Windows.Forms.Button btnSubmit;
    }
}