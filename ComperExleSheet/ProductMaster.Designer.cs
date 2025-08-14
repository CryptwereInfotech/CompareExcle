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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ItemAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtStockCategory = new System.Windows.Forms.TextBox();
            this.txtGTIN = new System.Windows.Forms.TextBox();
            this.txtCatNumber = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.txt_Uplod = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.dgvList.Size = new System.Drawing.Size(1301, 265);
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
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1307, 313);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btn_ItemAdd);
            this.panel2.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.panel2.Location = new System.Drawing.Point(6, 243);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1276, 64);
            this.panel2.TabIndex = 14;
            // 
            // btn_ItemAdd
            // 
            this.btn_ItemAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btn_ItemAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ItemAdd.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.btn_ItemAdd.Image = ((System.Drawing.Image)(resources.GetObject("btn_ItemAdd.Image")));
            this.btn_ItemAdd.Location = new System.Drawing.Point(1071, 13);
            this.btn_ItemAdd.Name = "btn_ItemAdd";
            this.btn_ItemAdd.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btn_ItemAdd.Size = new System.Drawing.Size(128, 44);
            this.btn_ItemAdd.TabIndex = 12;
            this.btn_ItemAdd.Text = "  Add";
            this.btn_ItemAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ItemAdd.UseVisualStyleBackColor = false;
            this.btn_ItemAdd.Click += new System.EventHandler(this.btn_ItemAdd_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtStockCategory);
            this.panel1.Controls.Add(this.txtGTIN);
            this.panel1.Controls.Add(this.txtCatNumber);
            this.panel1.Controls.Add(this.txtItemName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1276, 218);
            this.panel1.TabIndex = 13;
            // 
            // txtStockCategory
            // 
            this.txtStockCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockCategory.Location = new System.Drawing.Point(179, 177);
            this.txtStockCategory.Name = "txtStockCategory";
            this.txtStockCategory.Size = new System.Drawing.Size(1003, 30);
            this.txtStockCategory.TabIndex = 15;
            // 
            // txtGTIN
            // 
            this.txtGTIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGTIN.Location = new System.Drawing.Point(179, 125);
            this.txtGTIN.Name = "txtGTIN";
            this.txtGTIN.Size = new System.Drawing.Size(1003, 30);
            this.txtGTIN.TabIndex = 14;
            // 
            // txtCatNumber
            // 
            this.txtCatNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatNumber.Location = new System.Drawing.Point(179, 73);
            this.txtCatNumber.Name = "txtCatNumber";
            this.txtCatNumber.Size = new System.Drawing.Size(1003, 30);
            this.txtCatNumber.TabIndex = 13;
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(179, 12);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(1003, 30);
            this.txtItemName.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Stock Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "GTIN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "CAT Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Item Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvList);
            this.groupBox2.Location = new System.Drawing.Point(12, 331);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1307, 284);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ProductList";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.txt_Uplod);
            this.panel3.Controls.Add(this.btnRefresh);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.Btn_Add);
            this.panel3.Controls.Add(this.BtnExit);
            this.panel3.Location = new System.Drawing.Point(12, 620);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1307, 61);
            this.panel3.TabIndex = 3;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(382, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnRefresh.Size = new System.Drawing.Size(130, 44);
            this.btnRefresh.TabIndex = 95;
            this.btnRefresh.Text = "  &REFRESH";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(243, 8);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.button1.Size = new System.Drawing.Size(133, 44);
            this.button1.TabIndex = 93;
            this.button1.Text = "  &Remove";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.BtnExit.Location = new System.Drawing.Point(142, 8);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnExit.Size = new System.Drawing.Size(95, 44);
            this.BtnExit.TabIndex = 92;
            this.BtnExit.Text = "  E&xit";
            this.BtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // txt_Uplod
            // 
            this.txt_Uplod.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Uplod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_Uplod.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.txt_Uplod.Image = ((System.Drawing.Image)(resources.GetObject("txt_Uplod.Image")));
            this.txt_Uplod.Location = new System.Drawing.Point(602, 8);
            this.txt_Uplod.Name = "txt_Uplod";
            this.txt_Uplod.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.txt_Uplod.Size = new System.Drawing.Size(128, 44);
            this.txt_Uplod.TabIndex = 96;
            this.txt_Uplod.Text = "  &UPLOD";
            this.txt_Uplod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.txt_Uplod.UseVisualStyleBackColor = false;
            this.txt_Uplod.Click += new System.EventHandler(this.txt_Uplod_Click);
            // 
            // ProductMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 681);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProductMaster";
            this.Text = "ProductMaster";
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Button btn_ItemAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtStockCategory;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button txt_Uplod;
    }
}