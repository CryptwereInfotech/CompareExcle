using ClosedXML.Excel;
using DevExpress.CodeParser;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraGrid.Views.Grid;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Spreadsheet;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComperExleSheet
{
    public partial class ProductMaster : Form
    {
        private DataTable itemTable;
        int MainId = 0;
        int level = 0;
        public ProductMaster()
        {
            InitializeComponent();
            CreateItemTable();
            dgvList.DataSource = itemTable;
            this.FormBorderStyle = FormBorderStyle.Sizable;   // ❗ Must NOT be None
            this.WindowState = FormWindowState.Maximized;
            this.Load += ProductMaster_Load;

        }

        private void CreateItemTable()
        {
            itemTable = new DataTable();
            itemTable.Columns.Add("ItemName", typeof(string));
            itemTable.Columns.Add("CATNUMBER", typeof(string));
            itemTable.Columns.Add("GTIN", typeof(string));
            itemTable.Columns.Add("StockGroup", typeof(string));
            itemTable.Columns.Add("StockCategory", typeof(string));
            itemTable.Columns.Add("UOM", typeof(string));
            itemTable.Columns.Add("HSN", typeof(string));
            itemTable.Columns.Add("IGSTRate", typeof(string));
            itemTable.Columns.Add("MRP", typeof(float));
            dgvList.DataSource = itemTable;
            GridView Gride1 = (GridView)dgvList.MainView;
            Gride1.Columns["UOM"].Visible = false;
            //Gride1.Columns["HSN"].Visible = false;
            Gride1.Columns["IGSTRate"].Visible = false;
            Gride1.Columns["StockGroup"].Visible = false;
            Gride1.Columns["HSN"].Visible = false;

        }
        private void LoadProductData()
        {
            string conStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(conStr))
            {
                string query = "SELECT * FROM ProductMaster_Harsh ORDER BY ItemName";
                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    da.Fill(dt);
                }
            }
            dgvList.DataSource = dt;
            gridView1.BestFitColumns();
        }

        private void ProductMaster_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            LoadProductData();
            
        }

        private void btn_ItemAdd_Click(object sender, EventArgs e)
        {
            if (!Validation())
                return;
            itemTable.Rows.Add(
                txtItemName.Text.Trim(),
                txtCatNumber.Text.Trim(),
                txtGTIN.Text.Trim(),
                txtStockGroup.Text.Trim(),
                txtStockCategory.Text.Trim(),
                txt_uom.Text.Trim(),
                txt_hsncode.Text.Trim(),
                txt_igstrate.Text.Trim(),
                Convert.ToDecimal(txt_mrp.Text.Trim())
                );
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtItemName.Clear();
            txtCatNumber.Clear();
            txtGTIN.Clear();
            txtStockGroup.Clear();
            txtStockCategory.Clear();
            txt_uom.Clear();
            txt_hsncode.Clear();
            txt_igstrate.Clear();
            txt_mrp.Clear();
            txtItemName.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gridView1.FocusedRowHandle >= 0)
            {
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearInputs();
            //itemTable.Clear();
            //dgvList.DataSource = itemTable;
        }

        private bool Validation()
        {
            if (txtItemName.Text == "" || string.IsNullOrWhiteSpace(txtItemName.Text))
            {
                MessageBox.Show("Please enter Item Name", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtItemName.Focus();
                return false;
            }
            else if (txtCatNumber.Text == "" || string.IsNullOrWhiteSpace(txtCatNumber.Text))
            {
                MessageBox.Show("Please enter CatNumber", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCatNumber.Focus();
                return false;
            }
            else if (txtGTIN.Text == "" || string.IsNullOrWhiteSpace(txtGTIN.Text))
            {
                MessageBox.Show("Please Enter GTIN", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGTIN.Focus();
                return false;
            }
            else if (txtStockGroup.Text == "" || string.IsNullOrWhiteSpace(txtStockGroup.Text))
            {
                MessageBox.Show("Please Enter StockGroup", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStockGroup.Focus();
                return false;
            }
            else if (txtGTIN.Text.Length >= 18)
            {
                MessageBox.Show("Please Enter Correct GTIN Number", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGTIN.Focus();
                return false;
            }
            else if (txtStockCategory.Text == "" || string.IsNullOrWhiteSpace(txtStockCategory.Text))
            {
                MessageBox.Show("Please Enter StockCategory", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStockGroup.Focus();
                return false;
            }
            else if (txt_uom.Text == "" || string.IsNullOrWhiteSpace(txtStockCategory.Text))
            {
                MessageBox.Show("Please Enter UOM", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStockGroup.Focus();
                return false;
            }
            else if (txt_hsncode.Text == "" || string.IsNullOrWhiteSpace(txtStockCategory.Text))
            {
                MessageBox.Show("Please Enter Hsncode", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStockGroup.Focus();
                return false;
            }
            else if (txt_igstrate.Text == "" || string.IsNullOrWhiteSpace(txtStockCategory.Text))
            {
                MessageBox.Show("Please Enter IGSTRate", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStockGroup.Focus();
                return false;
            }
            return true;
        }


        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Save Sample Excel File";
            saveFileDialog.FileName = "SampleData.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                using (var workbook = new XLWorkbook())
                {
                    var ws = workbook.Worksheets.Add("SampleData");

                    // Header row
                    ws.Cell(1, 1).Value = "ItemName";
                    ws.Cell(1, 2).Value = "CATNUMBER";
                    ws.Cell(1, 3).Value = "GTIN";
                    ws.Cell(1, 4).Value = "StockGroup";
                    ws.Cell(1, 5).Value = "StockCategory";
                    ws.Cell(1, 6).Value = "UOM";
                    ws.Cell(1, 7).Value = "HSN";
                    ws.Cell(1, 8).Value = "IGSTRate";
                    ws.Cell(1, 9).Value = "MRP";

                    // Sample data row
                    ws.Cell(2, 1).Value = "5.0MM DIA TPRD HD PER SCREW 55";
                    ws.Cell(2, 2).Value = "125755000";
                    ws.Cell(2, 3).Value = "k0110603295019923";
                    ws.Cell(2, 4).Value = "Joints Stock";
                    ws.Cell(2, 5).Value = "REVHIP-SCREW";
                    ws.Cell(2, 6).Value = "NOS";
                    ws.Cell(2, 7).Value = "90213100";
                    ws.Cell(2, 8).Value = "5";
                    ws.Cell(2, 9).Value = "1";

                    // Auto adjust column width
                    ws.Columns().AdjustToContents();

                    // Save file
                    workbook.SaveAs(filePath);
                }

                MessageBox.Show("✅ Sample Excel file downloaded successfully!",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            if (gridView1.FocusedRowHandle >= 0)
            {
                txtItemName.Text = gridView1.GetRowCellValue(e.RowHandle, "ItemName")?.ToString();
                txtCatNumber.Text = gridView1.GetRowCellValue(e.RowHandle, "CATNUMBER")?.ToString();
                txtGTIN.Text = gridView1.GetRowCellValue(e.RowHandle, "GTIN")?.ToString();
                txtStockGroup.Text = gridView1.GetRowCellValue(e.RowHandle, "StockGroup")?.ToString();
                txtStockCategory.Text = gridView1.GetRowCellValue(e.RowHandle, "StockCategory")?.ToString();
                txt_uom.Text = gridView1.GetRowCellValue(e.RowHandle, "UOM")?.ToString();
                txt_hsncode.Text = gridView1.GetRowCellValue(e.RowHandle, "HSN")?.ToString();
                txt_igstrate.Text = gridView1.GetRowCellValue(e.RowHandle, "IGSTRate")?.ToString();
                txt_mrp.Text = gridView1.GetRowCellValue(e.RowHandle, "MRP")?.ToString();
            }
        }

        private void txt_Uplod_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
            openFileDialog.Title = "Select Excel File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                using (var workbook = new XLWorkbook(filePath))
                {
                    var ws = workbook.Worksheets.Worksheet(1); // First sheet
                    int rowCount = ws.LastRowUsed().RowNumber();

                    string connStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

                    using (SqlConnection con = new SqlConnection(connStr))
                    {
                        con.Open();

                        for (int row = 2; row <= rowCount; row++) // skip header
                        {
                            string itemName = ws.Cell(row, 1).GetValue<string>().Trim();
                            string catNumber = ws.Cell(row, 2).GetValue<string>().Trim();
                            string gtin = ws.Cell(row, 3).GetValue<string>().Trim();
                            string stockGroup = ws.Cell(row, 4).GetValue<string>().Trim();
                            string stockCategory = ws.Cell(row, 5).GetValue<string>().Trim();
                            string uom = ws.Cell(row, 6).GetValue<string>().Trim();
                            string hsn = ws.Cell(row, 7).GetValue<string>().Trim();
                            string igstRate = ws.Cell(row, 8).GetValue<string>().Trim();
                            string mrp = ws.Cell(row, 9).GetValue<string>().Trim();

                            if (string.IsNullOrEmpty(itemName)) continue; // skip empty rows

                            string dublicaterecord = "SELECT COUNT(*) FROM ProductMaster_Harsh WHERE GTIN=@GTIN";
                            
                            using(SqlCommand checkcmd= new SqlCommand(dublicaterecord, con))
                            {
                                checkcmd.Parameters.AddWithValue("@GTIN", gtin);
                                int count = Convert.ToInt32(checkcmd.ExecuteScalar());
                                if(count>0)
                                {
                                    continue;
                                }
                            }

                            string query = @"INSERT INTO ProductMaster_Harsh
                                     (ItemName, CATNUMBER, GTIN, StockGroup, StockCategory, UOM, HSN, IGSTRate)
                                     VALUES (@ItemName, @CATNUMBER, @GTIN, @StockGroup, @StockCategory, @UOM, @HSN, @IGSTRate,@MRP)";

                            using (SqlCommand cmd = new SqlCommand(query, con))
                            {
                                cmd.Parameters.AddWithValue("@ItemName", itemName);
                                cmd.Parameters.AddWithValue("@CATNUMBER", catNumber);
                                cmd.Parameters.AddWithValue("@GTIN", gtin);
                                cmd.Parameters.AddWithValue("@StockGroup", stockGroup);
                                cmd.Parameters.AddWithValue("@StockCategory", stockCategory);
                                cmd.Parameters.AddWithValue("@UOM", uom);
                                cmd.Parameters.AddWithValue("@HSN", hsn);
                                cmd.Parameters.AddWithValue("@IGSTRate", igstRate);
                                cmd.Parameters.AddWithValue("@MRP", mrp);

                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }

                MessageBox.Show("✅ Data uploaded and saved into ProductMaster_Harsh successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click_Click(object sender, EventArgs e)
        {
            if (gridView1.FocusedRowHandle < 0)
            {
                MessageBox.Show("Please select a record to update.");
                return;
            }

            string catNumber = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CATNUMBER").ToString();
            string conStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(conStr))
            {
                string query = @"UPDATE ProductMaster_Harsh SET 
                                 ItemName=@ItemName,CATNUMBER=@CATNUMBER, GTIN=@GTIN, StockGroup=@StockGroup,
                                 StockCategory=@StockCategory, UOM=@UOM, HSN=@HSN,
                                 IGSTRate=@IGSTRate, MRP=@MRP
                                 WHERE GTIN=@GTIN";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ItemName", txtItemName.Text.Trim());
                    cmd.Parameters.AddWithValue("@CATNUMBER", catNumber);
                    cmd.Parameters.AddWithValue("@GTIN", txtGTIN.Text.Trim());
                    cmd.Parameters.AddWithValue("@StockGroup", txtStockGroup.Text.Trim());
                    cmd.Parameters.AddWithValue("@StockCategory", txtStockCategory.Text.Trim());
                    cmd.Parameters.AddWithValue("@UOM", txt_uom.Text.Trim());
                    cmd.Parameters.AddWithValue("@HSN", txt_hsncode.Text.Trim());
                    cmd.Parameters.AddWithValue("@IGSTRate", txt_igstrate.Text.Trim());
                    cmd.Parameters.AddWithValue("@MRP", txt_mrp.Text.Trim());

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("✅ Record updated successfully!");
            LoadProductData();
        }

        private void btnDelete_Click_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_Add_Click(object sender, EventArgs e)
       {
            if (!Validation())
                return;

            string conStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();

                    if (level == 0)
                    {
                        string dublicat = "SELECT COUNT(*) FROM ProductMaster_Harsh WHERE GTIN=@GTIN";
                        
                        using(SqlCommand checkCmd = new SqlCommand(dublicat,con))
                        {
                            checkCmd.Parameters.AddWithValue("@GTIN", txtGTIN.Text.Trim());
                            int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                            if(count>0)
                            {
                                MessageBox.Show("GTIN alredy exists! Duplicate entry not allowed");
                                return;
                                ClearInputs();
                            }
                        }

        
                            string insertQuery = @"INSERT INTO ProductMaster_Harsh
                        (ItemName, CATNUMBER, GTIN, StockGroup, StockCategory, UOM, HSN, IGSTRate, MRP)
                        VALUES (@ItemName, @CATNUMBER, @GTIN, @StockGroup, @StockCategory, @UOM, @HSN, @IGSTRate, @MRP)";
                        using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@ItemName", txtItemName.Text.Trim());
                            cmd.Parameters.AddWithValue("@CATNUMBER", txtCatNumber.Text.Trim());
                            cmd.Parameters.AddWithValue("@GTIN", txtGTIN.Text.Trim());
                            cmd.Parameters.AddWithValue("@StockGroup", txtStockGroup.Text.Trim());
                            cmd.Parameters.AddWithValue("@StockCategory", txtStockCategory.Text.Trim());
                            cmd.Parameters.AddWithValue("@UOM", txt_uom.Text.Trim());
                            cmd.Parameters.AddWithValue("@HSN", txt_hsncode.Text.Trim());
                            cmd.Parameters.AddWithValue("@IGSTRate",txt_igstrate.Text.Trim());
                            cmd.Parameters.AddWithValue("@MRP", Convert.ToDecimal(txt_mrp.Text.Trim()));
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("✅ Product saved successfully!");
                    }
                    else
                    {
                        // ---------- UPDATE ----------
                        string updateQuery = @"UPDATE ProductMaster_Harsh SET
                        ItemName=@ItemName,CATNUMBER=@CATNUMBER ,GTIN=@GTIN, StockGroup=@StockGroup,
                        StockCategory=@StockCategory, UOM=@UOM, HSN=@HSN,
                        IGSTRate=@IGSTRate, MRP=@MRP
                        WHERE GTIN=@GTIN";

                        using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@ItemName", txtItemName.Text.Trim());
                            cmd.Parameters.AddWithValue("@CATNUMBER", txtCatNumber.Text.Trim());
                            cmd.Parameters.AddWithValue("@GTIN", txtGTIN.Text.Trim());
                            cmd.Parameters.AddWithValue("@StockGroup", txtStockGroup.Text.Trim());
                            cmd.Parameters.AddWithValue("@StockCategory", txtStockCategory.Text.Trim());
                            cmd.Parameters.AddWithValue("@UOM", txt_uom.Text.Trim());
                            cmd.Parameters.AddWithValue("@HSN", txt_hsncode.Text.Trim());
                            cmd.Parameters.AddWithValue("@IGSTRate",txt_igstrate.Text.Trim());
                            cmd.Parameters.AddWithValue("@MRP", Convert.ToDecimal(txt_mrp.Text.Trim()));
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("✅ Product updated successfully!");
                        level = 0;
                        MainId = 0;
                    }
                }

                ClearInputs();
                LoadProductData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving: " + ex.Message);
            }
        }

        private void btnUpdate_Click_Click_1(object sender, EventArgs e)
        {
            if (gridView1.FocusedRowHandle < 0)
            {
                MessageBox.Show("Please select a record to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr == null) return;

            level = 1; // Edit mode
            //MainId = 0; // not used if GTIN is string
            string gtinId = dr["GTIN"].ToString(); // use this for update

            // Fill input fields
            txtItemName.Text = dr["ItemName"].ToString();
            txtCatNumber.Text = dr["CATNUMBER"].ToString();
            txtGTIN.Text = gtinId;
            txtStockGroup.Text = dr["StockGroup"].ToString();
            txtStockCategory.Text = dr["StockCategory"].ToString();
            txt_uom.Text = dr["UOM"].ToString();
            txt_hsncode.Text = dr["HSN"].ToString();
            txt_igstrate.Text = dr["IGSTRate"].ToString();
            txt_mrp.Text = dr["MRP"].ToString();

            txtItemName.Focus();
        }

        private void BtnExit_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnDelete_Click_Click_1(object sender, EventArgs e)
        {
            if (gridView1.FocusedRowHandle < 0)
            {
                MessageBox.Show("Please select a record to delete.");
                return;
            }

            string itemName = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ItemName").ToString();
            string catNumber = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CATNUMBER").ToString();

            DialogResult result = MessageBox.Show($"Are you sure you want to delete '{itemName}'?",
                                                  "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string conStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    string query = "DELETE FROM ProductMaster_Harsh WHERE CATNUMBER=@CATNUMBER";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@CATNUMBER", catNumber);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("🗑️ Product deleted successfully!");
                LoadProductData();
            }
        }
    }
}
