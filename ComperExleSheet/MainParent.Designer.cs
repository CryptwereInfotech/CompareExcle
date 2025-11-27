namespace ComperExleSheet
{
    partial class MainParent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainParent));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductLine = new System.Windows.Forms.ToolStripSeparator();
            this.menuProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.userMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comparExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductCategoryLine = new System.Windows.Forms.ToolStripSeparator();
            this.menuPhysicalVerification = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.comparExcelToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductLine,
            this.menuProduct,
            this.toolStripSeparator1,
            this.userMasterToolStripMenuItem});
            this.masterToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(83, 27);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // ProductLine
            // 
            this.ProductLine.Name = "ProductLine";
            this.ProductLine.Size = new System.Drawing.Size(237, 6);
            // 
            // menuProduct
            // 
            this.menuProduct.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuProduct.Image = ((System.Drawing.Image)(resources.GetObject("menuProduct.Image")));
            this.menuProduct.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuProduct.Name = "menuProduct";
            this.menuProduct.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuProduct.Size = new System.Drawing.Size(240, 26);
            this.menuProduct.Text = "ProductMaster";
            this.menuProduct.Click += new System.EventHandler(this.menuProduct_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(237, 6);
            // 
            // userMasterToolStripMenuItem
            // 
            this.userMasterToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.userMasterToolStripMenuItem.Name = "userMasterToolStripMenuItem";
            this.userMasterToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.userMasterToolStripMenuItem.Text = "UserMaster";
            this.userMasterToolStripMenuItem.Click += new System.EventHandler(this.userMasterToolStripMenuItem_Click);
            // 
            // comparExcelToolStripMenuItem
            // 
            this.comparExcelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductCategoryLine,
            this.menuPhysicalVerification});
            this.comparExcelToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.comparExcelToolStripMenuItem.Name = "comparExcelToolStripMenuItem";
            this.comparExcelToolStripMenuItem.Size = new System.Drawing.Size(136, 27);
            this.comparExcelToolStripMenuItem.Text = "ComparExcel";
            // 
            // ProductCategoryLine
            // 
            this.ProductCategoryLine.Name = "ProductCategoryLine";
            this.ProductCategoryLine.Size = new System.Drawing.Size(301, 6);
            // 
            // menuPhysicalVerification
            // 
            this.menuPhysicalVerification.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuPhysicalVerification.Image = ((System.Drawing.Image)(resources.GetObject("menuPhysicalVerification.Image")));
            this.menuPhysicalVerification.Name = "menuPhysicalVerification";
            this.menuPhysicalVerification.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.V)));
            this.menuPhysicalVerification.Size = new System.Drawing.Size(304, 26);
            this.menuPhysicalVerification.Text = "Physical Verification";
            this.menuPhysicalVerification.Click += new System.EventHandler(this.menuPhysicalVerification_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productListToolStripMenuItem});
            this.reportToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(81, 27);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // productListToolStripMenuItem
            // 
            this.productListToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.productListToolStripMenuItem.Name = "productListToolStripMenuItem";
            this.productListToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.productListToolStripMenuItem.Text = "ProductList";
            this.productListToolStripMenuItem.Click += new System.EventHandler(this.productListToolStripMenuItem_Click);
            // 
            // MainParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainParent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainParent";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ProductLine;
        private System.Windows.Forms.ToolStripMenuItem menuProduct;
        private System.Windows.Forms.ToolStripMenuItem comparExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ProductCategoryLine;
        private System.Windows.Forms.ToolStripMenuItem menuPhysicalVerification;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem userMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productListToolStripMenuItem;
    }
}