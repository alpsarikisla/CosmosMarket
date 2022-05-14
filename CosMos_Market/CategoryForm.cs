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
    public partial class CategoryForm : Form
    {
        DataModel dm = new DataModel();
        int selectedid = 0;
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dm.GetCategories();
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dataGridView1.HitTest(e.X, e.Y);
                dataGridView1.ClearSelection();
                if (hit.RowIndex != -1)
                {
                    dataGridView1.Rows[hit.RowIndex].Selected = true;
                    this.contextMenuStrip1.Show(this.dataGridView1, new Point(e.X, e.Y));
                    selectedid = Convert.ToInt32(dataGridView1.Rows[hit.RowIndex].Cells[0].Value);
                }
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_name.Text))
            {
                Category c = new Category();
                c.Name = tb_name.Text;
                c.Description = tb_description.Text;
                if (dm.AddCategory(c))
                {
                    MessageBox.Show("Kategori başarıyla eklendi", "Başarılı");
                    dataGridView1.DataSource = dm.GetCategories();
                    tb_description.Text = tb_name.Text = "";
                }
                else
                {
                    MessageBox.Show("Bir hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Kategori adı boş bırakılamaz","Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TSMI_Sil_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show(selectedid.ToString() + " id li kategoriyi silmek istediğinize emin misiniz?", "kategori Sil", MessageBoxButtons.YesNo);
            if (sonuc == DialogResult.Yes)
            {
                if (dm.DeleteCategory(selectedid))
                {
                    dataGridView1.DataSource = dm.GetCategories();
                    MessageBox.Show("kategori başarıyla silindi", "Başarılı");
                }
                else
                {
                    MessageBox.Show("Hata Oluştu", "Hata");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı silme işlemini iptal etti", "İptal edildi");
            }
        }

        private void TSMI_Guncelle_Click(object sender, EventArgs e)
        {
            Category c = dm.GetCategory(selectedid);
            tb_description.Text = c.Description;
            tb_name.Text = c.Name;
            tb_ID.Text = c.ID.ToString();
            btn_update.Visible = true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Category c = dm.GetCategory(selectedid);
            c.Description = tb_description.Text;
            c.Name = tb_name.Text;

            if (dm.UpdateCategory(c))
            {
                dataGridView1.DataSource = dm.GetCategories();
                MessageBox.Show("Güncelleme Başarılı", "Başarılı");
                btn_update.Visible = false;
                tb_description.Text = tb_ID.Text = tb_name.Text = "";
            }
            else
            {
                MessageBox.Show("Güncelleme Başarısız", "Başarısız");
            }
        }
    }
}
