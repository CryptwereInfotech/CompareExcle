using System;
using System.Windows.Forms;

namespace ComperExleSheet
{
    public partial class MainParent : Form
    {
        public MainParent()
        {
            InitializeComponent();
            this.IsMdiContainer = true; // ✅ Make this form an MDI container
        }

        private void menuProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm<ProductMaster>();
        }

        private void menuPhysicalVerification_Click(object sender, EventArgs e)
        {
            OpenChildForm<Form1>();
        }

        // Generic method to open forms
        private void OpenChildForm<T>() where T : Form, new()
        {
            bool isExist = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f is T)
                {
                    f.BringToFront();
                    isExist = true;
                    break;
                }
                else
                {
                    f.Close();
                }
            }

            if (!isExist)
            {
                T childForm = new T
                {
                    MdiParent = this
                };
                childForm.Show();
            }
        }

        private void userMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm<UserMaster>();
        }

        private void productListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm<FrmStockReport>();
        }
    }
}
