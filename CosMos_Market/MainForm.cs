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
            Form[] OpenForms = this.MdiChildren;
            bool isopen = false;
            foreach (Form frm in OpenForms)
            {
                if (frm.GetType() == typeof(CategoryForm))
                {
                    isopen = true;
                    frm.Activate();
                }
            }
            if (isopen == false)
            {
                CategoryForm frm = new CategoryForm();
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}
