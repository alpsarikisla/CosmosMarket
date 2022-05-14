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
    public partial class BrandForm : Form
    {
        DataModel dm = new DataModel();
        int selectedid=0;
        public BrandForm()
        {
            InitializeComponent();
        }
        private void BrandForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dm.GetBrands();
        }
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Brand b = new Brand();
            b.Name = tb_name.Text;
            b.Status = cb_durum.Checked;

            int id = dm.AddBrand(b);

            if (id != -1)
            {
                MessageBox.Show($"Marka {id} id ile başarıyla eklenmiştir", "Başarılı");
                tb_name.Text = "";
                cb_durum.Checked = false;
            }
            else
            {
                MessageBox.Show("Marka Eklenirken bir hata oluştu", "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridView1.DataSource = dm.GetBrands();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Brand b = dm.GetBrand(selectedid);
            b.Name = tb_name.Text;
            b.Status = cb_durum.Checked;
            if (dm.UpdateBrand(b))
            {
                MessageBox.Show("Marka Güncelleme Başarılı", "Başarılı");
            }
            else
            {
                MessageBox.Show("Marka Güncellenirken bir hata Oluştu", "Başarısız");
            }
            dataGridView1.DataSource = dm.GetBrands();
            tb_ID.Text = tb_name.Text = "";
            cb_durum.Checked = false;
            btn_update.Visible = false;
        }

        private void TSMI_guncelle_Click(object sender, EventArgs e)
        {
            if (selectedid != 0)
            {
                Brand b = dm.GetBrand(selectedid);
                tb_ID.Text = b.ID.ToString();
                tb_name.Text = b.Name;
                cb_durum.Checked = b.Status;
                btn_update.Visible = true;
            }
        }

        private void TSMI_sil_Click(object sender, EventArgs e)
        {
            if (selectedid != 0)
            {
                if (dm.DeleteBrand(selectedid))
                {
                    MessageBox.Show("Marka başarıyla silindi", "Başarılı");
                }
                else
                {
                    MessageBox.Show("Marka silerken bir hata oluştu", "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dataGridView1.DataSource = dm.GetBrands();
            }
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
                    contextMenuStrip1.Show(this.dataGridView1, new Point(e.X, e.Y));
                    selectedid = Convert.ToInt32(dataGridView1.Rows[hit.RowIndex].Cells[0].Value);
                }
            }
        }
    }
}
