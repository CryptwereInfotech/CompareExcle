using ClosedXML.Excel;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
namespace ComperExleSheet
{
    public partial class Form1 : Form
    {
        #region GlobalVariables
        List<dynamic> comparisonResult = new List<dynamic>();
        List<ProductData> ExcelData = new List<ProductData>();
        List<TallyProductData> tallyExcelData = new List<TallyProductData>();
        #endregion

        #region DefaultContructor

        public Form1()
        {
            InitializeComponent();

            txt_cmbFilterDev.EditValueChanged += txt_cmbFilterDev_EditValueChanged;
            var filterOptions = new List<KeyValuePair<string, string>>()
             {
                 new KeyValuePair<string, string>("All", "All"),
                 //new KeyValuePair<string, string>("Qty Mismatch", "Qty Mismatch"),
                 new KeyValuePair<string, string>("Missing in Book Stock", "Missing in Book Stock"),
                 new KeyValuePair<string, string>("Missing in Physical Stock", "Missing in Physical Stock"),
              };

            // Bind to LookUpEdit
            txt_cmbFilterDev.Properties.DataSource = filterOptions;
            txt_cmbFilterDev.Properties.DisplayMember = "Value";
            txt_cmbFilterDev.Properties.ValueMember = "Key";
            txt_cmbFilterDev.EditValue = "All"; // Set default selected value

        }
        #endregion

        #region EventHandlings


        //private void btnUploadExcel_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog ofd = new OpenFileDialog();
        //    ofd.Filter = "Excel Files|*.xlsx;";
        //    if (ofd.ShowDialog() == DialogResult.OK)
        //    {
        //        string selectedFileName = Path.GetFileName(ofd.FileName);
        //        DialogResult result = MessageBox.Show(
        //            $"You selected \"{selectedFileName}\"\nDo you want to upload this file?",
        //            "Confirm Upload", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        //        if (result == DialogResult.Yes)
        //        {
        //            ExcelData.Clear();
        //            using (var workbook = new XLWorkbook(ofd.FileName))
        //            {
        //                var worksheet = workbook.Worksheet(1);
        //                var rows = worksheet.RangeUsed().RowsUsed().Skip(1);
        //                foreach (var row in rows)
        //                {
        //                    ExcelData.Add(new ProductData
        //                    {
        //                        SrNo = row.Cell(1).GetString(),
        //                        ItemName = row.Cell(2).GetString(),
        //                        CATNUMBER = row.Cell(3).GetString(),
        //                        GTIN = row.Cell(4).GetString(),
        //                        StockGroup = row.Cell(5).GetString(),
        //                        StockCategory = row.Cell(6).GetString(),
        //                        UOM = row.Cell(7).GetString(),
        //                        HSN = row.Cell(8).GetString(),
        //                        IGSTRate = row.Cell(9).GetString(),
        //                        Qty = row.Cell(10).GetString(),
        //                        ExpiryDate = row.Cell(11).GetString(),
        //                        LotNumber = row.Cell(12).GetString()
        //                    });
        //                }
        //            }

        //            lblExcelStatus.Text = $"✅ File \"{selectedFileName}\" uploaded.";
        //            lblExcelStatus.ForeColor = Color.Green;
        //            lblExcelStatus.Visible = true;
        //        }
        //        else
        //        {
        //            lblExcelStatus.Text = "❌ Upload cancelled.";
        //            lblExcelStatus.ForeColor = Color.OrangeRed;
        //            lblExcelStatus.Visible = true;
        //        }
        //    }
        //}
        private void btnUploadExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel Files|*.xlsx;";
            ofd.Multiselect = true; // allow multiple file selection

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Check duplicate file names
                var duplicateNames = ofd.FileNames
                    .Select(Path.GetFileName)
                    .GroupBy(n => n, StringComparer.OrdinalIgnoreCase)
                    .Where(g => g.Count() > 1)
                    .Select(g => g.Key)
                    .ToList();

                if (duplicateNames.Any())
                {
                    MessageBox.Show(
                        $"You selected duplicate files:\n{string.Join("\n", duplicateNames)}\nPlease remove duplicates and try again.",
                        "Duplicate Files", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var tempList = new List<ProductData>();

                foreach (var file in ofd.FileNames)
                {
                    using (var workbook = new XLWorkbook(file))
                    {
                        var worksheet = workbook.Worksheet(1);
                        var rows = worksheet.RangeUsed().RowsUsed().Skip(1);
                        foreach (var row in rows)
                        {
                            tempList.Add(new ProductData
                            {
                                SrNo = row.Cell(1).GetString(),
                                ItemName = row.Cell(2).GetString(),
                                CATNUMBER = row.Cell(3).GetString(),
                                GTIN = row.Cell(4).GetString(),
                                StockGroup = row.Cell(5).GetString(),
                                StockCategory = row.Cell(6).GetString(),
                                UOM = row.Cell(7).GetString(),
                                HSN = row.Cell(8).GetString(),
                                IGSTRate = row.Cell(9).GetString(),
                                Qty = row.Cell(10).GetString(),
                                ExpiryDate = row.Cell(11).GetString(),
                                LotNumber = row.Cell(12).GetString()
                            });
                        }
                    }
                }

                // Group by CATNUMBER + LotNumber and sum Qty
                ExcelData = tempList
                    .GroupBy(x => new { x.CATNUMBER, x.LotNumber })
                    .Select(g =>
                    {
                        var first = g.First();
                        return new ProductData
                        {
                            SrNo = "",
                            ItemName = first.ItemName,
                            CATNUMBER = first.CATNUMBER,
                            GTIN = first.GTIN,
                            StockGroup = first.StockGroup,
                            StockCategory = first.StockCategory,
                            UOM = first.UOM,
                            HSN = first.HSN,
                            IGSTRate = first.IGSTRate,
                            Qty = g.Sum(x => int.TryParse(x.Qty, out var q) ? q : 0).ToString(),
                            ExpiryDate = first.ExpiryDate,
                            LotNumber = first.LotNumber
                        };
                    })
                    .OrderBy(x => x.ItemName)
                    .ToList();

                // Reset SrNo
                for (int i = 0; i < ExcelData.Count; i++)
                {
                    ExcelData[i].SrNo = (i + 1).ToString();
                }

                lblExcelStatus.Text = $"✅ {ofd.FileNames.Length} files merged successfully.";
                lblExcelStatus.ForeColor = Color.Green;
                lblExcelStatus.Visible = true;
            }
        }

        private void btnUploadTally_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel Files|*.xlsx;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filename = Path.GetFileName(ofd.FileName);
                DialogResult confirm = MessageBox.Show($"You selected \"{filename}\"\nDo you want to upload this file?", "Confirm Upload", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    tallyExcelData.Clear();
                    using (var workbook = new XLWorkbook(ofd.FileName))
                    {
                        var sheet = workbook.Worksheet(1);
                        var rows = sheet.RangeUsed().RowsUsed().Skip(1);
                        foreach (var row in rows)
                        {
                            tallyExcelData.Add(new TallyProductData
                            {
                                PartyName = row.Cell(1).GetString(),
                                CatNo = row.Cell(2).GetString(),
                                DCNo = row.Cell(3).GetString(),
                                DCDate = row.Cell(4).GetString(),
                                BatchNo = row.Cell(5).GetString(),
                                ExpiryDate = row.Cell(6).GetString(),
                                Description = row.Cell(7).GetString(),
                                Qty = row.Cell(8).GetString(),
                                Rate = row.Cell(9).GetString(),
                                Amount = row.Cell(10).GetString(),
                                Category = row.Cell(11).GetString(),
                                Group = row.Cell(12).GetString()
                            });
                        }
                    }

                    lblTallyStatus.Text = $"✅ File \"{filename}\" uploaded.";
                    lblTallyStatus.ForeColor = Color.Green;
                    lblTallyStatus.Visible = true;
                }
                else
                {
                    lblTallyStatus.Text = $"❌ Upload cancelled for \"{filename}\".";
                    lblTallyStatus.ForeColor = Color.OrangeRed;
                    lblTallyStatus.Visible = true;
                }
            }
        }


        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No data available to export.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var workbook = new XLWorkbook())
            {
                var sheet = workbook.Worksheets.Add("MismatchReport");
                for (int col = 0; col < dataGridView1.Columns.Count; col++)
                    sheet.Cell(1, col + 1).Value = dataGridView1.Columns[col].HeaderText;

                for (int row = 0; row < dataGridView1.Rows.Count; row++)
                    for (int col = 0; col < dataGridView1.Columns.Count; col++)
                        sheet.Cell(row + 2, col + 1).Value = dataGridView1.Rows[row].Cells[col].Value?.ToString();

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Files (*.xlsx)|*.xlsx";
                sfd.FileName = "MismatchReport.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(sfd.FileName);
                    MessageBox.Show("Export successful!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //private void btnCompare_Click(object sender, EventArgs e)
        //{
        //    if(ExcelData == null || ExcelData.Count == 0)
        //    {
        //        MessageBox.Show("Please upload the Physical Stock Exel file  first.","Validation",MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    if(tallyExcelData == null || tallyExcelData.Count==0)
        //    {
        //        MessageBox.Show("Please Uplod the Book Stock(Tally) Excel file first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }
        //    //var result = new List<dynamic>();
        //    comparisonResult = new List<dynamic>();
        //    var result = comparisonResult;
        //    var matchedKeys = new HashSet<string>();
        //    foreach (var excelItem in ExcelData)
        //    {
        //        var tallyItem = tallyExcelData.FirstOrDefault(t =>
        //            t.CatNo.Trim() == excelItem.CATNUMBER.Trim() &&
        //            t.BatchNo.Trim() == excelItem.LotNumber.Trim());

        //        if (tallyItem == null)
        //        {
        //            result.Add(new
        //            {
        //                excelItem.SrNo,
        //                excelItem.ItemName,
        //                excelItem.CATNUMBER,
        //                excelItem.Qty,
        //                excelItem.ExpiryDate,
        //                excelItem.LotNumber,
        //                excelItem.StockCategory,
        //                excelItem.StockGroup,
        //                Status = "Missing in Book Stock"
        //            });
        //        }
        //        //else
        //        //{
        //        //    matchedKeys.Add(tallyItem.CatNo.Trim() + "|" + tallyItem.BatchNo.Trim());
        //        //    bool isQtyMismatch = excelItem.Qty.Trim() != tallyItem.Qty.Trim();

        //        //    result.Add(new
        //        //    {
        //        //        excelItem.SrNo,
        //        //        ItemName = excelItem.ItemName,
        //        //        CATNUMBER = excelItem.CATNUMBER,
        //        //        Qty = excelItem.Qty,
        //        //        ExpiryDate = excelItem.ExpiryDate,
        //        //        LotNumber = excelItem.LotNumber,
        //        //        StockCategory = excelItem.StockCategory,
        //        //        StockGroup = excelItem.StockGroup,
        //        //        Status = isQtyMismatch ? "Qty Mismatch" : "Matched"
        //        //    });
        //        //}
        //        else
        //        {
        //            matchedKeys.Add(tallyItem.CatNo.Trim() + "|" + tallyItem.BatchNo.Trim());

        //            int excelQty = 0, tallyQty = 0;
        //            int.TryParse(excelItem.Qty.Trim(), out excelQty);
        //            int.TryParse(tallyItem.Qty.Trim(), out tallyQty);

        //            string status;
        //            if (excelQty != tallyQty)
        //            {
        //                int diff = Math.Abs(excelQty - tallyQty);
        //                if (excelQty > tallyQty)
        //                    status = $"Book stock missing {diff} Qty";
        //                else
        //                    status = $"Physical stock missing {diff} Qty";
        //            }
        //            else
        //            {
        //                status = "Matched";
        //            }

        //            result.Add(new
        //            {
        //                excelItem.SrNo,
        //                ItemName = excelItem.ItemName,
        //                CATNUMBER = excelItem.CATNUMBER,
        //                Qty = excelItem.Qty,
        //                ExpiryDate = excelItem.ExpiryDate,
        //                LotNumber = excelItem.LotNumber,
        //                StockCategory = excelItem.StockCategory,
        //                StockGroup = excelItem.StockGroup,
        //                Status = status
        //            });
        //        }

        //    }

        //    foreach (var tallyItem in tallyExcelData)
        //    {
        //        string key = tallyItem.CatNo.Trim() + "|" + tallyItem.BatchNo.Trim();
        //        if (!matchedKeys.Contains(key))
        //        {
        //            result.Add(new
        //            {
        //                SrNo = "-",
        //                ItemName = tallyItem.Description,
        //                CATNUMBER = tallyItem.CatNo,
        //                Qty = tallyItem.Qty,
        //                ExpiryDate = tallyItem.ExpiryDate,
        //                LotNumber = tallyItem.BatchNo,
        //                StockCategory = tallyItem.Category,
        //                StockGroup = tallyItem.Group,
        //                Status = "Missing in Physical Stock"
        //            });
        //        }
        //    }

        //    dataGridView1.DataSource = result;
        //    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        //    dataGridView1.AutoResizeColumns();
        //    dataGridView1.AutoResizeRows();
        //    dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

        //    foreach (DataGridViewRow row in dataGridView1.Rows)
        //    {
        //        string status = row.Cells["Status"].Value?.ToString();
        //        if (status == "Matched")
        //            row.DefaultCellStyle.BackColor = Color.LightGreen;
        //        //else if (status == "Qty Mismatch")
        //        //    row.DefaultCellStyle.BackColor = Color.Yellow;
        //        else if (status == "Missing in Book Stock")
        //            row.DefaultCellStyle.BackColor = Color.LightPink;
        //        else if (status == "Missing in Physical Stock")
        //            row.DefaultCellStyle.BackColor = Color.Orange;
        //        else if (status.Contains("Book stock missing") || status.Contains("Physical stock missing"))
        //            row.DefaultCellStyle.BackColor = Color.Yellow;
        //    }

        //    int total = comparisonResult.Count;
        //    int matched = comparisonResult.Count(x => (string)x.GetType().GetProperty("Status")?.GetValue(x) == "Matched");
        //    int qtyMismatch = comparisonResult.Count(x => (string)x.GetType().GetProperty("Status")?.GetValue(x) == "Qty Mismatch");
        //    int missingBook = comparisonResult.Count(x => (string)x.GetType().GetProperty("Status")?.GetValue(x) == "Missing in Book Stock");
        //    int missingPhysical = comparisonResult.Count(x => (string)x.GetType().GetProperty("Status")?.GetValue(x) == "Missing in Physical Stock");
        //    int missingPhysicalStockmisingQty = comparisonResult.Count(x => (string)x.GetType().GetProperty("Status")?.GetValue(x) == "Physical stock missing");

        //    lblTotal.Text = $"Total: {total}";
        //    lblMatched.Text = $"Matched: {matched}";
        //    lblQtyMismatch.Text = $"Qty Mismatch: {qtyMismatch}";
        //    lblMissingBook.Text = $"Missing in Book: {missingBook}";
        //    lblMissingPhysical.Text = $"Missing in Physical: {missingPhysical}";

        //    lblStatus.Text = "Comparison completed.";
        //    lblStatus.Text = "Comparison completed.";
        //}
        //private void btnCompare_Click(object sender, EventArgs e)
        //{
        //    if (ExcelData == null || ExcelData.Count == 0)
        //    {
        //        MessageBox.Show("Please upload the Physical Stock Exel file  first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    if (tallyExcelData == null || tallyExcelData.Count == 0)
        //    {
        //        MessageBox.Show("Please Uplod the Book Stock(Tally) Excel file first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }
        //    //var result = new List<dynamic>();
        //    comparisonResult = new List<dynamic>();
        //    var result = comparisonResult;
        //    var matchedKeys = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        //    foreach (var excelItem in ExcelData)
        //    {
        //        var tallyItem = tallyExcelData.FirstOrDefault(t =>
        //        t.CatNo.Trim().Equals(excelItem.CATNUMBER.Trim(), StringComparison.OrdinalIgnoreCase) &&
        //        t.BatchNo.Trim().Equals(excelItem.LotNumber.Trim(), StringComparison.OrdinalIgnoreCase));


        //        if (tallyItem == null)
        //        {
        //            result.Add(new
        //            {
        //                excelItem.SrNo,
        //                excelItem.ItemName,
        //                excelItem.CATNUMBER,
        //                excelItem.Qty,
        //                Physical_Qty = excelItem.Qty, 
        //                Book_Qty = "0",
        //                excelItem.ExpiryDate,
        //                excelItem.LotNumber,
        //                excelItem.StockCategory,
        //                excelItem.StockGroup,
        //                Status = $"Missing in Book Stock {excelItem.Qty} Qty"
        //            });
        //        }
        //        //else
        //        //{
        //        //    matchedKeys.Add(tallyItem.CatNo.Trim() + "|" + tallyItem.BatchNo.Trim());
        //        //    bool isQtyMismatch = excelItem.Qty.Trim() != tallyItem.Qty.Trim();

        //        //    result.Add(new
        //        //    {
        //        //        excelItem.SrNo,
        //        //        ItemName = excelItem.ItemName,
        //        //        CATNUMBER = excelItem.CATNUMBER,
        //        //        Qty = excelItem.Qty,
        //        //        ExpiryDate = excelItem.ExpiryDate,
        //        //        LotNumber = excelItem.LotNumber,
        //        //        StockCategory = excelItem.StockCategory,
        //        //        StockGroup = excelItem.StockGroup,
        //        //        Status = isQtyMismatch ? "Qty Mismatch" : "Matched"
        //        //    });
        //        //}
        //        else
        //        {
        //            matchedKeys.Add(tallyItem.CatNo.Trim() + "|" + tallyItem.BatchNo.Trim());

        //            int excelQty = 0, tallyQty = 0;
        //            int.TryParse(excelItem.Qty.Trim(), out excelQty);
        //            int.TryParse(tallyItem.Qty.Trim(), out tallyQty);

        //            string status;
        //            if (excelQty != tallyQty)
        //            {
        //                int diff = Math.Abs(excelQty - tallyQty);
        //                if (excelQty > tallyQty)
        //                    status = $"Missing in Book Stock  {diff} Qty";
        //                else
        //                    status = $"Missing in Physical Stock  {diff} Qty";
        //            }
        //            else
        //            {
        //                status = "Matched";
        //            }

        //            result.Add(new
        //            {
        //                excelItem.SrNo,
        //                ItemName = excelItem.ItemName,
        //                CATNUMBER = excelItem.CATNUMBER,
        //                Compar_Qty = excelItem.Qty,
        //                Physical_Qty = excelQty.ToString(),  // New column
        //                Book_Qty = tallyQty.ToString(),
        //                ExpiryDate = excelItem.ExpiryDate,
        //                LotNumber = excelItem.LotNumber,
        //                StockCategory = excelItem.StockCategory,
        //                StockGroup = excelItem.StockGroup,
        //                Status = status
        //            });
        //        }

        //    }

        //    foreach (var tallyItem in tallyExcelData)
        //    {
        //        string key = tallyItem.CatNo.Trim() + "|" + tallyItem.BatchNo.Trim();
        //        if (!matchedKeys.Contains(key))
        //        {
        //            result.Add(new
        //            {
        //                SrNo = "-",
        //                ItemName = tallyItem.Description,
        //                CATNUMBER = tallyItem.CatNo,
        //                Qty = tallyItem.Qty,
        //                Physical_Qty = "0",               
        //                Book_Qty = tallyItem.Qty,
        //                ExpiryDate = tallyItem.ExpiryDate,
        //                LotNumber = tallyItem.BatchNo,
        //                StockCategory = tallyItem.Category,
        //                StockGroup = tallyItem.Group,
        //                Status = $"Missing in Physical Stock   {tallyItem.Qty} Qty"
        //            });
        //        }
        //    }

        //    dataGridView1.DataSource = result;
        //    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        //    dataGridView1.AutoResizeColumns();
        //    dataGridView1.AutoResizeRows();
        //    dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

        //    foreach (DataGridViewRow row in dataGridView1.Rows)
        //    {
        //        string status = row.Cells["Status"].Value?.ToString() ?? "";

        //        if (status.Equals("Matched", StringComparison.OrdinalIgnoreCase))
        //            row.DefaultCellStyle.BackColor = Color.LightGreen;
        //        else if (status.IndexOf("Missing in Book Stock", StringComparison.OrdinalIgnoreCase) >= 0)
        //            row.DefaultCellStyle.BackColor = Color.LightPink;
        //        else if (status.IndexOf("Missing in Physical Stock", StringComparison.OrdinalIgnoreCase) >= 0)
        //            row.DefaultCellStyle.BackColor = Color.Orange;
        //    }
        //    int total = comparisonResult.Count;
        //    int matched = comparisonResult.Count(x =>
        //        ((string)x.GetType().GetProperty("Status")?.GetValue(x)).Equals("Matched", StringComparison.OrdinalIgnoreCase));

        //    int missingBook = comparisonResult.Count(x =>
        //        ((string)x.GetType().GetProperty("Status")?.GetValue(x)).IndexOf("Missing in Book Stock", StringComparison.OrdinalIgnoreCase) >= 0);

        //    int missingPhysical = comparisonResult.Count(x =>
        //        ((string)x.GetType().GetProperty("Status")?.GetValue(x)).IndexOf("Missing in Physical Stock", StringComparison.OrdinalIgnoreCase) >= 0);

        //    lblTotal.Text = $"Total: {total}";
        //    lblMatched.Text = $"Matched: {matched}";
        //    lblMissingBook.Text = $"Missing in Book Stock: {missingBook}";
        //    lblMissingPhysical.Text = $"Missing in Physical Stock: {missingPhysical}";

        //    lblStatus.Text = "Comparison completed.";
        //}

        public class CaseInsensitiveTupleComparer : IEqualityComparer<(string, string)>
        {
            public bool Equals((string, string) x, (string, string) y)
            {
                return string.Equals(x.Item1?.Trim(), y.Item1?.Trim(), StringComparison.OrdinalIgnoreCase)
                    && string.Equals(x.Item2?.Trim(), y.Item2?.Trim(), StringComparison.OrdinalIgnoreCase);
            }

            public int GetHashCode((string, string) obj)
            {
                int h1 = obj.Item1?.Trim().ToLowerInvariant().GetHashCode() ?? 0;
                int h2 = obj.Item2?.Trim().ToLowerInvariant().GetHashCode() ?? 0;
                return h1 ^ h2;
            }
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            if (ExcelData == null || ExcelData.Count == 0)
            {
                MessageBox.Show("Please upload the Physical Stock Excel file first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tallyExcelData == null || tallyExcelData.Count == 0)
            {
                MessageBox.Show("Please upload the Book Stock (Tally) Excel file first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            comparisonResult = new List<dynamic>();
            var result = comparisonResult;

            // Build lookups (case-insensitive, trim-safe)
            var excelLookup = ExcelData
                .GroupBy(ei => (ei.CATNUMBER, ei.LotNumber), new CaseInsensitiveTupleComparer())
                .ToDictionary(
                    g => g.Key,
                    g => new
                    {
                        TotalQty = g.Sum(ei => int.TryParse(ei.Qty, out var q) ? q : 0),
                        Item = g.First()
                     
                    },
                    new CaseInsensitiveTupleComparer()
                );

            var tallyLookup = tallyExcelData
                .GroupBy(ti => (ti.CatNo, ti.BatchNo), new CaseInsensitiveTupleComparer())
                .ToDictionary(
                    g => g.Key,
                    g => new
                    {
                        TotalQty = g.Sum(ti => int.TryParse(ti.Qty, out var q) ? q : 0),
                        Item = g.First()
                   

                    },
                    new CaseInsensitiveTupleComparer()
                );

            var matchedKeys = new HashSet<(string, string)>(new CaseInsensitiveTupleComparer());

            // Compare Physical stock with Book stock
            foreach (var kv in excelLookup)
            {
                var key = kv.Key;
                var excelData = kv.Value;
                if (!tallyLookup.TryGetValue(key, out var tallyData))
                {
                    result.Add(new
                    {
                        ItemName = excelData.Item.ItemName,
                        CATNUMBER = excelData.Item.CATNUMBER,
                        //Compar_Qty = excelData.TotalQty.ToString(),
                        Physical_Qty = excelData.TotalQty.ToString(),
                        Book_Qty = "0",
                        ExpiryDate = excelData.Item.ExpiryDate,
                        LotNumber = excelData.Item.LotNumber,
                        StockCategory = excelData.Item.StockCategory,
                        StockGroup = excelData.Item.StockGroup,
                        Status = $"Missing in Book Stock {excelData.TotalQty} Qty"
                    });
                }
                else
                {
                    matchedKeys.Add(key);
                    string status;
                    if (excelData.TotalQty != tallyData.TotalQty)
                    {
                        int diff = Math.Abs(excelData.TotalQty - tallyData.TotalQty);
                        status = excelData.TotalQty > tallyData.TotalQty
                            ? $"Missing in Book Stock {diff} Qty"
                            : $"Missing in Physical Stock {diff} Qty";
                    }
                    else
                    {
                        status = "Matched";
                    }

                    result.Add(new
                    {
                        ItemName = excelData.Item.ItemName,
                        CATNUMBER = excelData.Item.CATNUMBER,
                        //Compar_Qty = excelData.TotalQty.ToString(),
                        Physical_Qty = excelData.TotalQty.ToString(),
                        Book_Qty = tallyData.TotalQty.ToString(),
                        ExpiryDate = excelData.Item.ExpiryDate,
                        LotNumber = excelData.Item.LotNumber,
                        StockCategory = excelData.Item.StockCategory,
                        StockGroup = excelData.Item.StockGroup,
                        Status = status
                    });
                }
            }

            // Missing in Physical stock
            foreach (var kv in tallyLookup)
            {
                if (!matchedKeys.Contains(kv.Key))
                {
                    var tallyData = kv.Value;
                    result.Add(new
                    {
                        ItemName = tallyData.Item.Description,
                        CATNUMBER = tallyData.Item.CatNo,
                        //Compar_Qty = tallyData.TotalQty.ToString(),
                        Physical_Qty = "0",
                        Book_Qty = tallyData.TotalQty.ToString(),
                        ExpiryDate = tallyData.Item.ExpiryDate,
                        LotNumber = tallyData.Item.BatchNo,
                        StockCategory = tallyData.Item.Category,
                        StockGroup = tallyData.Item.Group,
                        Status = $"Missing in Physical Stock {tallyData.TotalQty} Qty"
                    });
                }
            }

            // Bind to grid
            dataGridView1.DataSource = result;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string status = row.Cells["Status"].Value?.ToString() ?? "";
                if (status.Equals("Matched", StringComparison.OrdinalIgnoreCase))
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                else if (status.IndexOf("Missing in Book Stock", StringComparison.OrdinalIgnoreCase) >= 0)
                    row.DefaultCellStyle.BackColor = Color.LightPink;
                else if (status.IndexOf("Missing in Physical Stock", StringComparison.OrdinalIgnoreCase) >= 0)
                    row.DefaultCellStyle.BackColor = Color.Orange;
            }

            // Summary
            int total = comparisonResult.Count;
            int matched = comparisonResult.Count(x =>
                ((string)x.GetType().GetProperty("Status")?.GetValue(x)).Equals("Matched", StringComparison.OrdinalIgnoreCase));
            int missingBook = comparisonResult.Count(x =>
                ((string)x.GetType().GetProperty("Status")?.GetValue(x)).IndexOf("Missing in Book Stock", StringComparison.OrdinalIgnoreCase) >= 0);
            int missingPhysical = comparisonResult.Count(x =>
                ((string)x.GetType().GetProperty("Status")?.GetValue(x)).IndexOf("Missing in Physical Stock", StringComparison.OrdinalIgnoreCase) >= 0);

            lblTotal.Text = $"Total: {total}";
            lblMatched.Text = $"Matched: {matched}";
            lblMissingBook.Text = $"Missing in Book Stock: {missingBook}";
            lblMissingPhysical.Text = $"Missing in Physical Stock: {missingPhysical}";

            lblStatus.Text = "Comparison completed.";
        }


        // Helper method to format date
        private string FormatDate(string dateValue)
        {
            if (DateTime.TryParse(dateValue, out var date))
                return date.ToString("dd/MM/yyyy");
            return dateValue;
        }

        private int CountByStatus(string status)
{
    return comparisonResult.Count(x =>
        (string)x.GetType().GetProperty("Status")?.GetValue(x) == status);
}
        #endregion

        #region UserDefined
private void ApplyFilter(string filterType)
{
    var filteredData = comparisonResult;

    switch (filterType)
    {
        case "All":
            break;

                //case "Qty Mismatch":
                //    filteredData = comparisonResult.Where(x => x.Status == "Qty Mismatch").ToList();
                //    break;

                case "Missing in Book Stock":
                    filteredData = comparisonResult
                        .Where(x => ((string)x.GetType().GetProperty("Status")?.GetValue(x))
                            .IndexOf("Missing in Book Stock", StringComparison.OrdinalIgnoreCase) >= 0)
                        .ToList();
                    break;

                case "Missing in Physical Stock":
                    filteredData = comparisonResult
                        .Where(x => ((string)x.GetType().GetProperty("Status")?.GetValue(x))
                            .IndexOf("Missing in Physical Stock", StringComparison.OrdinalIgnoreCase) >= 0)
                        .ToList();
                    break;
            }

    dataGridView1.DataSource = filteredData;
    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
    dataGridView1.AutoResizeColumns();
    dataGridView1.AutoResizeRows();
    dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string status = row.Cells["Status"].Value?.ToString() ?? "";

                if (status.Equals("Matched", StringComparison.OrdinalIgnoreCase))
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                else if (status.IndexOf("Missing in Book Stock", StringComparison.OrdinalIgnoreCase) >= 0)
                    row.DefaultCellStyle.BackColor = Color.LightPink;
                else if (status.IndexOf("Missing in Physical Stock", StringComparison.OrdinalIgnoreCase) >= 0)
                    row.DefaultCellStyle.BackColor = Color.Orange;
            }
        }

      
        public class ProductData
        {
            public string SrNo { get; set; }
            public string ItemName { get; set; }
            public string CATNUMBER { get; set; }
            public string GTIN { get; set; }
            public string StockGroup { get; set; }
            public string StockCategory { get; set; }
            public string UOM { get; set; }
            public string HSN { get; set; }
            public string IGSTRate { get; set; }
            public string Qty { get; set; }
            public string ExpiryDate { get; set; }
            public string LotNumber { get; set; }
        }

        public class TallyProductData
        {
            public string PartyName { get; set; }
            public string CatNo { get; set; }
            public string DCNo { get; set; }
            public string DCDate { get; set; }
            public string BatchNo { get; set; }
            public string ExpiryDate { get; set; }
            public string Description { get; set; }
            public string Qty { get; set; }
            public string Rate { get; set; }
            public string Amount { get; set; }
            public string Category { get; set; }
            public string Group { get; set; }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        #endregion

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ExcelData.Clear();
            tallyExcelData.Clear();
            comparisonResult.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            lblExcelStatus.Text = "";
            lblExcelStatus.Visible = false;
            lblTallyStatus.Text = "";
            lblTallyStatus.Visible = false;
            lblTotal.Text = "";
            lblMatched.Text = "";
            lblMissingBook.Text = "";
            lblMissingPhysical.Text = "";

            lblStatus.Text = "";

            MessageBox.Show("Data has been refeshed.","Refresh",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbFilter.Items.Clear();
            cmbFilter.Items.Add("All");
            cmbFilter.Items.Add("Qty Mismatch");
            cmbFilter.Items.Add("Missing in Book Stock");
            cmbFilter.Items.Add("Missing in Physical Stock");
            cmbFilter.SelectedIndex = 0; // Default selection: All
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilter.SelectedItem != null)
            {
                string selectedFilter = cmbFilter.SelectedItem.ToString();
                ApplyFilter(selectedFilter);
            }
        }

        private void txt_cmbFilterDev_EditValueChanged(object sender, EventArgs e)
        {
            string selectedValue = txt_cmbFilterDev.EditValue?.ToString();
            ApplyFilter(selectedValue);
        }
    }
}
