using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ComperExleSheet
{
    public static class Agrt
    {
  
        // Connection string from App.config
        public static string CON
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            }
        }

        /// <summary>
        /// Execute multiple SqlCommand objects in a single transaction.
        /// Returns true if success, false if fail.
        /// </summary>
        public static bool PerfomOpration(List<SqlCommand> CmdList, string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlTransaction tran = con.BeginTransaction();
                try
                {
                    foreach (SqlCommand cmd in CmdList)
                    {
                        cmd.Connection = con;
                        cmd.Transaction = tran;
                        cmd.ExecuteNonQuery();
                    }
                    tran.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    System.Windows.Forms.MessageBox.Show("DB Error: " + ex.Message);
                    return false;
                }
            }
        }

        /// <summary>
        /// Execute a single command (non-query) like Insert/Update/Delete
        /// </summary>
        public static bool ExecuteCommand(SqlCommand cmd)
        {
            using (SqlConnection con = new SqlConnection(CON))
            {
                con.Open();
                try
                {
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("DB Error: " + ex.Message);
                    return false;
                }
            }
        }

        public static DataTable FetchData(SqlCommand cmd)
        {
            using (SqlConnection con = new SqlConnection(CON))
            {
                cmd.Connection = con;
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                return dt;
            }
        }
        public static void FillComboBox(SqlConnection con, string TableName, string DisplayField, string valueField, System.Windows.Forms.ComboBox cmb, string Condition = "", bool ShowSelect = false, bool DisplayOnlyPositive = true)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();
                SqlCommand Cmd;
                if (DisplayOnlyPositive)
                {
                    if (Condition.ToUpper().Contains("WHERE"))
                        Condition = Condition + " And [" + valueField + "] >= 0";
                    else
                        Condition = " Where [" + valueField + "] >= 0";
                }

                if (Condition.ToUpper().Contains("ORDER BY"))
                    Cmd = new SqlCommand("Select [" + DisplayField + "],[" + valueField + "] from [" + TableName + "] " + Condition, con);
                else
                    Cmd = new SqlCommand("Select [" + DisplayField + "],[" + valueField + "] from [" + TableName + "] " + Condition + " ORDER BY [" + DisplayField + "]", con);
                // Clipboard.SetText(Cmd.CommandText)
                SqlDataAdapter adp = new SqlDataAdapter(Cmd);
                DataTable ds = new DataTable();
                adp.Fill(ds);
                DataRow row = ds.NewRow();
                row[1] = 0;
                row[0] = "Please select";
                ds.Rows.InsertAt(row, 0);
                // cmb.DataSource = Nothing                  
                cmb.DataSource = ds;
                cmb.ValueMember = ds.Columns[1].ToString();
                cmb.DisplayMember = ds.Columns[0].ToString();// TableName & "." &
                cmb.AutoCompleteMode = AutoCompleteMode.Suggest;
                cmb.AutoCompleteSource = AutoCompleteSource.ListItems;
                cmb.DropDownStyle = ComboBoxStyle.DropDownList;
                cmb.SelectedValue = 0;
                cmb.Font = new Font("Arial", 11, FontStyle.Bold);

            }
            catch (Exception ex)
            {
                // MsgBox(ex.ToString)
                cmb.DataSource = null;
            }
        }
        public static void FillItemComboBox(SqlConnection con, string TableName, string DisplayField, string valueField, LookUpEdit cmb, string Condition = "", bool ShowSelect = false, bool DisplayOnlyPositive = true)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();
                SqlCommand Cmd;
                if (DisplayOnlyPositive)
                {
                    if (Condition.ToUpper().Contains("WHERE"))
                        Condition = Condition + " And [" + valueField + "] >= 0";
                    else
                        Condition = " Where [" + valueField + "] >= 0";
                }

                if (Condition.ToUpper().Contains("ORDER BY"))
                    Cmd = new SqlCommand("Select [" + DisplayField + "],[" + valueField + "] from [" + TableName + "] " + Condition, con);
                else
                    Cmd = new SqlCommand("Select [" + DisplayField + "],[" + valueField + "] from [" + TableName + "] " + Condition + " ORDER BY [" + DisplayField + "]", con);
                // Clipboard.SetText(Cmd.CommandText)
                SqlDataAdapter adp = new SqlDataAdapter(Cmd);
                DataTable ds = new DataTable();
                adp.Fill(ds);
                DataRow row = ds.NewRow();
                row[1] = 0;
                row[0] = "Please select";
                ds.Rows.InsertAt(row, 0);
                // cmb.DataSource = Nothing                  
                cmb.Properties.DataSource = ds;
                cmb.Properties.ValueMember = ds.Columns[1].ToString();
                cmb.Properties.DisplayMember = ds.Columns[0].ToString();// TableName & "." &
                if (cmb.Properties.Columns.Count == 0)
                    cmb.Properties.Columns.Add(new LookUpColumnInfo(DisplayField, "Name"));
                cmb.Font = new Font("Arial", 12, FontStyle.Bold);
                cmb.Properties.AppearanceDropDown.Font = new Font("Arial", 12, FontStyle.Regular);

            }
            catch (Exception ex)
            {
                // MsgBox(ex.ToString)
                cmb.Properties.DataSource = null;
            }
        }
        public static string GetFirstOrDefault(SqlConnection CON, string TableName, string FieldName, string Condition = "")
        {
            try
            {
                if (CON.State != ConnectionState.Open)
                    CON.Open();
                SqlCommand CMD = new SqlCommand("Select [" + FieldName + "] from [" + TableName + "] " + Condition, CON);
                return CMD.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
