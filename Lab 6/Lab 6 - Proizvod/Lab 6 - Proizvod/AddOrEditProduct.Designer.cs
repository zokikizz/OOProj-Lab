namespace Lab_6___Proizvod
{
    partial class AddOrEditProduct
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
            this.lbProducer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbShelf = new System.Windows.Forms.Label();
            this.lbFitAfterOpening = new System.Windows.Forms.Label();
            this.lbState = new System.Windows.Forms.Label();
            this.lbStorage = new System.Windows.Forms.Label();
            this.lbDateOfStorage = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbProducer = new System.Windows.Forms.TextBox();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.tbShelLife = new System.Windows.Forms.TextBox();
            this.tbFit = new System.Windows.Forms.TextBox();
            this.dtDateOfStorage = new System.Windows.Forms.DateTimePicker();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.cbStorage = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lbNoOFPackag = new System.Windows.Forms.Label();
            this.lbWeight = new System.Windows.Forms.Label();
            this.tbNo = new System.Windows.Forms.TextBox();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(12, 23);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(38, 13);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name:";
            // 
            // lbProducer
            // 
            this.lbProducer.AutoSize = true;
            this.lbProducer.Location = new System.Drawing.Point(12, 52);
            this.lbProducer.Name = "lbProducer";
            this.lbProducer.Size = new System.Drawing.Size(53, 13);
            this.lbProducer.TabIndex = 1;
            this.lbProducer.Text = "Producer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Code of product:";
            // 
            // lbShelf
            // 
            this.lbShelf.AutoSize = true;
            this.lbShelf.Location = new System.Drawing.Point(12, 116);
            this.lbShelf.Name = "lbShelf";
            this.lbShelf.Size = new System.Drawing.Size(54, 13);
            this.lbShelf.TabIndex = 3;
            this.lbShelf.Text = "Shelf Life:";
            // 
            // lbFitAfterOpening
            // 
            this.lbFitAfterOpening.AutoSize = true;
            this.lbFitAfterOpening.Location = new System.Drawing.Point(12, 149);
            this.lbFitAfterOpening.Name = "lbFitAfterOpening";
            this.lbFitAfterOpening.Size = new System.Drawing.Size(89, 13);
            this.lbFitAfterOpening.TabIndex = 4;
            this.lbFitAfterOpening.Text = "Fit After Opening:";
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.Location = new System.Drawing.Point(12, 261);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(35, 13);
            this.lbState.TabIndex = 5;
            this.lbState.Text = "State:";
            // 
            // lbStorage
            // 
            this.lbStorage.AutoSize = true;
            this.lbStorage.Location = new System.Drawing.Point(12, 294);
            this.lbStorage.Name = "lbStorage";
            this.lbStorage.Size = new System.Drawing.Size(47, 13);
            this.lbStorage.TabIndex = 6;
            this.lbStorage.Text = "Storage:";
            // 
            // lbDateOfStorage
            // 
            this.lbDateOfStorage.AutoSize = true;
            this.lbDateOfStorage.Location = new System.Drawing.Point(12, 321);
            this.lbDateOfStorage.Name = "lbDateOfStorage";
            this.lbDateOfStorage.Size = new System.Drawing.Size(83, 13);
            this.lbDateOfStorage.TabIndex = 7;
            this.lbDateOfStorage.Text = "Date of storage:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(107, 20);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(204, 20);
            this.tbName.TabIndex = 8;
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            this.tbName.Leave += new System.EventHandler(this.tbName_Leave);
            // 
            // tbProducer
            // 
            this.tbProducer.Location = new System.Drawing.Point(107, 53);
            this.tbProducer.Name = "tbProducer";
            this.tbProducer.Size = new System.Drawing.Size(204, 20);
            this.tbProducer.TabIndex = 9;
            this.tbProducer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            this.tbProducer.Leave += new System.EventHandler(this.tbName_Leave);
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(107, 86);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(204, 20);
            this.tbCode.TabIndex = 10;
            // 
            // tbShelLife
            // 
            this.tbShelLife.Location = new System.Drawing.Point(107, 117);
            this.tbShelLife.Name = "tbShelLife";
            this.tbShelLife.Size = new System.Drawing.Size(204, 20);
            this.tbShelLife.TabIndex = 11;
            this.tbShelLife.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbShelLife_KeyPress);
            this.tbShelLife.Leave += new System.EventHandler(this.tbName_Leave);
            // 
            // tbFit
            // 
            this.tbFit.Location = new System.Drawing.Point(107, 150);
            this.tbFit.Name = "tbFit";
            this.tbFit.Size = new System.Drawing.Size(204, 20);
            this.tbFit.TabIndex = 12;
            this.tbFit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbShelLife_KeyPress);
            this.tbFit.Leave += new System.EventHandler(this.tbName_Leave);
            // 
            // dtDateOfStorage
            // 
            this.dtDateOfStorage.Location = new System.Drawing.Point(107, 321);
            this.dtDateOfStorage.Name = "dtDateOfStorage";
            this.dtDateOfStorage.Size = new System.Drawing.Size(204, 20);
            this.dtDateOfStorage.TabIndex = 14;
            // 
            // cbState
            // 
            this.cbState.FormattingEnabled = true;
            this.cbState.Location = new System.Drawing.Point(107, 254);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(204, 21);
            this.cbState.TabIndex = 15;
            // 
            // cbStorage
            // 
            this.cbStorage.FormattingEnabled = true;
            this.cbStorage.Location = new System.Drawing.Point(107, 291);
            this.cbStorage.Name = "cbStorage";
            this.cbStorage.Size = new System.Drawing.Size(204, 21);
            this.cbStorage.TabIndex = 16;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(236, 359);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 18;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lbNoOFPackag
            // 
            this.lbNoOFPackag.AutoSize = true;
            this.lbNoOFPackag.Location = new System.Drawing.Point(12, 186);
            this.lbNoOFPackag.Name = "lbNoOFPackag";
            this.lbNoOFPackag.Size = new System.Drawing.Size(98, 13);
            this.lbNoOFPackag.TabIndex = 19;
            this.lbNoOFPackag.Text = "Number of packag:";
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Location = new System.Drawing.Point(12, 220);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(44, 13);
            this.lbWeight.TabIndex = 20;
            this.lbWeight.Text = "Weight:";
            // 
            // tbNo
            // 
            this.tbNo.Location = new System.Drawing.Point(107, 183);
            this.tbNo.Name = "tbNo";
            this.tbNo.Size = new System.Drawing.Size(204, 20);
            this.tbNo.TabIndex = 21;
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(107, 217);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(204, 20);
            this.tbWeight.TabIndex = 22;
            // 
            // AddOrEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 398);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.tbNo);
            this.Controls.Add(this.lbWeight);
            this.Controls.Add(this.lbNoOFPackag);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cbStorage);
            this.Controls.Add(this.cbState);
            this.Controls.Add(this.dtDateOfStorage);
            this.Controls.Add(this.tbFit);
            this.Controls.Add(this.tbShelLife);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.tbProducer);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbDateOfStorage);
            this.Controls.Add(this.lbStorage);
            this.Controls.Add(this.lbState);
            this.Controls.Add(this.lbFitAfterOpening);
            this.Controls.Add(this.lbShelf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbProducer);
            this.Controls.Add(this.lbName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddOrEditProduct";
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.AddOrEditProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbProducer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbShelf;
        private System.Windows.Forms.Label lbFitAfterOpening;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.Label lbStorage;
        private System.Windows.Forms.Label lbDateOfStorage;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbProducer;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.TextBox tbShelLife;
        private System.Windows.Forms.TextBox tbFit;
        private System.Windows.Forms.DateTimePicker dtDateOfStorage;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.ComboBox cbStorage;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lbNoOFPackag;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.TextBox tbNo;
        private System.Windows.Forms.TextBox tbWeight;
    }
}