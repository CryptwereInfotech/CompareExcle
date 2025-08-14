using DevExpress.CodeParser;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComperExleSheet
{
    public partial class ProductMaster : Form
    {
        private DataTable itemTable;
        public ProductMaster()
        {
            InitializeComponent();
            CreateItemTable();
            dgvList.DataSource =itemTable;
        }

        private  void CreateItemTable()
        {
            itemTable = new DataTable();
            itemTable.Columns.Add("ItemName", typeof(string));
            itemTable.Columns.Add("CATNUMBER", typeof(string));
            itemTable.Columns.Add("GTIN", typeof(string));
            itemTable.Columns.Add("StockGroup", typeof(string));
            itemTable.Columns.Add("StockCategory", typeof(string));
            itemTable.Columns.Add("UOM", typeof(string));
            itemTable.Columns.Add("HSN", typeof(string));
            itemTable.Columns.Add("IGSTRate", typeof(decimal));
            dgvList.DataSource = itemTable;
            GridView Gride1 = (GridView)dgvList.MainView;
            Gride1.Columns["UOM"].Visible = false;
            Gride1.Columns["HSN"].Visible = false;
            Gride1.Columns["IGSTRate"].Visible = false;
            Gride1.Columns["StockGroup"].Visible = false;

        }

        private void btn_ItemAdd_Click(object sender, EventArgs e)
        {
            if (!Validation())
                return;
            string StockGroup = "Joints Stock";
            string uom = "NOS";
            string hsn = "90213100";
            int igstRate = 5;

            itemTable.Rows.Add(
                txtItemName.Text.Trim(),
                txtCatNumber.Text.Trim(),
                txtGTIN.Text.Trim(),
                StockGroup,
                txtStockCategory.Text.Trim(),
                uom,
                hsn,
                igstRate

                );
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtItemName.Clear();
            txtCatNumber.Clear();
            txtGTIN.Clear();
            txtStockCategory.Clear();
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
            itemTable.Clear();
            dgvList.DataSource = itemTable;
        }

        //private void Btn_Add_Click(object sender, EventArgs e)
        //{
        //    string conStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        //    using (SqlConnection con = new SqlConnection(conStr))
        //    {
        //        con.Open();

        //        for (int i = 0; i < gridView1.RowCount; i++)
        //        {
        //            string itemName = gridView1.GetRowCellValue(i, "ItemName")?.ToString();
        //            string catNumber = gridView1.GetRowCellValue(i, "CATNUMBER")?.ToString();
        //            string gtin = gridView1.GetRowCellValue(i, "GTIN")?.ToString();
        //            string stockGroup = gridView1.GetRowCellValue(i, "StockGroup")?.ToString();
        //            string stockCategory = gridView1.GetRowCellValue(i, "StockCategory")?.ToString();
        //            string uom = gridView1.GetRowCellValue(i, "UOM")?.ToString();
        //            string hsn = gridView1.GetRowCellValue(i, "HSN")?.ToString();
        //            decimal igstRate = Convert.ToDecimal(gridView1.GetRowCellValue(i, "IGSTRate") ?? 0);


        //            string query = @"INSERT INTO ProductMaster
        //                    (ItemName, CATNUMBER, GTIN, StockGroup, StockCategory, UOM, HSN, IGSTRate)
        //                    VALUES (@ItemName, @CATNUMBER, @GTIN, @StockGroup, @StockCategory, @UOM, @HSN, @IGSTRate)";

        //            using (SqlCommand cmd = new SqlCommand(query, con))
        //            {
        //                cmd.Parameters.AddWithValue("@ItemName", itemName);
        //                cmd.Parameters.AddWithValue("@CATNUMBER", catNumber);
        //                cmd.Parameters.AddWithValue("@GTIN", gtin);
        //                cmd.Parameters.AddWithValue("@StockGroup", stockGroup);
        //                cmd.Parameters.AddWithValue("@StockCategory", stockCategory);
        //                cmd.Parameters.AddWithValue("@UOM", uom);
        //                cmd.Parameters.AddWithValue("@HSN", hsn);
        //                cmd.Parameters.AddWithValue("@IGSTRate", igstRate);

        //                cmd.ExecuteNonQuery();
        //            }
        //        }

        //        MessageBox.Show("Data saved successfully!");
        //        itemTable.Clear();
        //        dgvList.DataSource = itemTable;
        //    }
        //}
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            string conStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            gridView1.CloseEditor(); // commit current edit
            gridView1.UpdateCurrentRow();

            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();

                    for (int i = 0; i < gridView1.DataRowCount; i++)
                    {
                        string itemName = gridView1.GetRowCellValue(i, "ItemName")?.ToString();
                        string catNumber = gridView1.GetRowCellValue(i, "CATNUMBER")?.ToString();
                        string gtin = gridView1.GetRowCellValue(i, "GTIN")?.ToString();
                        string stockGroup = gridView1.GetRowCellValue(i, "StockGroup")?.ToString();
                        string stockCategory = gridView1.GetRowCellValue(i, "StockCategory")?.ToString();
                        string uom = gridView1.GetRowCellValue(i, "UOM")?.ToString();
                        string hsn = gridView1.GetRowCellValue(i, "HSN")?.ToString();
                        decimal igstRate = Convert.ToDecimal(gridView1.GetRowCellValue(i, "IGSTRate") ?? 0);

                        string query = @"INSERT INTO ProductMaster 
                    (ItemName, CATNUMBER, GTIN, StockGroup, StockCategory, UOM, HSN, IGSTRate)
                    VALUES (@ItemName, @CATNUMBER, @GTIN, @StockGroup, @StockCategory, @UOM, @HSN, @IGSTRate)";

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

                            int rows = cmd.ExecuteNonQuery();
                            if (rows == 0)
                            {
                                MessageBox.Show($"Row {i + 1} not inserted!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }

                MessageBox.Show("Data saved successfully!");
                itemTable.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while inserting: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            else if(txtGTIN.Text== "" || string.IsNullOrWhiteSpace(txtGTIN.Text))
            {
                MessageBox.Show("Please Enter GTIN", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGTIN.Focus();
                return false;
            }
            else if (txtStockCategory.Text == "" || string.IsNullOrWhiteSpace(txtStockCategory.Text))
            {
                MessageBox.Show("Please Enter StockCategory", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStockCategory.Focus();
                return false;
            }
            else if (txtGTIN.Text.Length <= 17)
            {
                MessageBox.Show("Please Enter Correct GTIN Number", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGTIN.Focus();
                return false;
            }
            return true;
        }


        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
