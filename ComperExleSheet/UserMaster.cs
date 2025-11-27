using DevExpress.Data.Helpers;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComperExleSheet
{
    
    public partial class UserMaster : Form
    {
        #region GlobalVariables
        public int MainId;
        public SqlCommand cmd;
        public int level;
        public List<SqlParameter> Parameters = new List<SqlParameter>();
        public List<SqlCommand> CmdList = new List<SqlCommand>();
        #endregion
        public UserMaster()
        {
            InitializeComponent();
            FillGrid();

            this.WindowState = FormWindowState.Maximized;  // maximizes the form
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private bool IsValidate()
        {
            if (string.IsNullOrWhiteSpace(txt_Username.Text))
            {
                MessageBox.Show("Please enter Username.");
                txt_Username.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_Password.Text))
            {
                MessageBox.Show("Please enter Password.");
                txt_Password.Focus();
                return false;
            }
            return true;
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (!IsValidate()) return;
            string hashedPassword = SecurityHelper.GetSHA256(txt_Password.Text.Trim());

            cmd = new SqlCommand("SP_UserMaster_Harsh");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserName", txt_Username.Text.Trim());
            cmd.Parameters.AddWithValue("@Upassword", hashedPassword);


            if (level == 0) 
            {
                cmd.Parameters.AddWithValue("@StatementType", "I");
            }
            else if (level == 1) 
            {
                cmd.Parameters.AddWithValue("@StatementType", "U");
                cmd.Parameters.AddWithValue("@Uid", MainId);
            }

            CmdList.Clear();
            CmdList.Add(cmd);

            if (Agrt.PerfomOpration(CmdList, Agrt.CON))
            {
                MessageBox.Show("Saved successfully!");
                level = 0;
                btn_Edit.Enabled = true;
                ClearAll();
            }
        }
        public void ClearAll()
        {
            txt_Username.ResetText();
            txt_Password.ResetText();
            txt_Username.Focus();
            FillGrid();
        }
        void FillGrid()
        {
            cmd = new SqlCommand("SP_UserMaster_Harsh");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "S");

            DataTable dt = Agrt.FetchData(cmd);
            dgvList.DataSource = dt;

            GridView grid = (GridView)dgvList.MainView;
            grid.OptionsView.ShowGroupPanel = false;
            grid.Appearance.HeaderPanel.Font = new Font("Arial", 12, FontStyle.Bold);
            grid.Appearance.Row.Font = new Font("Arial", 10, FontStyle.Regular);

            if (grid.Columns["CreatedDate"] != null)
                grid.Columns["CreatedDate"].Visible = false;
                grid.Columns["Uid"].Visible = false;

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            GridView grid = (GridView)dgvList.MainView;
            if (grid.FocusedRowHandle >= 0)
            {
                MainId = Convert.ToInt32(grid.GetRowCellValue(grid.FocusedRowHandle, "Uid"));
                txt_Username.Text = grid.GetRowCellValue(grid.FocusedRowHandle, "UserName").ToString();
                txt_Password.Text = grid.GetRowCellValue(grid.FocusedRowHandle, "Upassword").ToString();

                level = 1;
                btn_Edit.Enabled = false;
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            GridView grid = (GridView)dgvList.MainView;
            if (grid.FocusedRowHandle < 0)
            {
                MessageBox.Show("Please select a record to delete.");
                return;
            }

            MainId = Convert.ToInt32(grid.GetRowCellValue(grid.FocusedRowHandle, "Uid"));

            if (MessageBox.Show("Are you sure to delete?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cmd = new SqlCommand("SP_UserMaster_Harsh");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StatementType", "D");
                cmd.Parameters.AddWithValue("@Uid", MainId);

                CmdList.Clear();
                CmdList.Add(cmd);

                if (Agrt.PerfomOpration(CmdList, Agrt.CON))
                {
                    MessageBox.Show("Deleted successfully!");
                    ClearAll();
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
