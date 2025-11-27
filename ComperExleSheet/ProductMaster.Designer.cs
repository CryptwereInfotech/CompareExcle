namespace ComperExleSheet
{
    partial class ProductMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductMaster));
            this.dgvList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_mrp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_igstrate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_hsncode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_uom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStockCategory = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStockGroup = new System.Windows.Forms.TextBox();
            this.txtGTIN = new System.Windows.Forms.TextBox();
            this.txtCatNumber = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDelete_Click = new System.Windows.Forms.Button();
            this.btnUpdate_Click = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_Uplod = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(3, 16);
            this.dgvList.MainView = this.gridView1;
            this.dgvList.Name = "dgvList";
            this.dgvList.Size = new System.Drawing.Size(1282, 254);
            this.dgvList.TabIndex = 0;
            this.dgvList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgvList;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1288, 386);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txt_mrp);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txt_igstrate);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_hsncode);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_uom);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtStockCategory);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtStockGroup);
            this.panel1.Controls.Add(this.txtGTIN);
            this.panel1.Controls.Add(this.txtCatNumber);
            this.panel1.Controls.Add(this.txtItemName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(6, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1257, 350);
            this.panel1.TabIndex = 13;
            // 
            // txt_mrp
            // 
            this.txt_mrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mrp.Location = new System.Drawing.Point(179, 314);
            this.txt_mrp.Name = "txt_mrp";
            this.txt_mrp.Size = new System.Drawing.Size(1003, 29);
            this.txt_mrp.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(41, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "MRP:";
            // 
            // txt_igstrate
            // 
            this.txt_igstrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_igstrate.Location = new System.Drawing.Point(179, 275);
            this.txt_igstrate.Name = "txt_igstrate";
            this.txt_igstrate.Size = new System.Drawing.Size(1003, 29);
            this.txt_igstrate.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "IGSTRATE:";
            // 
            // txt_hsncode
            // 
            this.txt_hsncode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hsncode.Location = new System.Drawing.Point(179, 237);
            this.txt_hsncode.Name = "txt_hsncode";
            this.txt_hsncode.Size = new System.Drawing.Size(1003, 29);
            this.txt_hsncode.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "HSN CODE:";
            // 
            // txt_uom
            // 
            this.txt_uom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_uom.Location = new System.Drawing.Point(179, 199);
            this.txt_uom.Name = "txt_uom";
            this.txt_uom.Size = new System.Drawing.Size(1003, 29);
            this.txt_uom.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "UOM:";
            // 
            // txtStockCategory
            // 
            this.txtStockCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockCategory.Location = new System.Drawing.Point(179, 162);
            this.txtStockCategory.Name = "txtStockCategory";
            this.txtStockCategory.Size = new System.Drawing.Size(1003, 29);
            this.txtStockCategory.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Stock Category:";
            // 
            // txtStockGroup
            // 
            this.txtStockGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockGroup.Location = new System.Drawing.Point(179, 123);
            this.txtStockGroup.Name = "txtStockGroup";
            this.txtStockGroup.Size = new System.Drawing.Size(1003, 29);
            this.txtStockGroup.TabIndex = 15;
            // 
            // txtGTIN
            // 
            this.txtGTIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGTIN.Location = new System.Drawing.Point(179, 85);
            this.txtGTIN.Name = "txtGTIN";
            this.txtGTIN.Size = new System.Drawing.Size(1003, 29);
            this.txtGTIN.TabIndex = 14;
            // 
            // txtCatNumber
            // 
            this.txtCatNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatNumber.Location = new System.Drawing.Point(179, 47);
            this.txtCatNumber.Name = "txtCatNumber";
            this.txtCatNumber.Size = new System.Drawing.Size(1003, 29);
            this.txtCatNumber.TabIndex = 13;
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(179, 13);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(1003, 29);
            this.txtItemName.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "StockGroup:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "GTIN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "CAT Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Item Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvList);
            this.groupBox2.Location = new System.Drawing.Point(12, 404);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1288, 273);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ProductList";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.btnDelete_Click);
            this.panel3.Controls.Add(this.btnUpdate_Click);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.txt_Uplod);
            this.panel3.Controls.Add(this.btnRefresh);
            this.panel3.Controls.Add(this.Btn_Add);
            this.panel3.Controls.Add(this.BtnExit);
            this.panel3.Location = new System.Drawing.Point(12, 689);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1288, 58);
            this.panel3.TabIndex = 3;
            // 
            // btnDelete_Click
            // 
            this.btnDelete_Click.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete_Click.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.btnDelete_Click.Image = global::ComperExleSheet.Properties.Resources.delete;
            this.btnDelete_Click.Location = new System.Drawing.Point(267, 8);
            this.btnDelete_Click.Name = "btnDelete_Click";
            this.btnDelete_Click.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnDelete_Click.Size = new System.Drawing.Size(119, 44);
            this.btnDelete_Click.TabIndex = 99;
            this.btnDelete_Click.Text = "  &Delete";
            this.btnDelete_Click.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete_Click.UseVisualStyleBackColor = false;
            this.btnDelete_Click.Click += new System.EventHandler(this.btnDelete_Click_Click_1);
            // 
            // btnUpdate_Click
            // 
            this.btnUpdate_Click.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate_Click.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.btnUpdate_Click.Image = global::ComperExleSheet.Properties.Resources.EditLogo__2_;
            this.btnUpdate_Click.Location = new System.Drawing.Point(145, 8);
            this.btnUpdate_Click.Name = "btnUpdate_Click";
            this.btnUpdate_Click.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnUpdate_Click.Size = new System.Drawing.Size(116, 44);
            this.btnUpdate_Click.TabIndex = 98;
            this.btnUpdate_Click.Text = "  &Edit";
            this.btnUpdate_Click.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate_Click.UseVisualStyleBackColor = false;
            this.btnUpdate_Click.Click += new System.EventHandler(this.btnUpdate_Click_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.button2.Image = global::ComperExleSheet.Properties.Resources.inbox__1__imresizer;
            this.button2.Location = new System.Drawing.Point(967, 8);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.button2.Size = new System.Drawing.Size(154, 44);
            this.button2.TabIndex = 97;
            this.button2.Text = "  DOWNLOAD";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_Uplod
            // 
            this.txt_Uplod.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Uplod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_Uplod.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.txt_Uplod.Image = global::ComperExleSheet.Properties.Resources.inbox_imresizer;
            this.txt_Uplod.Location = new System.Drawing.Point(1127, 8);
            this.txt_Uplod.Name = "txt_Uplod";
            this.txt_Uplod.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.txt_Uplod.Size = new System.Drawing.Size(147, 44);
            this.txt_Uplod.TabIndex = 96;
            this.txt_Uplod.Text = "  &UPLOD";
            this.txt_Uplod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.txt_Uplod.UseVisualStyleBackColor = false;
            this.txt_Uplod.Click += new System.EventHandler(this.txt_Uplod_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(392, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnRefresh.Size = new System.Drawing.Size(128, 44);
            this.btnRefresh.TabIndex = 95;
            this.btnRefresh.Text = "  &REFRESH";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Btn_Add
            // 
            this.Btn_Add.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Add.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.Btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Add.Image")));
            this.Btn_Add.Location = new System.Drawing.Point(37, 8);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.Btn_Add.Size = new System.Drawing.Size(102, 44);
            this.Btn_Add.TabIndex = 94;
            this.Btn_Add.Text = "  &SAVE";
            this.Btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Add.UseVisualStyleBackColor = false;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.SystemColors.Control;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.Location = new System.Drawing.Point(526, 8);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnExit.Size = new System.Drawing.Size(95, 44);
            this.BtnExit.TabIndex = 92;
            this.BtnExit.Text = "  E&xit";
            this.BtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click_1);
            // 
            // ProductMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1312, 749);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "ProductMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductMaster";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProductMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl dgvList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtStockGroup;
        private System.Windows.Forms.TextBox txtGTIN;
        private System.Windows.Forms.TextBox txtCatNumber;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button txt_Uplod;
        private System.Windows.Forms.TextBox txt_hsncode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_uom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStockCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_igstrate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDelete_Click;
        private System.Windows.Forms.Button btnUpdate_Click;
        private System.Windows.Forms.TextBox txt_mrp;
        private System.Windows.Forms.Label label9;
    }
}