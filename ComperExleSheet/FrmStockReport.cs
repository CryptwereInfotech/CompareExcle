using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;   // For LookUpEdit
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ComperExleSheet
{
    public partial class FrmStockReport : Form
    {
        public FrmStockReport()
        {
            InitializeComponent();
            FillComboBox();   // ItemName combo
            FillLookUp();     // LookUpEdit for search
            FillGrid("SELECT * FROM ProductMaster_Harsh");
        }

        #region Fill Grid
        public void FillGrid(string query)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Agrt.CON))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvSOList.DataSource = dt;   // GridControl datasource
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Fill ComboBox
        void FillComboBox()
        {
            using (SqlConnection con = new SqlConnection(Agrt.CON))
            {
                con.Open();
                // Only ItemName select karvu
                SqlDataAdapter da = new SqlDataAdapter("SELECT ItemName FROM ProductMaster_Harsh", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // “All” option add karo
                DataRow dr = dt.NewRow();
                dr["ItemName"] = "-- All Items --";
                dt.Rows.InsertAt(dr, 0);

                txt_Item.DataSource = dt;
                txt_Item.DisplayMember = "ItemName"; // user ne only ItemName show thase
                txt_Item.ValueMember = "ItemName";   // filtering ma pan ItemName use thase
            }
        }

        #endregion

        #region Fill LookUpEdit (Autocomplete Search)
        void FillLookUp()
        {
            using (SqlConnection con = new SqlConnection(Agrt.CON))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT ItemName FROM ProductMaster_Harsh", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                txt_Product.Properties.DataSource = dt;
                txt_Product.Properties.DisplayMember = "ItemName";
                txt_Product.Properties.ValueMember = "ItemName";   // 🔹 Same as Display

                txt_Product.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                txt_Product.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                txt_Product.Properties.NullText = "-- Search Product --";
            }
        }
        #endregion

        #region LookUpEdit Value Change = Auto Search
        private void txt_Product_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_Product.EditValue != null && txt_Product.EditValue.ToString() != "")
            {
                string itemName = txt_Product.Text;  // 🔹 Take ItemName text
                FillGrid("SELECT * FROM ProductMaster_Harsh WHERE ItemName = '" + itemName + "'");
            }
            else
            {
                // If clear, show all data
                FillGrid("SELECT * FROM ProductMaster_Harsh");
            }
        }
        #endregion

        #region Exit Button
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion

        #region Export Excel
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            GridView view = dgvSOList.MainView as GridView;

            view.OptionsPrint.ExpandAllGroups = true;
            view.OptionsPrint.ExpandAllDetails = true;

            using (var dialog = new SaveFileDialog() { Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = dialog.FileName;
                    view.ExportToXlsx(filePath);
                    MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #endregion

        #region Escape Key
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion

        private void btnDownload_Click(object sender, EventArgs e)
        {
            FillGrid("SELECT * FROM ProductMaster_Harsh");
        }

        private void btnDelete_Click_Click(object sender, EventArgs e)
        {
            try
            {
                GridView view = dgvSOList.MainView as GridView;

                if (view == null || view.FocusedRowHandle < 0)
                {
                    MessageBox.Show("Please select a record to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get ProductId (primary key) and ItemName for confirmation
                object idValue = view.GetRowCellValue(view.FocusedRowHandle, "GTIN");
                object itemName = view.GetRowCellValue(view.FocusedRowHandle, "ItemName");

                if (idValue == null || idValue == DBNull.Value)
                {
                    MessageBox.Show("Selected record does not have a valid ProductId.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string gtin =idValue.ToString();

                // Confirm delete
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete '{itemName}' (ID: {gtin})?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(Agrt.CON))
                    {
                        con.Open();

                        string query = "DELETE FROM ProductMaster_Harsh WHERE GTIN = @GTIN";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@GTIN", gtin);
                            int rows = cmd.ExecuteNonQuery();

                            if (rows > 0)
                            {
                                MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                FillGrid("SELECT * FROM ProductMaster_Harsh"); // reload updated data
                            }
                            else
                            {
                                MessageBox.Show("Record not found or already deleted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while deleting record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
