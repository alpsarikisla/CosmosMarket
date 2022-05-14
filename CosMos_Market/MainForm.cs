using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosMos_Market
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            UserLogin frm = new UserLogin();
            frm.ShowDialog();
            InitializeComponent();
            toolStripStatusLabel1.Text = ActiveUser.user.Name + " " + ActiveUser.user.Surname;
        }

        private void TSMI_CategoryFormOpen_Click(object sender, EventArgs e)
        {
            OpenForm(new CategoryForm());
        }

        private void TSMI_OpenProductForm_Click(object sender, EventArgs e)
        {
            OpenForm(new ProductForm());
        }

        private void TSMI_OpenBrandForm_Click(object sender, EventArgs e)
        {
            OpenForm(new BrandForm());
        }

        public void OpenForm(Form frm)
        {
            Form[] OpenForms = this.MdiChildren;
            bool isopen = false;
            foreach (Form item in OpenForms)
            {
                if (frm.GetType() == item.GetType())
                {
                    isopen = true;
                    item.Activate();
                }
            }
            if (isopen == false)
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

       
    }
}
