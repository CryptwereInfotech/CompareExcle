namespace ComperExleSheet
{
    partial class FrmStockReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStockReport));
            this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Product = new DevExpress.XtraEditors.LookUpEdit();
            this.btnDownload = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Item = new System.Windows.Forms.ComboBox();
            this.dgvSOList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ItemAdd = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.btnDelete_Click = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Product.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSOList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelControl1
            // 
            this.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl1.Controls.Add(this.groupBox1);
            this.PanelControl1.Controls.Add(this.panel2);
            this.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControl1.Location = new System.Drawing.Point(0, 0);
            this.PanelControl1.Name = "PanelControl1";
            this.PanelControl1.Size = new System.Drawing.Size(1259, 518);
            this.PanelControl1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.txt_Product);
            this.groupBox1.Controls.Add(this.btnDownload);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_Item);
            this.groupBox1.Controls.Add(this.dgvSOList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 17, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(1259, 444);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock Report";
            // 
            // txt_Product
            // 
            this.txt_Product.Location = new System.Drawing.Point(74, 38);
            this.txt_Product.Name = "txt_Product";
            // 
            // 
            // 
            this.txt_Product.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.txt_Product.Properties.Appearance.Options.UseFont = true;
            this.txt_Product.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_Product.Properties.NullText = "Please Select";
            this.txt_Product.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.txt_Product.Size = new System.Drawing.Size(513, 30);
            this.txt_Product.TabIndex = 93;
            this.txt_Product.EditValueChanged += new System.EventHandler(this.txt_Product_EditValueChanged);
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.SystemColors.Control;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.btnDownload.Location = new System.Drawing.Point(681, 37);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnDownload.Size = new System.Drawing.Size(121, 37);
            this.btnDownload.TabIndex = 89;
            this.btnDownload.Text = "Load";
            this.btnDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(7, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 24);
            this.label9.TabIndex = 69;
            this.label9.Text = "Item :";
            // 
            // txt_Item
            // 
            this.txt_Item.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.txt_Item.FormattingEnabled = true;
            this.txt_Item.Location = new System.Drawing.Point(74, 37);
            this.txt_Item.Name = "txt_Item";
            this.txt_Item.Size = new System.Drawing.Size(513, 32);
            this.txt_Item.TabIndex = 68;
            this.txt_Item.Visible = false;
            // 
            // dgvSOList
            // 
            this.dgvSOList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSOList.Location = new System.Drawing.Point(3, 91);
            this.dgvSOList.MainView = this.gridView1;
            this.dgvSOList.Name = "dgvSOList";
            this.dgvSOList.Size = new System.Drawing.Size(1244, 350);
            this.dgvSOList.TabIndex = 0;
            this.dgvSOList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgvSOList;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnDelete_Click);
            this.panel2.Controls.Add(this.btn_ItemAdd);
            this.panel2.Controls.Add(this.BtnExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 444);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1259, 74);
            this.panel2.TabIndex = 15;
            // 
            // btn_ItemAdd
            // 
            this.btn_ItemAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btn_ItemAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ItemAdd.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.btn_ItemAdd.Image = ((System.Drawing.Image)(resources.GetObject("btn_ItemAdd.Image")));
            this.btn_ItemAdd.Location = new System.Drawing.Point(12, 18);
            this.btn_ItemAdd.Name = "btn_ItemAdd";
            this.btn_ItemAdd.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btn_ItemAdd.Size = new System.Drawing.Size(110, 44);
            this.btn_ItemAdd.TabIndex = 88;
            this.btn_ItemAdd.Text = "EXPORT";
            this.btn_ItemAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ItemAdd.UseVisualStyleBackColor = false;
            this.btn_ItemAdd.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.SystemColors.Control;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.Location = new System.Drawing.Point(128, 18);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.BtnExit.Size = new System.Drawing.Size(95, 44);
            this.BtnExit.TabIndex = 24;
            this.BtnExit.Text = "  E&XIT";
            this.BtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnDelete_Click
            // 
            this.btnDelete_Click.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete_Click.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.btnDelete_Click.Image = global::ComperExleSheet.Properties.Resources.delete;
            this.btnDelete_Click.Location = new System.Drawing.Point(238, 18);
            this.btnDelete_Click.Name = "btnDelete_Click";
            this.btnDelete_Click.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnDelete_Click.Size = new System.Drawing.Size(133, 44);
            this.btnDelete_Click.TabIndex = 100;
            this.btnDelete_Click.Text = "  &Delete";
            this.btnDelete_Click.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete_Click.UseVisualStyleBackColor = false;
            this.btnDelete_Click.Click += new System.EventHandler(this.btnDelete_Click_Click);
            // 
            // FrmStockReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1259, 518);
            this.Controls.Add(this.PanelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStockReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Product.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSOList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal DevExpress.XtraEditors.PanelControl PanelControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        public DevExpress.XtraGrid.GridControl dgvSOList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button btn_ItemAdd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox txt_Item;
        private System.Windows.Forms.Button btnDownload;
        private DevExpress.XtraEditors.LookUpEdit txt_Product;
        private System.Windows.Forms.Button btnDelete_Click;
    }
}