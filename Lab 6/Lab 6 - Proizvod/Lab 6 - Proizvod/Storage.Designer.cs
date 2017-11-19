namespace Lab_6___Proizvod
{
    partial class Storage
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
            this.StorageBox = new System.Windows.Forms.ComboBox();
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnNewStorage = new System.Windows.Forms.Button();
            this.btnNewProduct = new System.Windows.Forms.Button();
            this.btnDeleteStorage = new System.Windows.Forms.Button();
            this.BtnEditStorage = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.BtnEditProduct = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.msOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.msUpdateOrSave = new System.Windows.Forms.ToolStripMenuItem();
            this.msDelete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StorageBox
            // 
            this.StorageBox.FormattingEnabled = true;
            this.StorageBox.Location = new System.Drawing.Point(12, 37);
            this.StorageBox.Name = "StorageBox";
            this.StorageBox.Size = new System.Drawing.Size(121, 21);
            this.StorageBox.TabIndex = 0;
            this.StorageBox.SelectedIndexChanged += new System.EventHandler(this.StorageBox_SelectedIndexChanged);
            // 
            // dgwProducts
            // 
            this.dgwProducts.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(12, 102);
            this.dgwProducts.MultiSelect = false;
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.ReadOnly = true;
            this.dgwProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwProducts.Size = new System.Drawing.Size(431, 230);
            this.dgwProducts.TabIndex = 1;
            // 
            // btnNewStorage
            // 
            this.btnNewStorage.Location = new System.Drawing.Point(140, 35);
            this.btnNewStorage.Name = "btnNewStorage";
            this.btnNewStorage.Size = new System.Drawing.Size(97, 23);
            this.btnNewStorage.TabIndex = 2;
            this.btnNewStorage.Text = "Add new sorage";
            this.btnNewStorage.UseVisualStyleBackColor = true;
            this.btnNewStorage.Click += new System.EventHandler(this.btnNewStorage_Click);
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.Location = new System.Drawing.Point(12, 73);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(122, 23);
            this.btnNewProduct.TabIndex = 3;
            this.btnNewProduct.Text = "Add new Product";
            this.btnNewProduct.UseVisualStyleBackColor = true;
            this.btnNewProduct.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // btnDeleteStorage
            // 
            this.btnDeleteStorage.Location = new System.Drawing.Point(243, 35);
            this.btnDeleteStorage.Name = "btnDeleteStorage";
            this.btnDeleteStorage.Size = new System.Drawing.Size(97, 23);
            this.btnDeleteStorage.TabIndex = 4;
            this.btnDeleteStorage.Text = "Delete storage";
            this.btnDeleteStorage.UseVisualStyleBackColor = true;
            this.btnDeleteStorage.Click += new System.EventHandler(this.btnDeleteStorage_Click);
            // 
            // BtnEditStorage
            // 
            this.BtnEditStorage.Location = new System.Drawing.Point(346, 35);
            this.BtnEditStorage.Name = "BtnEditStorage";
            this.BtnEditStorage.Size = new System.Drawing.Size(97, 23);
            this.BtnEditStorage.TabIndex = 5;
            this.BtnEditStorage.Text = "Edit storage";
            this.BtnEditStorage.UseVisualStyleBackColor = true;
            this.BtnEditStorage.Click += new System.EventHandler(this.BtnEditStorage_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(141, 73);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(97, 23);
            this.btnDeleteProduct.TabIndex = 6;
            this.btnDeleteProduct.Text = "Delete product";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // BtnEditProduct
            // 
            this.BtnEditProduct.Location = new System.Drawing.Point(244, 73);
            this.BtnEditProduct.Name = "BtnEditProduct";
            this.BtnEditProduct.Size = new System.Drawing.Size(97, 23);
            this.BtnEditProduct.TabIndex = 7;
            this.BtnEditProduct.Text = "Edit product";
            this.BtnEditProduct.UseVisualStyleBackColor = true;
            this.BtnEditProduct.Click += new System.EventHandler(this.BtnEditProduct_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(457, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msCreate,
            this.msOpen,
            this.msUpdateOrSave,
            this.msDelete});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // msCreate
            // 
            this.msCreate.Name = "msCreate";
            this.msCreate.Size = new System.Drawing.Size(153, 22);
            this.msCreate.Text = "Create";
            this.msCreate.Click += new System.EventHandler(this.msCreate_Click);
            // 
            // msOpen
            // 
            this.msOpen.Name = "msOpen";
            this.msOpen.Size = new System.Drawing.Size(153, 22);
            this.msOpen.Text = "Open";
            this.msOpen.Click += new System.EventHandler(this.msOpen_Click);
            // 
            // msUpdateOrSave
            // 
            this.msUpdateOrSave.Name = "msUpdateOrSave";
            this.msUpdateOrSave.Size = new System.Drawing.Size(153, 22);
            this.msUpdateOrSave.Text = "Update or Save";
            this.msUpdateOrSave.Click += new System.EventHandler(this.msUpdateOrSave_Click);
            // 
            // msDelete
            // 
            this.msDelete.Name = "msDelete";
            this.msDelete.Size = new System.Drawing.Size(153, 22);
            this.msDelete.Text = "Delete";
            this.msDelete.Click += new System.EventHandler(this.msDelete_Click);
            // 
            // Storage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 344);
            this.Controls.Add(this.BtnEditProduct);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.BtnEditStorage);
            this.Controls.Add(this.btnDeleteStorage);
            this.Controls.Add(this.btnNewProduct);
            this.Controls.Add(this.btnNewStorage);
            this.Controls.Add(this.dgwProducts);
            this.Controls.Add(this.StorageBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Storage";
            this.Text = "Storage";
            this.Load += new System.EventHandler(this.Storage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox StorageBox;
        private System.Windows.Forms.DataGridView dgwProducts;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnNewStorage;
        private System.Windows.Forms.Button btnNewProduct;
        private System.Windows.Forms.Button btnDeleteStorage;
        private System.Windows.Forms.Button BtnEditStorage;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button BtnEditProduct;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msCreate;
        private System.Windows.Forms.ToolStripMenuItem msOpen;
        private System.Windows.Forms.ToolStripMenuItem msUpdateOrSave;
        private System.Windows.Forms.ToolStripMenuItem msDelete;
    }
}

