using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace CosMos_Market
{
    public partial class AddCategory : Form
    {
        DataModel dm = new DataModel();
        public AddCategory()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (dm.AddCategory(new Category(){Name = tb_name.Text,Description = tb_description.Text}))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Kategori Eklenemedi", "Hata");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
