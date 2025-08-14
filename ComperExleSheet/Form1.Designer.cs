namespace ComperExleSheet
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnUploadExcel = new System.Windows.Forms.Button();
            this.btnUploadTally = new System.Windows.Forms.Button();
            this.btnCompare = new System.Windows.Forms.Button();
            this.lblExcelStatus = new System.Windows.Forms.Label();
            this.lblTallyStatus = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_cmbFilterDev = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMissingPhysical = new System.Windows.Forms.Label();
            this.lblMissingBook = new System.Windows.Forms.Label();
            this.lblMatched = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnExit = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cmbFilterDev.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUploadExcel
            // 
            this.btnUploadExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadExcel.Location = new System.Drawing.Point(26, 31);
            this.btnUploadExcel.Name = "btnUploadExcel";
            this.btnUploadExcel.Size = new System.Drawing.Size(265, 43);
            this.btnUploadExcel.TabIndex = 0;
            this.btnUploadExcel.Text = "Upload_Physical_Excel";
            this.btnUploadExcel.UseVisualStyleBackColor = true;
            this.btnUploadExcel.Click += new System.EventHandler(this.btnUploadExcel_Click);
            // 
            // btnUploadTally
            // 
            this.btnUploadTally.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadTally.Location = new System.Drawing.Point(371, 31);
            this.btnUploadTally.Name = "btnUploadTally";
            this.btnUploadTally.Size = new System.Drawing.Size(265, 43);
            this.btnUploadTally.TabIndex = 1;
            this.btnUploadTally.Text = "Upload_Book_Excel";
            this.btnUploadTally.UseVisualStyleBackColor = true;
            this.btnUploadTally.Click += new System.EventHandler(this.btnUploadTally_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompare.Location = new System.Drawing.Point(740, 31);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(265, 43);
            this.btnCompare.TabIndex = 2;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // lblExcelStatus
            // 
            this.lblExcelStatus.AutoSize = true;
            this.lblExcelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExcelStatus.Location = new System.Drawing.Point(25, 77);
            this.lblExcelStatus.Name = "lblExcelStatus";
            this.lblExcelStatus.Size = new System.Drawing.Size(50, 17);
            this.lblExcelStatus.TabIndex = 5;
            this.lblExcelStatus.Text = "status:";
            this.lblExcelStatus.Visible = false;
            // 
            // lblTallyStatus
            // 
            this.lblTallyStatus.AutoSize = true;
            this.lblTallyStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTallyStatus.Location = new System.Drawing.Point(368, 77);
            this.lblTallyStatus.Name = "lblTallyStatus";
            this.lblTallyStatus.Size = new System.Drawing.Size(50, 17);
            this.lblTallyStatus.TabIndex = 6;
            this.lblTallyStatus.Text = "status:";
            this.lblTallyStatus.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(743, 77);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 17);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "status:";
            this.lblStatus.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.txt_cmbFilterDev);
            this.groupBox1.Controls.Add(this.cmbFilter);
            this.groupBox1.Controls.Add(this.btnUploadExcel);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.lblExcelStatus);
            this.groupBox1.Controls.Add(this.lblTallyStatus);
            this.groupBox1.Controls.Add(this.btnUploadTally);
            this.groupBox1.Controls.Add(this.btnCompare);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1346, 112);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ExcelComper";
            // 
            // txt_cmbFilterDev
            // 
            this.txt_cmbFilterDev.Location = new System.Drawing.Point(1099, 42);
            this.txt_cmbFilterDev.Name = "txt_SupplierDev";
            // 
            // 
            // 
            this.txt_cmbFilterDev.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.txt_cmbFilterDev.Properties.Appearance.Options.UseFont = true;
            this.txt_cmbFilterDev.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txt_cmbFilterDev.Properties.NullText = "Please Select";
            this.txt_cmbFilterDev.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.txt_cmbFilterDev.Size = new System.Drawing.Size(200, 30);
            this.txt_cmbFilterDev.TabIndex = 1;
            this.txt_cmbFilterDev.EditValueChanged += new System.EventHandler(this.txt_cmbFilterDev_EditValueChanged);
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(1099, 42);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(184, 24);
            this.cmbFilter.TabIndex = 8;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1346, 436);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mismatched  Deta";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMissingPhysical);
            this.panel1.Controls.Add(this.lblMissingBook);
            this.panel1.Controls.Add(this.lblMatched);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Location = new System.Drawing.Point(6, 400);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1329, 36);
            this.panel1.TabIndex = 11;
            // 
            // lblMissingPhysical
            // 
            this.lblMissingPhysical.AutoSize = true;
            this.lblMissingPhysical.Location = new System.Drawing.Point(627, 9);
            this.lblMissingPhysical.Name = "lblMissingPhysical";
            this.lblMissingPhysical.Size = new System.Drawing.Size(195, 17);
            this.lblMissingPhysical.TabIndex = 4;
            this.lblMissingPhysical.Text = "Missing in Physical Stock:";
            // 
            // lblMissingBook
            // 
            this.lblMissingBook.AutoSize = true;
            this.lblMissingBook.Location = new System.Drawing.Point(334, 9);
            this.lblMissingBook.Name = "lblMissingBook";
            this.lblMissingBook.Size = new System.Drawing.Size(171, 17);
            this.lblMissingBook.TabIndex = 3;
            this.lblMissingBook.Text = "Missing in Book Stock:";
            // 
            // lblMatched
            // 
            this.lblMatched.AutoSize = true;
            this.lblMatched.Location = new System.Drawing.Point(140, 9);
            this.lblMatched.Name = "lblMatched";
            this.lblMatched.Size = new System.Drawing.Size(74, 17);
            this.lblMatched.TabIndex = 1;
            this.lblMatched.Text = "Matched:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 9);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(50, 17);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(6, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1329, 382);
            this.dataGridView1.TabIndex = 10;
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.SystemColors.Control;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.Location = new System.Drawing.Point(96, 12);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnExit.Size = new System.Drawing.Size(165, 44);
            this.BtnExit.TabIndex = 11;
            this.BtnExit.Text = "  E&xit";
            this.BtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.SystemColors.Control;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.Location = new System.Drawing.Point(284, 12);
            this.btnExport.Name = "btnExport";
            this.btnExport.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnExport.Size = new System.Drawing.Size(165, 44);
            this.btnExport.TabIndex = 13;
            this.btnExport.Text = "  &Export";
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Controls.Add(this.btnExport);
            this.groupBox3.Controls.Add(this.BtnExit);
            this.groupBox3.Location = new System.Drawing.Point(12, 572);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1346, 77);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(468, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnRefresh.Size = new System.Drawing.Size(163, 44);
            this.btnRefresh.TabIndex = 92;
            this.btnRefresh.Text = "  &REFRESH";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1370, 659);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "MismatchDeta Find";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cmbFilterDev.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUploadExcel;
        private System.Windows.Forms.Button btnUploadTally;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Label lblExcelStatus;
        private System.Windows.Forms.Label lblTallyStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRefresh;
        private DevExpress.XtraEditors.LookUpEdit txt_cmbFilterDev;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMissingPhysical;
        private System.Windows.Forms.Label lblMissingBook;
        private System.Windows.Forms.Label lblMatched;
        private System.Windows.Forms.Label lblTotal;
    }
}

